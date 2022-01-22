using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

using AForge;
using AForge.Math;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;

using OnBarcode.Barcode.BarcodeScanner;



namespace ImageFromToDatabase
{
    public partial class FormProcessImage : Form
    {
        public FormProcessImage()
        {
            InitializeComponent();
        }

        private System.Drawing.Bitmap backup = null;
        private System.Drawing.Bitmap image = null;
        private System.Drawing.Bitmap imageLoad = null;
        private System.Drawing.Bitmap imageProcessing = null;
        private string fileName = null;
        private int width;
        private int height;
        private float zoom = 1;

        private bool cropping = false;
        private bool dragging = false;
        private int startX, startY, Endx, Endy;
        private Point start, end, startW, endW;

        // Events
        public delegate void SelectionEventHandler(object sender, SelectionEventArgs e);

        public event EventHandler DocumentChanged;
        public event EventHandler ZoomChanged;
        public event SelectionEventHandler MouseImagePosition;
        public event SelectionEventHandler SelectionChanged;
        

           // Selection arguments
    public class SelectionEventArgs : EventArgs
    {
        private Point location;
        private Size size;

        // Constructors
        public SelectionEventArgs( Point location )
        {
            this.location = location;
        }
        public SelectionEventArgs( Point location, Size size )
        {
            this.location = location;
            this.size = size;
        }

        // Location property
        public Point Location
        {
            get { return location; }
        }
        // Size property
        public Size Size
        {
            get { return size; }
        }
    }

        // Image property
        public Bitmap Image
        {
            get { return image; }
        }
        // Width property
        public int ImageWidth
        {
            get { return width; }
        }
        // Height property
        public int ImageHeight
        {
            get { return height; }
        }
        // Zoom property
        public float Zoom
        {
            get { return zoom; }
        }
        // FileName property
        // return file name if the document was created from file or null
        public string FileName
        {
            get { return fileName; }
        }

      

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThankYou formThankYou = new FormThankYou();
            formThankYou.ShowDialog();
            this.Close();
        }

