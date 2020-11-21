using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;

// theres a wild meme in your code!
// dont deface me or my code ever again - allan;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace jimTileLoader
{
    public partial class jimTileForm : Form
    {
        // Holds tiles
        List<tile> allTiles;
        List<item> allItems;

        // The tile set
        Image tileSet;
        Image itemSet;

        // Images or tiles
        bool tiles;

        // Index of the selected
        int selected_index = -1;

        public jimTileForm()
        {
            InitializeComponent();
            
            // Load our image
            tileSet = new Bitmap("images/tiles.png");
            itemSet = new Bitmap("images/items.png");

            // New list
            allTiles = new List<tile>();
            allItems = new List<item>();
        }

        // Check if ID value is used already
        private bool check_unique_id( int newID, int index_to_skip)
        {
            for( int i = 0; i < allTiles.Count; i++)
            {
                // Already in use
                if (newID == allTiles.ElementAt(i).id && i != index_to_skip)
                    return false;
            }

            // No match!
            return true;
        }

        // Select something else from the list
        private void lbTileSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tiles)
            {
                if (lbTileSelect.SelectedItem != null)
                {
                    // Current selected tile
                    selected_index = lbTileSelect.Items.IndexOf(lbTileSelect.SelectedItem as object);

                    // Name
                    tbName.Text = allTiles.ElementAt(selected_index).name;

                    // Height & Width
                    nudHeight.Value = allTiles.ElementAt(selected_index).height;
                    nudWidth.Value = allTiles.ElementAt(selected_index).width;

                    // Type
                    if (allTiles.ElementAt(selected_index).attribute == "NON_SOLID")
                        cbType.SelectedIndex = 0;
                    else if (allTiles.ElementAt(selected_index).attribute == "SOLID")
                        cbType.SelectedIndex = 1;

                    // Special image types (animated and dynamic)
                    nudTilesHigh.Value = allTiles.ElementAt(selected_index).img_sheet_h;
                    nudTilesWide.Value = allTiles.ElementAt(selected_index).img_sheet_w;

                    // Type of special
                    if (allTiles.ElementAt(selected_index).img_type == "animated")
                        rbAnimated.Checked = true;
                    else if (allTiles.ElementAt(selected_index).img_type == "dynamic")
                        rbDynamic.Checked = true;
                    else
                        rbNone.Checked = true;


                    // Height & Width
                    nudImgHeight.Value = allTiles.ElementAt(selected_index).img_h;
                    nudImgWidth.Value = allTiles.ElementAt(selected_index).img_w;

                    // Img coords
                    nudImgCoordX.Value = allTiles.ElementAt(selected_index).img_x;
                    nudImgCoordY.Value = allTiles.ElementAt(selected_index).img_y;

                    // Unique ID
                    nudID.Value = allTiles.ElementAt(selected_index).id;

                    // Check if unique
                    if (!check_unique_id((int)nudID.Value, selected_index))
                        nudID.BackColor = Color.Red;
                    else
                        nudID.BackColor = Color.White;

                    // Draw images
                    if (allTiles != null && selected_index > -1)
                    {
                        redraw_image();
                    }
                }
            }
            else
            {
                if (lbTileSelect.SelectedItem != null)
                {
                    // Current selected tile
                    selected_index = lbTileSelect.Items.IndexOf(lbTileSelect.SelectedItem as object);

                    // Name
                    tbName.Text = allItems.ElementAt(selected_index).name;

                    // Img coords
                    nudImgCoordX.Value = allItems.ElementAt(selected_index).img_x;
                    nudImgCoordY.Value = allItems.ElementAt(selected_index).img_y;

                    // Draw images
                    if (allItems != null && selected_index > -1)
                    {
                        redraw_image();
                    }
                }
            }
        }
        
        // Change width
        private void nudImgWidth_ValueChanged(object sender, EventArgs e)
        {
            if( tiles)
                allTiles.ElementAt(selected_index).img_w = (int)nudImgWidth.Value;

            redraw_image();
        }

        // Change height
        private void nudImgHeight_ValueChanged(object sender, EventArgs e)
        {
            if (tiles)
                allTiles.ElementAt(selected_index).img_h = (int)nudImgHeight.Value;

            redraw_image();
        }

        // Change img coord x
        private void nudImgCoordX_ValueChanged(object sender, EventArgs e)
        {
            if (tiles)
                allTiles.ElementAt(selected_index).img_x = (int)nudImgCoordX.Value;
            else
                allItems.ElementAt(selected_index).img_x = (int)nudImgCoordX.Value;

            redraw_image();
        }

        // Change img coord y
        private void nudImgCoordY_ValueChanged(object sender, EventArgs e)
        {
            if (tiles)
                allTiles.ElementAt(selected_index).img_y = (int)nudImgCoordY.Value;
            else
                allItems.ElementAt(selected_index).img_y = (int)nudImgCoordY.Value;

            redraw_image();
        }

        // Redraw our image when needed
        private void redraw_image()
        {
            // Draw first tile
            RectangleF destinationRect = new RectangleF(
                pbImage.Location.X, pbImage.Location.Y,
                pbImage.Size.Width, pbImage.Size.Height);


            RectangleF sourceRect;
            
            if( tiles)
                sourceRect = new RectangleF( 16 * allTiles.ElementAt(selected_index).img_x, 16 * allTiles.ElementAt(selected_index).img_y,
                                             16 * allTiles.ElementAt(selected_index).img_w, 16 * allTiles.ElementAt(selected_index).img_h);
            else
                sourceRect = new RectangleF(16 * allItems.ElementAt(selected_index).img_x, 16 * allItems.ElementAt(selected_index).img_y,
                                            16, 16);

            // Create a graphic class
            Graphics x = this.CreateGraphics();

            // Nearest neighbour
            x.InterpolationMode = InterpolationMode.NearestNeighbor;

            // Draw the current image
            if (tiles)
                x.DrawImage( tileSet, destinationRect, sourceRect, GraphicsUnit.Pixel);
            else
                x.DrawImage( itemSet, destinationRect, sourceRect, GraphicsUnit.Pixel);
        }

        // Change name
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            // Change name
            if( tiles)
                allTiles.ElementAt(selected_index).name = tbName.Text;
            else
                allItems.ElementAt(selected_index).name = tbName.Text;

            // Change in list
            lbTileSelect.Items[selected_index] = tbName.Text;
        }

        // Change type
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Type
            if( tiles)
                allTiles.ElementAt(selected_index).attribute = cbType.Text;
        }

        // Add tile
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tiles)
            {
                // New tile
                tile newTile = new tile();

                // Set vals
                newTile.name = "NewTile";
                newTile.attribute = "NON_SOLID";

                newTile.img_x = 0;
                newTile.img_y = 0;
                newTile.img_w = 1;
                newTile.img_h = 1;
                newTile.id = 0;

                newTile.img_sheet_h = 1;
                newTile.img_sheet_w = 1;

                newTile.width = 1;
                newTile.height = 1;

                newTile.img_type = "";

                // Make new item for list box
                lbTileSelect.Items.Add(newTile.name);

                // Add to list
                allTiles.Add(newTile);
            }
            else
            {
                // New item
                item newItem = new item();

                // Set vals
                newItem.name = "NewItem";

                newItem.img_x = 0;
                newItem.img_y = 0;
                newItem.value = 0;

                // Make new item for list box
                lbTileSelect.Items.Add(newItem.name);

                // Add to list
                allItems.Add(newItem);
            }
        }

        // Remove tile
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Remove item for list box
            lbTileSelect.Items.RemoveAt(selected_index);

            // Remove from the list
            if (tiles)
                allTiles.RemoveAt(selected_index);
            else
                allItems.RemoveAt(selected_index);

            // Selected index in list box
            if (selected_index >= lbTileSelect.Items.Count)
                selected_index -= 1;

            // Make sure items are in the list
            if( selected_index >= 0)
                lbTileSelect.SetSelected( selected_index, true);
        }

        // Change ID Value
        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            // Set new value in object
            if (tiles)
            {
                allTiles.ElementAt(selected_index).id = (int)nudID.Value;

                // Check if unique
                if (!check_unique_id((int)nudID.Value, selected_index))
                    nudID.BackColor = Color.Red;
                else
                    nudID.BackColor = Color.White;
            }
        }

        // Load a tileset from xml
        private void tilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tiles loaded
            tiles = true;

            // Disable value
            nudValue.Enabled = false;
            nudImgWidth.Enabled = true;
            nudImgHeight.Enabled = true;
            nudWidth.Enabled = true;
            nudHeight.Enabled = true;
            gbNebAware.Enabled = true;
            nudID.Enabled = true;
            cbType.Enabled = true;

            // Open dialog box
            string fileToOpen = "null";

            DialogResult result = ofdOpenFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
                fileToOpen = ofdOpenFile.FileName;

            // No red nudID
            nudID.BackColor = Color.White;

            // Make sure its loading
            if (fileToOpen != "null")
            {
                // Our container for the xml document
                // Load from a static location (for now)
                XDocument xdoc = XDocument.Load(fileToOpen);

                // Number of tiles
                int count = xdoc.Descendants("tile").Count();

                // Clear list
                lbTileSelect.Items.Clear();

                // Load data into all tiles
                int counter = 0;
                foreach (XElement item in xdoc.Descendants("tile"))
                {
                    // New tile
                    tile newTile = new tile();

                    // Set vals   
                    newTile.name = item.Element("name").Value.ToString();
                    newTile.attribute = item.Element("attrubite").Value.ToString();

                    newTile.width = Int32.Parse(item.Element("width").Value);
                    newTile.height = Int32.Parse(item.Element("height").Value);

                    newTile.img_type = item.Element("image").Attribute("type").Value.ToString();
                    newTile.img_sheet_w = Int32.Parse(item.Element("image").Attribute("s_w").Value);
                    newTile.img_sheet_h = Int32.Parse(item.Element("image").Attribute("s_h").Value);

                    newTile.img_x = Int32.Parse(item.Element("image").Attribute("x").Value);
                    newTile.img_y = Int32.Parse(item.Element("image").Attribute("y").Value);
                    newTile.img_w = Int32.Parse(item.Element("image").Attribute("w").Value);
                    newTile.img_h = Int32.Parse(item.Element("image").Attribute("h").Value);

                    newTile.id = Int32.Parse(item.Attribute("id").Value);

                    // Make new item for list box
                    lbTileSelect.Items.Add(newTile.name);

                    // Add to list
                    allTiles.Add(newTile);

                    // Inc counter
                    counter++;
                }
            }
        }


        // Message box to show about
        private void aboutJimTileLoaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Jim Tile Loader for Jim Farm \nCreated by Allan Legemaate 2016 for ADS Games \nhttp://adsgames.net");
        }

        private void saveXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save xml to file
            XElement tiles = new XElement("tiles");

            // Go through tiles and then save
            for (int i = 0; i < allTiles.Count; i++)
            {
                // Comments
                XComment newTileComment = new XComment(allTiles.ElementAt(i).name.ToUpper());

                // Add comment to xml file
                tiles.Add(newTileComment);

                // Add all the data into a xml tile
                XElement newTile =
                    new XElement("tile",
                        new XAttribute("id", allTiles.ElementAt(i).id),
                        new XElement("name", allTiles.ElementAt(i).name),
                        new XElement("width", allTiles.ElementAt(i).width),
                        new XElement("height", allTiles.ElementAt(i).height),
                        new XElement("image",
                            new XAttribute("type", allTiles.ElementAt(i).img_type),
                            new XAttribute("s_w", allTiles.ElementAt(i).img_sheet_w),
                            new XAttribute("s_h", allTiles.ElementAt(i).img_sheet_h),
                            new XAttribute("x", allTiles.ElementAt(i).img_x.ToString()),
                            new XAttribute("y", allTiles.ElementAt(i).img_y.ToString()),
                            new XAttribute("h", allTiles.ElementAt(i).img_h.ToString()),
                            new XAttribute("w", allTiles.ElementAt(i).img_w.ToString())
                        ),
                        new XElement("attrubite", allTiles.ElementAt(i).attribute.ToString())
                    );

                // Add data to xml file
                tiles.Add(newTile);
            }

            // Save to file
            tiles.Save("data/newTiles.xml");
        }

        // Change image extended type
        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            if (tiles)
                allTiles.ElementAt(selected_index).img_type = "";
        }

        private void rbDynamic_CheckedChanged(object sender, EventArgs e)
        {
            if (tiles)
                allTiles.ElementAt(selected_index).img_type = "dynamic";
        }

        private void rbAnimated_CheckedChanged(object sender, EventArgs e)
        {
            if (tiles)
                allTiles.ElementAt(selected_index).img_type = "animated";
        }

        private void rbMeta_CheckedChanged(object sender, EventArgs e)
        {
            if (tiles)
                allTiles.ElementAt(selected_index).img_type = "meta_map";
        }

        // Change tilemap width
        private void nudTilesWide_ValueChanged(object sender, EventArgs e)
        {
            if (tiles)
                allTiles.ElementAt(selected_index).img_sheet_w = (int)nudTilesWide.Value;
        }

        // Change tilemap width
        private void nudTilesHigh_ValueChanged(object sender, EventArgs e)
        {
            if (tiles)
                allTiles.ElementAt(selected_index).img_sheet_h = (int)nudTilesHigh.Value;
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            if (tiles)
                allTiles.ElementAt(selected_index).width = (int)nudWidth.Value;
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            if( tiles)
                allTiles.ElementAt(selected_index).height = (int)nudHeight.Value;
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tiles loaded
            tiles = false;

            // Disable value
            nudValue.Enabled = true;
            nudImgWidth.Enabled = false;
            nudImgHeight.Enabled = false;
            nudWidth.Enabled = false;
            nudHeight.Enabled = false;
            gbNebAware.Enabled = false;
            nudID.Enabled = false;
            cbType.Enabled = false;

            // Open dialog box
            string fileToOpen = "null";

            DialogResult result = ofdOpenFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
                fileToOpen = ofdOpenFile.FileName;

            // Make sure its loading
            if (fileToOpen != "null")
            {
                // Our container for the xml document
                // Load from a static location (for now)
                XDocument xdoc = XDocument.Load(fileToOpen);

                // Number of tiles
                int count = xdoc.Descendants("tile").Count();

                // Clear list
                lbTileSelect.Items.Clear();

                // Change id color
                nudID.BackColor = Color.White;

                // Load data into all tiles
                int counter = 0;
                foreach (XElement item in xdoc.Descendants("item"))
                {
                    // New newItem
                    item newItem = new item();

                    // Set vals   
                    newItem.name = item.Element("name").Value.ToString();
                    newItem.value = Int32.Parse(item.Element("value").Value);
                    newItem.img_x = Int32.Parse(item.Element("image").Attribute("x").Value);
                    newItem.img_y = Int32.Parse(item.Element("image").Attribute("y").Value);

                    // Make new item for list box
                    lbTileSelect.Items.Add(newItem.name);

                    // Add to list
                    allItems.Add(newItem);

                    // Inc counter
                    counter++;
                }
            }
        }
    }
}