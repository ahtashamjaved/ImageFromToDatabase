namespace ImageFromToDatabase
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSourceFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDestinationDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSourceFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.radioButtonRange = new System.Windows.Forms.RadioButton();
            this.panelRange = new System.Windows.Forms.Panel();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.panelRollNumber = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonImageFromFolder = new System.Windows.Forms.RadioButton();
            this.radioButtonImageFromDatabase = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxSavetoDatabase = new System.Windows.Forms.CheckBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxGrayScale = new System.Windows.Forms.CheckBox();
            this.comboBoxExtension = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelTable = new System.Windows.Forms.Panel();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRange.SuspendLayout();
            this.panelRollNumber.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataBaseToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleFileToolStripMenuItem,
            this.selectSourceFolderToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // singleFileToolStripMenuItem
            // 
            this.singleFileToolStripMenuItem.Name = "singleFileToolStripMenuItem";
            this.singleFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.singleFileToolStripMenuItem.Text = "Single File";
            this.singleFileToolStripMenuItem.Click += new System.EventHandler(this.singleFileToolStripMenuItem_Click);
            // 
            // selectSourceFolderToolStripMenuItem
            // 
            this.selectSourceFolderToolStripMenuItem.Name = "selectSourceFolderToolStripMenuItem";
            this.selectSourceFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectSourceFolderToolStripMenuItem.Text = "Select Source Folder";
            this.selectSourceFolderToolStripMenuItem.Click += new System.EventHandler(this.selectSourceFolderToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDataBaseToolStripMenuItem,
            this.selectDestinationDatabaseToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dataBaseToolStripMenuItem.Text = "Database";
            this.dataBaseToolStripMenuItem.Click += new System.EventHandler(this.dataBaseToolStripMenuItem_Click);
            // 
            // selectDataBaseToolStripMenuItem
            // 
            this.selectDataBaseToolStripMenuItem.Name = "selectDataBaseToolStripMenuItem";
            this.selectDataBaseToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.selectDataBaseToolStripMenuItem.Text = "Select Source Database";
            this.selectDataBaseToolStripMenuItem.Click += new System.EventHandler(this.selectDataBaseToolStripMenuItem_Click);
            // 
            // selectDestinationDatabaseToolStripMenuItem
            // 
            this.selectDestinationDatabaseToolStripMenuItem.Name = "selectDestinationDatabaseToolStripMenuItem";
            this.selectDestinationDatabaseToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.selectDestinationDatabaseToolStripMenuItem.Text = "Select Destination Database";
            this.selectDestinationDatabaseToolStripMenuItem.Click += new System.EventHandler(this.selectDestinationDatabaseToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSourceFolderToolStripMenuItem1,
            this.selectDestinationToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // selectSourceFolderToolStripMenuItem1
            // 
            this.selectSourceFolderToolStripMenuItem1.Name = "selectSourceFolderToolStripMenuItem1";
            this.selectSourceFolderToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.selectSourceFolderToolStripMenuItem1.Text = "Select Source Folder";
            this.selectSourceFolderToolStripMenuItem1.Click += new System.EventHandler(this.selectSourceFolderToolStripMenuItem1_Click);
            // 
            // selectDestinationToolStripMenuItem
            // 
            this.selectDestinationToolStripMenuItem.Name = "selectDestinationToolStripMenuItem";
            this.selectDestinationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.selectDestinationToolStripMenuItem.Text = "Select Destination Folder";
            this.selectDestinationToolStripMenuItem.Click += new System.EventHandler(this.selectDestinationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(95, 155);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonSingle);
            this.panel1.Controls.Add(this.radioButtonRange);
            this.panel1.Location = new System.Drawing.Point(17, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 65);
            this.panel1.TabIndex = 10;
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(9, 36);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSingle.TabIndex = 1;
            this.radioButtonSingle.Text = "Single";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            this.radioButtonSingle.CheckedChanged += new System.EventHandler(this.radioButtonSingle_CheckedChanged);
            // 
            // radioButtonRange
            // 
            this.radioButtonRange.AutoSize = true;
            this.radioButtonRange.Checked = true;
            this.radioButtonRange.Location = new System.Drawing.Point(9, 10);
            this.radioButtonRange.Name = "radioButtonRange";
            this.radioButtonRange.Size = new System.Drawing.Size(57, 17);
            this.radioButtonRange.TabIndex = 0;
            this.radioButtonRange.TabStop = true;
            this.radioButtonRange.Text = "Range";
            this.radioButtonRange.UseVisualStyleBackColor = true;
            this.radioButtonRange.CheckedChanged += new System.EventHandler(this.radioButtonRange_CheckedChanged);
            // 
            // panelRange
            // 
            this.panelRange.Controls.Add(this.textBoxFrom);
            this.panelRange.Controls.Add(this.textBoxTo);
            this.panelRange.Controls.Add(this.labelFrom);
            this.panelRange.Controls.Add(this.labelTo);
            this.panelRange.Location = new System.Drawing.Point(121, 3);
            this.panelRange.Name = "panelRange";
            this.panelRange.Size = new System.Drawing.Size(163, 65);
            this.panelRange.TabIndex = 9;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(49, 9);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(111, 20);
            this.textBoxFrom.TabIndex = 4;
            this.textBoxFrom.Text = "0";
            this.textBoxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(50, 36);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(111, 20);
            this.textBoxTo.TabIndex = 6;
            this.textBoxTo.Text = "0";
            this.textBoxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(2, 10);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(30, 13);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(2, 38);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "To";
            // 
            // panelRollNumber
            // 
            this.panelRollNumber.Controls.Add(this.panel2);
            this.panelRollNumber.Controls.Add(this.label5);
            this.panelRollNumber.Controls.Add(this.checkBoxSavetoDatabase);
            this.panelRollNumber.Controls.Add(this.textBoxWidth);
            this.panelRollNumber.Controls.Add(this.textBoxHeight);
            this.panelRollNumber.Controls.Add(this.label4);
            this.panelRollNumber.Controls.Add(this.label3);
            this.panelRollNumber.Controls.Add(this.checkBoxGrayScale);
            this.panelRollNumber.Controls.Add(this.comboBoxExtension);
            this.panelRollNumber.Controls.Add(this.pictureBox1);
            this.panelRollNumber.Controls.Add(this.label2);
            this.panelRollNumber.Controls.Add(this.buttonSave);
            this.panelRollNumber.Controls.Add(this.panel1);
            this.panelRollNumber.Controls.Add(this.buttonShow);
            this.panelRollNumber.Controls.Add(this.panelRange);
            this.panelRollNumber.Location = new System.Drawing.Point(12, 71);
            this.panelRollNumber.Name = "panelRollNumber";
            this.panelRollNumber.Size = new System.Drawing.Size(465, 214);
            this.panelRollNumber.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonImageFromFolder);
            this.panel2.Controls.Add(this.radioButtonImageFromDatabase);
            this.panel2.Location = new System.Drawing.Point(96, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 31);
            this.panel2.TabIndex = 11;
            // 
            // radioButtonImageFromFolder
            // 
            this.radioButtonImageFromFolder.AutoSize = true;
            this.radioButtonImageFromFolder.Checked = true;
            this.radioButtonImageFromFolder.Location = new System.Drawing.Point(98, 6);
            this.radioButtonImageFromFolder.Name = "radioButtonImageFromFolder";
            this.radioButtonImageFromFolder.Size = new System.Drawing.Size(54, 17);
            this.radioButtonImageFromFolder.TabIndex = 3;
            this.radioButtonImageFromFolder.TabStop = true;
            this.radioButtonImageFromFolder.Text = "Folder";
            this.radioButtonImageFromFolder.UseVisualStyleBackColor = true;
            this.radioButtonImageFromFolder.CheckedChanged += new System.EventHandler(this.radioButtonImageFromFolder_CheckedChanged);
            // 
            // radioButtonImageFromDatabase
            // 
            this.radioButtonImageFromDatabase.AutoSize = true;
            this.radioButtonImageFromDatabase.Location = new System.Drawing.Point(8, 6);
            this.radioButtonImageFromDatabase.Name = "radioButtonImageFromDatabase";
            this.radioButtonImageFromDatabase.Size = new System.Drawing.Size(72, 17);
            this.radioButtonImageFromDatabase.TabIndex = 2;
            this.radioButtonImageFromDatabase.Text = "DataBase";
            this.radioButtonImageFromDatabase.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Images From";
            // 
            // checkBoxSavetoDatabase
            // 
            this.checkBoxSavetoDatabase.AutoSize = true;
            this.checkBoxSavetoDatabase.Location = new System.Drawing.Point(178, 186);
            this.checkBoxSavetoDatabase.Name = "checkBoxSavetoDatabase";
            this.checkBoxSavetoDatabase.Size = new System.Drawing.Size(112, 17);
            this.checkBoxSavetoDatabase.TabIndex = 18;
            this.checkBoxSavetoDatabase.Text = "Save to Database";
            this.checkBoxSavetoDatabase.UseVisualStyleBackColor = true;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(191, 100);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(57, 20);
            this.textBoxWidth.TabIndex = 17;
            this.textBoxWidth.Text = "200";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(93, 100);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(57, 20);
            this.textBoxHeight.TabIndex = 7;
            this.textBoxHeight.Text = "230";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Height";
            // 
            // checkBoxGrayScale
            // 
            this.checkBoxGrayScale.AutoSize = true;
            this.checkBoxGrayScale.Location = new System.Drawing.Point(178, 80);
            this.checkBoxGrayScale.Name = "checkBoxGrayScale";
            this.checkBoxGrayScale.Size = new System.Drawing.Size(78, 17);
            this.checkBoxGrayScale.TabIndex = 14;
            this.checkBoxGrayScale.Text = "Grey Scale";
            this.checkBoxGrayScale.UseVisualStyleBackColor = true;
            this.checkBoxGrayScale.CheckedChanged += new System.EventHandler(this.checkBoxGrayScale_CheckedChanged);
            // 
            // comboBoxExtension
            // 
            this.comboBoxExtension.FormattingEnabled = true;
            this.comboBoxExtension.Items.AddRange(new object[] {
            ".tif",
            ".jpg",
            ".png",
            ".bmp",
            ".gif"});
            this.comboBoxExtension.Location = new System.Drawing.Point(93, 76);
            this.comboBoxExtension.Name = "comboBoxExtension";
            this.comboBoxExtension.Size = new System.Drawing.Size(57, 21);
            this.comboBoxExtension.TabIndex = 3;
            this.comboBoxExtension.SelectedIndexChanged += new System.EventHandler(this.comboBoxExtension_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(293, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Extension";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(176, 155);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.comboBoxTable);
            this.panelTable.Controls.Add(this.label1);
            this.panelTable.Location = new System.Drawing.Point(11, 29);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(465, 38);
            this.panelTable.TabIndex = 12;
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(122, 13);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(163, 21);
            this.comboBoxTable.TabIndex = 1;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Table";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 300);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelRollNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRange.ResumeLayout(false);
            this.panelRange.PerformLayout();
            this.panelRollNumber.ResumeLayout(false);
            this.panelRollNumber.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTable.ResumeLayout(false);
            this.panelTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDestinationToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.RadioButton radioButtonRange;
        private System.Windows.Forms.Panel panelRange;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Panel panelRollNumber;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxGrayScale;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSourceFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDestinationDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSourceFolderToolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBoxSavetoDatabase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonImageFromFolder;
        private System.Windows.Forms.RadioButton radioButtonImageFromDatabase;
        private System.Windows.Forms.Label label5;
    }
}