        private void ProcessImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormThankYou formThankYou = new FormThankYou();
            formThankYou.ShowDialog();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {

        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "TIFF (.tif)|*.tif|BMP (.bmp)|*.bmp|JPEG (.jpg)|*.jpg|PNG (.png)|*.png|GIF (.gif)|*.gif|All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 3;
                openFileDialog1.ShowDialog();

                image = (Bitmap)System.Drawing.Image.FromFile(openFileDialog1.FileName);
                imageLoad = image;
                pictureBoxLoad.Image = imageLoad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Apply filter on the image
        private void ApplyFilter(IFilter filter)
        {
            try
            {
                // set wait cursor
                this.Cursor = Cursors.WaitCursor;

                // apply filter to the image
                Bitmap newImage = filter.Apply(image);
                image = newImage;
                imageProcessing = image;
                pictureBoxProcessing.Image = imageProcessing; 
                
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Selected filter can not be applied to the image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // restore cursor
                this.Cursor = Cursors.Default;
            }
        }
        // Normalize points so, that pt1 becomes top-left point of rectangle
        // and pt2 becomes right-bottom
        private void NormalizePoints(ref Point pt1, ref Point pt2)
        {
            Point t1 = pt1;
            Point t2 = pt2;

            pt1.X = Math.Min(t1.X, t2.X);
            pt1.Y = Math.Min(t1.Y, t2.Y);
            pt2.X = Math.Max(t1.X, t2.X);
            pt2.Y = Math.Max(t1.Y, t2.Y);
        }

        // Draw selection rectangle
        private void DrawSelectionFrame(Graphics g)
        {
            Point sp = startW;
            Point ep = endW;

            // Normalize points
            NormalizePoints(ref sp, ref ep);
            // Draw reversible frame
            ControlPaint.DrawReversibleFrame(new Rectangle(sp.X, sp.Y, ep.X - sp.X + 1, ep.Y - sp.Y + 1), Color.White, FrameStyle.Dashed);
        }

        // Crop the image
        private void Crop()
        {
            if (!cropping)
            {
                // turn on
                cropping = true;
                this.Cursor = Cursors.Cross;

            }
            else
            {
                // turn off
                cropping = false;
                this.Cursor = Cursors.Default;
            }
        }

        // Calculate image and screen coordinates of the point
        private void GetImageAndScreenPoints(Point point, out Point imgPoint, out Point screenPoint)
        {
            Rectangle rc = this.ClientRectangle;
            int width = (int)(this.width * zoom);
            int height = (int)(this.height * zoom);
            int x = (rc.Width < width) ? this.AutoScrollPosition.X : (rc.Width - width) / 2;
            int y = (rc.Height < height) ? this.AutoScrollPosition.Y : (rc.Height - height) / 2;

            int ix = Math.Min(Math.Max(x, point.X), x + width - 1);
            int iy = Math.Min(Math.Max(y, point.Y), y + height - 1);

            ix = (int)((ix - x) / zoom);
            iy = (int)((iy - y) / zoom);

            // image point
            imgPoint = new Point(ix, iy);
            // screen point
            screenPoint = this.PointToScreen(new Point((int)(ix * zoom + x), (int)(iy * zoom + y)));
        }


        // On "Image->Crop" - turn on/off cropping mode
        private void cropImageItem_Click(object sender, System.EventArgs e)
        {
            Crop();
        }

        // On mouse down
        private void ImageDoc_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // turn off cropping mode
                if (!dragging)
                {
                    cropping = false;
                    this.Cursor = Cursors.Default;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (cropping)
                {
                    // start dragging
                    dragging = true;
                    // set mouse capture
                    this.Capture = true;

                    // get selection start point
                    GetImageAndScreenPoints(new Point(e.X, e.Y), out start, out startW);

                    // end point is the same as start
                    end = start;
                    endW = startW;

                    // draw frame
                    Graphics g = this.CreateGraphics();
                    DrawSelectionFrame(g);
                    g.Dispose();
                }
            }
        }

