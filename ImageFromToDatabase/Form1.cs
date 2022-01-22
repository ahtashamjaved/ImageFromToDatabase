using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;

using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;



namespace ImageFromToDatabase
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        //Creat a MS Access Connection
        OleDbConnection con;

        private void dataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormThankYou formThankYou = new FormThankYou();
            formThankYou.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................Source Database...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

        private void selectDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide All Panels
            panelRollNumber.Hide();
            panelTable.Hide();
            comboBoxTable.SelectedIndex = -1;

            try
            {
                openFileDialog1.ShowDialog();
                StaticClass.sourceDataBaseFileName = openFileDialog1.FileName;
                StaticClass.dataSourceSource = openFileDialog1.FileName;
                StaticClass.connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + StaticClass.dataSourceSource + "; Jet OLEDB:Database Password=" + StaticClass.databasePassword + ";";
                LoadTables();

                panelTable.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               

        }
        private void LoadTables()
        {
            try
            {


                con = new OleDbConnection(StaticClass.connectionStr);



                con.Open();
                DataTable tables = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                comboBoxTable.Items.Clear();

                foreach (DataRow row in tables.Rows)
                {
                    comboBoxTable.Items.Add(row[2].ToString());
                   
                }

                //textBoxMessage.Text = Environment.NewLine + "Total Tables in current database are : " + totalTables.ToString();



                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................Select Source...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

        private void selectSource()
        {
            folderBrowserDialog1.Description = "Please Select Source Folder to get Images";
            folderBrowserDialog1.ShowDialog();
            StaticClass.sourceImageFolder = folderBrowserDialog1.SelectedPath;
            if (Directory.GetFiles(StaticClass.sourceImageFolder).Length > 1)
            {

            }
        }

        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................Select Destination...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

        private void selectDestination()
        {
            folderBrowserDialog1.Description = "Please Select Destination Folder to save Images";
            folderBrowserDialog1.ShowDialog();
            StaticClass.destinationImageFolder = folderBrowserDialog1.SelectedPath;
        }

        private void selectDestinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectDestination();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                
               if (radioButtonSingle.Checked)
                {
                    checkBoxGrayScale.Checked = false;
                    List<SanadDataClass> list = new List<SanadDataClass>(new SanadController().GetDataOledb(" Roll_Number = " + textBoxFrom.Text));
                    pictureBox1.Image = StaticClass.imageActual = (Bitmap)list[0].PictureImage;
                    textBoxHeight.Text = pictureBox1.Image.Size.Height.ToString();
                    textBoxWidth.Text = pictureBox1.Image.Size.Width.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonRange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRange.Checked)
            {
                labelFrom.Text = "From";
                labelTo.Visible = true;
                textBoxTo.Visible = true;
                buttonShow.Hide();
                //textBoxFrom.Text = SanadConnection.MinimunRollNumber.ToString();
                //textBoxTo.Text = SanadConnection.MaximumRollNumber.ToString();
                //buttonShow.Text = "Show Sanads";
            }
        }

        private void radioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSingle.Checked)
            {
                labelFrom.Text = "Roll No.";
                labelTo.Visible = false;
                textBoxTo.Visible = false;
                buttonShow.Show();
               // buttonShow.Text = "Show Sanad";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelRollNumber.Hide();
            panelTable.Hide();
            buttonShow.Hide();
            comboBoxExtension.SelectedIndex = 0;
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedIndex > -1)
            {
                StaticClass.tableName = comboBoxTable.SelectedItem.ToString();
                panelRollNumber.Show();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // If images are to get from folder and folder is selected
                if (radioButtonImageFromFolder.Checked)
                {
                    if (StaticClass.sourceImageFolder.Length < 1)
                    {
                        MessageBox.Show("Please Select Source Folder for images, from " + Environment.NewLine + "Image -> Select Source Folder");
                        return;
                    }
                }
                // If Image(s) are to be stored in Database
                if (checkBoxSavetoDatabase.Checked)
                {
                    if (StaticClass.destinationDataBaseFileName.Length < 3)
                    {
                        MessageBox.Show("Please Select Destination Database and their relevant table");

                        selectDestinationDatabaseToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {

                        List<SanadDataClass> list = new List<SanadDataClass>();
                        list.Clear();

                        // Check whether range is selected
                        if (radioButtonRange.Checked)
                        {
                            list = new List<SanadDataClass>(new SanadController().GetDataOledb(" Roll_Number between " + textBoxFrom.Text + " and " + textBoxTo.Text));

                        }
                        else if (radioButtonSingle.Checked)
                        {
                            list = new List<SanadDataClass>(new SanadController().GetDataOledb(" Roll_Number = " + textBoxFrom.Text));
                        }

                        OleDbConnection conn = new OleDbConnection(StaticClass.connectionStr);

                        // imageCounter
                        int imageCounter = 0;
                        foreach (SanadDataClass listItem in list)
                        {
                            try
                            {
                                //System.Drawing.Image picture = listItem.PictureImage;

                                if (conn.State.ToString() != "Open")
                                    conn.Open();
                                StaticClass.updateQuery = "UPDATE " + StaticClass.tableName + " SET Picture_File = @photo  Where Roll_Number = " + listItem.Roll_Number;

                                //OleDbCommand command = new OleDbCommand(StaticClass.updateQuery, conn);

                                OleDbCommand command = new OleDbCommand(StaticClass.updateQuery, conn); 

                                string fileName = StaticClass.sourceImageFolder + "\\" + listItem.Roll_Number.ToString() + StaticClass.imageExtension;
                                if (File.Exists(fileName))
                                {
                                    listItem.Picture_File = File.ReadAllBytes(fileName);

                                    pictureBox1.Image = System.Drawing.Image.FromFile(fileName);
                                    //using MemoryStream:
                                    MemoryStream ms = new MemoryStream();
                                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                                    byte[] photo_aray = new byte[ms.Length];
                                    ms.Position = 0;
                                    ms.Read(photo_aray, 0, photo_aray.Length);
                                    command.Parameters.AddWithValue("@photo", photo_aray);


                                    command.ExecuteNonQuery();
                                    imageCounter++;
                                   
                                }
                                
                                    
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        MessageBox.Show("Total " + imageCounter + " of " + list.Count + " have been saved sucessfully");
                    } // End else of selection Database
                }
                //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
                //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................else if Images are to be stored as image files..................................
                //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

                else
                {
                    // Select Destination
                    selectDestination();

                    List<SanadDataClass> list = new List<SanadDataClass>();
                    list.Clear();

                    // Check whether range is selected
                    if (radioButtonRange.Checked)
                    {
                        list = new List<SanadDataClass>(new SanadController().GetDataOledb(" Roll_Number between " + textBoxFrom.Text + " and " + textBoxTo.Text));

                    }
                    else if (radioButtonSingle.Checked)
                    {
                        list = new List<SanadDataClass>(new SanadController().GetDataOledb(" Roll_Number = " + textBoxFrom.Text));
                    }
                    int imageCounter = 0;
                    foreach (SanadDataClass listItem in list)
                    {
                        System.Drawing.Image picture = listItem.PictureImage;

                        string fileName = StaticClass.destinationImageFolder + "\\" + listItem.Roll_Number.ToString() + StaticClass.imageExtension;

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
                        image.Save(fileName, StaticClass.getImageFormat(comboBoxExtension.SelectedItem.ToString()));
                        imageCounter++;
                    }
                    MessageBox.Show("Total " + imageCounter + " of " + list.Count + " have been saved sucessfully");

                }
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

        private void checkBoxGrayScale_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (checkBoxGrayScale.Checked)
                    pictureBox1.Image = StaticClass.GrayScale((Bitmap)pictureBox1.Image);
                else
                    pictureBox1.Image = StaticClass.imageActual;
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThankYou formThankYou = new FormThankYou();
            formThankYou.ShowDialog();
        }

        private void singleFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................Destination Database...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

        private void selectDestinationDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide All Panels
            panelRollNumber.Hide();
            panelTable.Hide();
            comboBoxTable.SelectedIndex = -1;


            try
            {
                openFileDialog1.ShowDialog();
                StaticClass.destinationDataBaseFileName = openFileDialog1.FileName;
                StaticClass.dataSourceDestination = openFileDialog1.FileName;
                StaticClass.connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + StaticClass.dataSourceDestination + "; Jet OLEDB:Database Password=" + StaticClass.databasePassword + ";";
                LoadTables();
                panelTable.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectSourceFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectSource();
        }

        private void selectSourceFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonImageFromFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonImageFromFolder.Checked)
                StaticClass.imageSoruceLocation = 1;
            else
                StaticClass.imageSoruceLocation = 2;
        }

      

        
    }
}
