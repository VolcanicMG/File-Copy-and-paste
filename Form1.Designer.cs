﻿
namespace FolderAutoUploader
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uploadButton = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.uploadLocationString = new System.Windows.Forms.TextBox();
            this.replaceLocationString = new System.Windows.Forms.TextBox();
            this.UploadLocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datePickerButton = new System.Windows.Forms.Button();
            this.loggerInfo = new System.Windows.Forms.RichTextBox();
            this.dateTextBox = new System.Windows.Forms.RichTextBox();
            this.dateAndTimesText = new System.Windows.Forms.Label();
            this.pickDateText = new System.Windows.Forms.Label();
            this.searchButton1 = new System.Windows.Forms.Button();
            this.searchButton2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.overwriteCheckbox = new System.Windows.Forms.CheckBox();
            this.loggerClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.fileInfoLabel = new System.Windows.Forms.Label();
            this.folderInfoLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.dailyCheckBox = new System.Windows.Forms.CheckBox();
            this.clearDatesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxLocations = new System.Windows.Forms.CheckedListBox();
            this.CopySelectedButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.runningLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(230, 151);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(101, 59);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Copy";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Upload
            // 
            this.Upload.AutoSize = true;
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.Location = new System.Drawing.Point(17, 21);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(208, 39);
            this.Upload.TabIndex = 1;
            this.Upload.Text = "Copy Dates";
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 69);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // uploadLocationString
            // 
            this.uploadLocationString.Location = new System.Drawing.Point(127, 99);
            this.uploadLocationString.Name = "uploadLocationString";
            this.uploadLocationString.Size = new System.Drawing.Size(224, 20);
            this.uploadLocationString.TabIndex = 4;
            // 
            // replaceLocationString
            // 
            this.replaceLocationString.Location = new System.Drawing.Point(127, 125);
            this.replaceLocationString.Name = "replaceLocationString";
            this.replaceLocationString.Size = new System.Drawing.Size(224, 20);
            this.replaceLocationString.TabIndex = 5;
            // 
            // UploadLocation
            // 
            this.UploadLocation.AutoSize = true;
            this.UploadLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadLocation.Location = new System.Drawing.Point(72, 42);
            this.UploadLocation.Name = "UploadLocation";
            this.UploadLocation.Size = new System.Drawing.Size(375, 39);
            this.UploadLocation.TabIndex = 6;
            this.UploadLocation.Text = "Copy/Paste Locations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Copy To/Replace";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 268);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // datePickerButton
            // 
            this.datePickerButton.Location = new System.Drawing.Point(120, 293);
            this.datePickerButton.Name = "datePickerButton";
            this.datePickerButton.Size = new System.Drawing.Size(75, 23);
            this.datePickerButton.TabIndex = 10;
            this.datePickerButton.Text = "Pick Date";
            this.datePickerButton.UseVisualStyleBackColor = true;
            this.datePickerButton.Click += new System.EventHandler(this.DatePicker_Click);
            // 
            // loggerInfo
            // 
            this.loggerInfo.AutoWordSelection = true;
            this.loggerInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.loggerInfo.Location = new System.Drawing.Point(50, 98);
            this.loggerInfo.Name = "loggerInfo";
            this.loggerInfo.ReadOnly = true;
            this.loggerInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.loggerInfo.Size = new System.Drawing.Size(395, 138);
            this.loggerInfo.TabIndex = 11;
            this.loggerInfo.Text = "";
            this.loggerInfo.TextChanged += new System.EventHandler(this.loggerInfo_TextChanged);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTextBox.Location = new System.Drawing.Point(251, 75);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(226, 156);
            this.dateTextBox.TabIndex = 12;
            this.dateTextBox.Text = "";
            this.dateTextBox.TextChanged += new System.EventHandler(this.dateTextBox_TextChanged);
            // 
            // dateAndTimesText
            // 
            this.dateAndTimesText.AutoSize = true;
            this.dateAndTimesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAndTimesText.Location = new System.Drawing.Point(295, 48);
            this.dateAndTimesText.Name = "dateAndTimesText";
            this.dateAndTimesText.Size = new System.Drawing.Size(131, 24);
            this.dateAndTimesText.TabIndex = 13;
            this.dateAndTimesText.Text = "Dates Picked";
            // 
            // pickDateText
            // 
            this.pickDateText.AutoSize = true;
            this.pickDateText.Location = new System.Drawing.Point(88, 252);
            this.pickDateText.Name = "pickDateText";
            this.pickDateText.Size = new System.Drawing.Size(54, 13);
            this.pickDateText.TabIndex = 14;
            this.pickDateText.Text = "Pick Date";
            // 
            // searchButton1
            // 
            this.searchButton1.Location = new System.Drawing.Point(357, 99);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.Size = new System.Drawing.Size(101, 20);
            this.searchButton1.TabIndex = 15;
            this.searchButton1.Text = "Find";
            this.searchButton1.UseVisualStyleBackColor = true;
            this.searchButton1.Click += new System.EventHandler(this.searchButton1_Click);
            // 
            // searchButton2
            // 
            this.searchButton2.Location = new System.Drawing.Point(357, 124);
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.Size = new System.Drawing.Size(101, 21);
            this.searchButton2.TabIndex = 16;
            this.searchButton2.Text = "Find";
            this.searchButton2.UseVisualStyleBackColor = true;
            this.searchButton2.Click += new System.EventHandler(this.searchButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Copy Location";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // overwriteCheckbox
            // 
            this.overwriteCheckbox.AutoSize = true;
            this.overwriteCheckbox.Location = new System.Drawing.Point(337, 165);
            this.overwriteCheckbox.Name = "overwriteCheckbox";
            this.overwriteCheckbox.Size = new System.Drawing.Size(90, 17);
            this.overwriteCheckbox.TabIndex = 17;
            this.overwriteCheckbox.Text = "Overwrite File";
            this.overwriteCheckbox.UseVisualStyleBackColor = true;
            this.overwriteCheckbox.CheckedChanged += new System.EventHandler(this.overwriteCheckbox_CheckedChanged);
            // 
            // loggerClearButton
            // 
            this.loggerClearButton.Location = new System.Drawing.Point(209, 242);
            this.loggerClearButton.Name = "loggerClearButton";
            this.loggerClearButton.Size = new System.Drawing.Size(82, 23);
            this.loggerClearButton.TabIndex = 18;
            this.loggerClearButton.Text = "Clear Log";
            this.loggerClearButton.UseVisualStyleBackColor = true;
            this.loggerClearButton.Click += new System.EventHandler(this.loggerClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(148, 151);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(76, 26);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(148, 184);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(76, 26);
            this.LoadButton.TabIndex = 20;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // fileInfoLabel
            // 
            this.fileInfoLabel.AutoSize = true;
            this.fileInfoLabel.Location = new System.Drawing.Point(46, 8);
            this.fileInfoLabel.Name = "fileInfoLabel";
            this.fileInfoLabel.Size = new System.Drawing.Size(29, 13);
            this.fileInfoLabel.TabIndex = 21;
            this.fileInfoLabel.Text = "File: ";
            // 
            // folderInfoLabel
            // 
            this.folderInfoLabel.AutoSize = true;
            this.folderInfoLabel.Location = new System.Drawing.Point(46, 24);
            this.folderInfoLabel.Name = "folderInfoLabel";
            this.folderInfoLabel.Size = new System.Drawing.Size(42, 13);
            this.folderInfoLabel.TabIndex = 22;
            this.folderInfoLabel.Text = "Folder: ";
            this.folderInfoLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(148, 217);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(183, 44);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.canclelButton_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(50, 69);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(395, 23);
            this.progressBar2.TabIndex = 24;
            // 
            // dailyCheckBox
            // 
            this.dailyCheckBox.AutoSize = true;
            this.dailyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyCheckBox.Location = new System.Drawing.Point(60, 297);
            this.dailyCheckBox.Name = "dailyCheckBox";
            this.dailyCheckBox.Size = new System.Drawing.Size(54, 17);
            this.dailyCheckBox.TabIndex = 25;
            this.dailyCheckBox.Text = "Daily";
            this.dailyCheckBox.UseVisualStyleBackColor = true;
            this.dailyCheckBox.CheckedChanged += new System.EventHandler(this.dailyCheckBox_CheckedChanged);
            // 
            // clearDatesButton
            // 
            this.clearDatesButton.Location = new System.Drawing.Point(320, 239);
            this.clearDatesButton.Name = "clearDatesButton";
            this.clearDatesButton.Size = new System.Drawing.Size(75, 23);
            this.clearDatesButton.TabIndex = 26;
            this.clearDatesButton.Text = "Clear Dates";
            this.clearDatesButton.UseVisualStyleBackColor = true;
            this.clearDatesButton.Click += new System.EventHandler(this.clearDatesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.UploadLocation);
            this.groupBox1.Controls.Add(this.uploadButton);
            this.groupBox1.Controls.Add(this.uploadLocationString);
            this.groupBox1.Controls.Add(this.replaceLocationString);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.searchButton1);
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Controls.Add(this.searchButton2);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.overwriteCheckbox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 346);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Backup Folders Limit";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(71, 178);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 381);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dates";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.Upload);
            this.groupBox2.Controls.Add(this.clearDatesButton);
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Controls.Add(this.dailyCheckBox);
            this.groupBox2.Controls.Add(this.datePickerButton);
            this.groupBox2.Controls.Add(this.pickDateText);
            this.groupBox2.Controls.Add(this.dateTextBox);
            this.groupBox2.Controls.Add(this.dateAndTimesText);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 349);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Copy/Paste";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.runningLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(523, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.checkedListBoxLocations);
            this.groupBox3.Controls.Add(this.CopySelectedButton);
            this.groupBox3.Controls.Add(this.AddButton);
            this.groupBox3.Controls.Add(this.RemoveButton);
            this.groupBox3.Location = new System.Drawing.Point(3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 355);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saves on exit";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // checkedListBoxLocations
            // 
            this.checkedListBoxLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxLocations.FormattingEnabled = true;
            this.checkedListBoxLocations.Location = new System.Drawing.Point(24, 72);
            this.checkedListBoxLocations.Name = "checkedListBoxLocations";
            this.checkedListBoxLocations.Size = new System.Drawing.Size(464, 214);
            this.checkedListBoxLocations.TabIndex = 4;
            this.checkedListBoxLocations.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxLocations_SelectedIndexChanged);
            // 
            // CopySelectedButton
            // 
            this.CopySelectedButton.Location = new System.Drawing.Point(129, 298);
            this.CopySelectedButton.Name = "CopySelectedButton";
            this.CopySelectedButton.Size = new System.Drawing.Size(236, 39);
            this.CopySelectedButton.TabIndex = 0;
            this.CopySelectedButton.Text = "Copy Selected";
            this.CopySelectedButton.UseVisualStyleBackColor = true;
            this.CopySelectedButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(175, 14);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(59, 52);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(240, 14);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(88, 52);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // runningLabel
            // 
            this.runningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.runningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningLabel.Location = new System.Drawing.Point(358, -151);
            this.runningLabel.Name = "runningLabel";
            this.runningLabel.Size = new System.Drawing.Size(159, 23);
            this.runningLabel.TabIndex = 29;
            this.runningLabel.Text = " ";
            this.runningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Process Started";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.loggerInfo);
            this.groupBox4.Controls.Add(this.folderInfoLabel);
            this.groupBox4.Controls.Add(this.fileInfoLabel);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.progressBar2);
            this.groupBox4.Controls.Add(this.loggerClearButton);
            this.groupBox4.Location = new System.Drawing.Point(19, 399);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 275);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 682);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Copy/Paste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label Upload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox uploadLocationString;
        private System.Windows.Forms.TextBox replaceLocationString;
        private System.Windows.Forms.Label UploadLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button datePickerButton;
        private System.Windows.Forms.RichTextBox loggerInfo;
        private System.Windows.Forms.RichTextBox dateTextBox;
        private System.Windows.Forms.Label dateAndTimesText;
        private System.Windows.Forms.Label pickDateText;
        private System.Windows.Forms.Button searchButton1;
        private System.Windows.Forms.Button searchButton2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox overwriteCheckbox;
        private System.Windows.Forms.Button loggerClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label fileInfoLabel;
        private System.Windows.Forms.Label folderInfoLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.CheckBox dailyCheckBox;
        private System.Windows.Forms.Button clearDatesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label runningLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button CopySelectedButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.CheckedListBox checkedListBoxLocations;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
    }
}