        // On mouse up
        private void ImageDoc_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dragging)
            {
                // stop dragging and cropping
                dragging = cropping = false;
                // release capture
                this.Capture = false;
                // set default mouse pointer
                this.Cursor = Cursors.Default;

                // erase frame
                Graphics g = this.CreateGraphics();
                DrawSelectionFrame(g);
                g.Dispose();

                // normalize start and end points
                NormalizePoints(ref start, ref end);

                // crop tge image
                ApplyFilter(new Crop(new Rectangle(start.X, start.Y, end.X - start.X + 1, end.Y - start.Y + 1)));
            }
        }

        private void pictureBoxProcessing_Click(object sender, EventArgs e)
        {
            image = imageProcessing = (Bitmap)pictureBoxProcessing.Image;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panelRollNumber_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crop();
        }

        private void FormProcessImage_MouseDown(object sender, MouseEventArgs e)
        {
            ImageDoc_MouseDown(sender, e);
        }

        private void FormProcessImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {

                Graphics g = this.CreateGraphics();

                // erase frame
                DrawSelectionFrame(g);

                // get selection end point
                GetImageAndScreenPoints(new Point(e.X, e.Y), out end, out endW);

                // draw frame
                DrawSelectionFrame(g);

                g.Dispose();

                if (SelectionChanged != null)
                {
                    Point sp = start;
                    Point ep = end;

                    // normalize start and end points
                    NormalizePoints(ref sp, ref ep);

                    SelectionChanged(this, new SelectionEventArgs(
                        sp, new Size(ep.X - sp.X + 1, ep.Y - sp.Y + 1)));
                }
            }
            else
            {
                if (MouseImagePosition != null)
                {
                    Rectangle rc = this.ClientRectangle;
                    int width = (int)(this.width * zoom);
                    int height = (int)(this.height * zoom);
                    int x = (rc.Width < width) ? this.AutoScrollPosition.X : (rc.Width - width) / 2;
                    int y = (rc.Height < height) ? this.AutoScrollPosition.Y : (rc.Height - height) / 2;

                    if ((e.X >= x) && (e.Y >= y) &&
                        (e.X < x + width) && (e.Y < y + height))
                    {
                        // mouse is over the image
                        MouseImagePosition(this, new SelectionEventArgs(
                            new Point((int)((e.X - x) / zoom), (int)((e.Y - y) / zoom))));
                    }
                    else
                    {
                        // mouse is outside image region
                        MouseImagePosition(this, new SelectionEventArgs(new Point(-1, -1)));
                    }
                }
            }
        }

        private void FormProcessImage_MouseLeave(object sender, EventArgs e)
        {
            if ((!dragging) && (MouseImagePosition != null))
            {
                MouseImagePosition(this, new SelectionEventArgs(new Point(-1, -1)));
            }
        }

        private void FormProcessImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                // stop dragging and cropping
                dragging = cropping = false;
                // release capture
                this.Capture = false;
                // set default mouse pointer
                this.Cursor = Cursors.Default;

                // erase frame
                Graphics g = this.CreateGraphics();
                DrawSelectionFrame(g);
                g.Dispose();

                // normalize start and end points
                NormalizePoints(ref start, ref end);

                // crop tge image
                ApplyFilter(new Crop(new Rectangle(start.X, start.Y, end.X - start.X + 1, end.Y - start.Y + 1)));
                pictureBoxProcessing.Image = image;
            }
        }

        private void LoadPoints()
        {
            start.X = Convert.ToInt32(textBoxXfrom.Text);
            start.Y = Convert.ToInt32(textBoxYfrom.Text);
            end.X = Convert.ToInt32(textBoxXto.Text);
            end.Y = Convert.ToInt32(textBoxYto.Text);
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            // crop the image
            image = imageLoad;
            LoadPoints();
            ApplyFilter(new Crop(new Rectangle(1, 1, imageLoad.Width, imageLoad.Height)));
            imageLoad = image;
            ApplyFilter(new Crop(new Rectangle(start.X, start.Y, end.X - start.X + 1, end.Y - start.Y + 1)));

            pictureBoxProcessing.Image = image;
        }

        private void buttonBinary_Click(object sender, EventArgs e)
        {
            
            ApplyFilter(new Threshold(byte.Parse(textBoxBinaryThreshold.Text)));
            pictureBoxProcessing.Image = image;
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Erosion());
        }

        private void dilatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Dilatation());
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Opening());
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Closing());
        }

       
        private void pictureBoxLoad_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            labelHeightLoad.Text = pictureBoxLoad.Image.Size.Height.ToString();
            labelWidthLoad.Text = pictureBoxLoad.Image.Size.Width.ToString();
        }

      

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            LoadPoints();
            image = imageLoad;


           image = ConvertTo24(image);
            imageProcessing = ConvertTo24(imageProcessing);
          //  pictureBoxProcessing.Image = image;





            //Get graphics from the picturebox image (where there could be another image)
            Graphics g = Graphics.FromImage(image);
            //Draw the part of image
            g.DrawImage(imageProcessing, start); //newImage is the part of image selected and cut, clickedPointTwo is the point of upper-left corner where you want to begin draw the image
            pictureBoxProcessing.Image = image;
        }


       private static Bitmap ConvertTo24(Bitmap inputFileName)
    {
        Bitmap bmpIn = (inputFileName);

        Bitmap converted = new Bitmap(bmpIn.Width, bmpIn.Height, PixelFormat.Format24bppRgb);
        using (Graphics g = Graphics.FromImage(converted))
        {
            // Prevent DPI conversion
            g.PageUnit = GraphicsUnit.Pixel;
            // Draw the image
            g.DrawImageUnscaled(bmpIn, 0, 0);
        }
        return converted;
       // converted.Save(outputFileName, ImageFormat.Bmp);
    }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "TIFF (.tif)|*.tif|BMP (.bmp)|*.bmp|JPEG (.jpg)|*.jpg|PNG (.png)|*.png|GIF (.gif)|*.gif|All Files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.ShowDialog();




                string fileName = saveFileDialog1.FileName;//+ StaticClass.imageExtension;


                System.Drawing.Image picture = pictureBoxProcessing.Image;
                Bitmap image = (Bitmap)picture;


                // if grayScale is not selected then only apply rezise filter
                if (!checkBoxGrayScale.Checked)
                {
                    image = StaticClass.Resize(image, Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text));

                }

                // else if Gray Scale is selected
                else
                {
                    image = StaticClass.GrayScale(image);
                    image = StaticClass.Resize(image, Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text));

                }

                //using (Bitmap bitmap = (Bitmap)Image.FromFile("file.jpg"))
                //{
                //    using (Bitmap newBitmap = new Bitmap(bitmap))
                //    {
                //        newBitmap.SetResolution(300, 300);
                //        newBitmap.Save("file300.jpg", ImageFormat.Jpeg);
                //    }
                //}
                image.SetResolution(300, 300);
                image.Save(fileName, StaticClass.getImageFormat(comboBoxExtension.SelectedItem.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            StaticClass.imageExtension = comboBoxExtension.SelectedItem.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormProcessImage_Load(object sender, EventArgs e)
        {
            comboBoxExtension.SelectedIndex = 0;
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Mean());
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Blur());
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Sharpen());
        }

        private void edgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Edges());
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Apply Blur for 10 times
            for (int i = 0; i < 10; i++)
            {
                ApplyFilter(new Blur());
            }
            
            // Then dilation for one time which will remove small dots

            ApplyFilter(new Dilatation());

            // Then finally Apply threshold at last

            buttonBinary_Click(sender, e);

        }

      // private string DecodeText(string sFileName)

        //private string DecodeText()
        //{
        //    DmtxImageDecoder decoder = new DmtxImageDecoder();

        //   // System.Drawing.Bitmap oBitmap = new System.Drawing.Bitmap(sFileName);

        //    System.Drawing.Bitmap oBitmap = image;
        //    List<string> oList = decoder.DecodeImage(oBitmap);

        //    StringBuilder sb = new StringBuilder();
        //    sb.Length = 0;
        //    foreach (string s in oList)
        //    {
        //        sb.Append(s);
        //    }
        //    return sb.ToString();
        //}
        private void barcodeReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //string[] barcodes = BarcodeScanner.ScanRegions("code39image.gif", BarcodeType.Code39, areas);
                String[] barcodes = BarcodeScanner.Scan(imageProcessing, BarcodeType.Code128);
                string barcodeList = "";
                //foreach (string barcode in barcodes)
                //{
                //    barcodeList += Environment.NewLine;
                //}
                MessageBox.Show(barcodes[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry No Barcode Found " + Environment.NewLine + ex.Message);
            }

        }

        private void pictureBoxLoad_Click(object sender, EventArgs e)
        {
            image = imageProcessing = (Bitmap)pictureBoxLoad.Image;
        }

        private void pictureBoxProcessing_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBoxProcessing.Image != null)
            {
                labelWidthProcessing.Text = pictureBoxProcessing.Image.Width.ToString();
                labelHeightProcessing.Text = pictureBoxProcessing.Image.Height.ToString();
            }
        }

        private void pictureBoxLoad_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBoxLoad.Image != null)
            {
                labelWidthLoad.Text = pictureBoxLoad.Image.Width.ToString();
                labelHeightLoad.Text = pictureBoxLoad.Image.Height.ToString();
            }
        }

       



    }
}
