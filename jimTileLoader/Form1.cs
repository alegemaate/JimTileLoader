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
    public partial class Form1 : Form
    {
        // Holds tiles
        List<tile> allTiles;

        // The tile set
        Image tileSet;

        // Index of the selected
        int selected_index = -1;

        public Form1()
        {
            InitializeComponent();
            
            // Load our image
            tileSet = new Bitmap("images/tiles.png");
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


        // Load the xml file
        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            
        }

        // Select something else from the list
        private void lbTileSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTileSelect.SelectedItem != null)
            {
                // Current selected tile
                selected_index = lbTileSelect.Items.IndexOf(lbTileSelect.SelectedItem as object);

                // Name
                tbName.Text = allTiles.ElementAt(selected_index).name;

                // Type
                if (allTiles.ElementAt(selected_index).attribute == "NON_SOLID")
                    cbType.SelectedIndex = 0;
                else if (allTiles.ElementAt(selected_index).attribute == "SOLID")
                    cbType.SelectedIndex = 1;

                // Height & Width
                nudHeight.Value = allTiles.ElementAt(selected_index).img_h;
                nudWidth.Value = allTiles.ElementAt(selected_index).img_w;

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

        // Change width
        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            allTiles.ElementAt(selected_index).img_w = (int)nudWidth.Value;
            redraw_image();
        }

        // Change height
        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            allTiles.ElementAt(selected_index).img_h = (int)nudHeight.Value;
            redraw_image();
        }

        // Change img coord x
        private void nudImgCoordX_ValueChanged(object sender, EventArgs e)
        {
            allTiles.ElementAt(selected_index).img_x = (int)nudImgCoordX.Value;
            redraw_image();
        }

        // Change img coord y
        private void nudImgCoordY_ValueChanged(object sender, EventArgs e)
        {
            allTiles.ElementAt(selected_index).img_y = (int)nudImgCoordY.Value;
            redraw_image();
        }

        // Redraw our image when needed
        private void redraw_image()
        {
            // Draw first tile
            RectangleF destinationRect = new RectangleF(
                pbImage.Location.X, pbImage.Location.Y,
                pbImage.Size.Width, pbImage.Size.Height);

            RectangleF sourceRect = new RectangleF(
                16 * allTiles.ElementAt(selected_index).img_x, 16 * allTiles.ElementAt(selected_index).img_y,
                16 * allTiles.ElementAt(selected_index).img_w, 16 * allTiles.ElementAt(selected_index).img_h);

            // Create a graphic class
            Graphics x = this.CreateGraphics();

            // Nearest neighbour
            x.InterpolationMode = InterpolationMode.NearestNeighbor;

            // Draw the current image
            x.DrawImage(tileSet, destinationRect, sourceRect, GraphicsUnit.Pixel);
        }

        // Change name
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            // Change name
            allTiles.ElementAt(selected_index).name = tbName.Text;

            // Change in list
            lbTileSelect.Items[selected_index] = tbName.Text;
        }

        // Change type
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Type
            allTiles.ElementAt(selected_index).attribute = cbType.Text;
        }

        // Add tile
        private void btnAdd_Click(object sender, EventArgs e)
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

            // Make new item for list box
            lbTileSelect.Items.Add(newTile.name);

            // Add to list
            allTiles.Add(newTile);
        }

        // Remove tile
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Remove item for list box
            lbTileSelect.Items.RemoveAt(selected_index);

            // Remove from the list
            allTiles.RemoveAt(selected_index);

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
            allTiles.ElementAt(selected_index).id = (int)nudID.Value;

            // Check if unique
            if (!check_unique_id((int)nudID.Value, selected_index))
                nudID.BackColor = Color.Red;
            else
                nudID.BackColor = Color.White;
        }

        // Load a tileset from xml
        private void loadXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open dialog box
            string fileToOpen = "null";

            DialogResult result = ofdOpenFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
                fileToOpen = ofdOpenFile.FileName;

            // No red nudID
            nudID.BackColor = Color.White;

            // Our container for the xml document
            // Load from a static location (for now)
            XDocument xdoc = XDocument.Load(fileToOpen);

            // Number of tiles
            int count = xdoc.Descendants("tile").Count();

            // Make the array if it doesnt exist
            if (allTiles == null)
            {
                allTiles = new List<tile>();
            }
            // Clear the items from list box
            else
            {
                lbTileSelect.Items.Clear();
            }

            // Load data into all tiles
            int counter = 0;
            foreach (XElement item in xdoc.Descendants("tile"))
            {
                // New tile
                tile newTile = new tile();

                // Set vals
                newTile.name = item.Element("name").Value.ToString();
                newTile.attribute = item.Element("attrubite").Value.ToString();

                newTile.img_x = Int32.Parse(item.Element("images").Element("image_x").Value.ToString());
                newTile.img_y = Int32.Parse(item.Element("images").Element("image_y").Value.ToString());
                newTile.img_w = Int32.Parse(item.Element("images").Element("image_w").Value.ToString());
                newTile.img_h = Int32.Parse(item.Element("images").Element("image_h").Value.ToString());
                newTile.id = Int32.Parse(item.Attribute("id").Value);

                // Make new item for list box
                lbTileSelect.Items.Add(newTile.name);

                // Add to list
                allTiles.Add(newTile);

                // Inc counter
                counter++;
            }
        }


        // Message box to show about
        private void aboutJimTileLoaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Jim Tile Loader for Jim Farm \n Created by Allan Legemaate 2016");
        }
    }
}