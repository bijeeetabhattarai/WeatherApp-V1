namespace P2_Bhattarai_Bijita
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.weatherInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.AverageTempGroupBox = new System.Windows.Forms.GroupBox();
            this.regionAverageLabel = new System.Windows.Forms.Label();
            this.regionPromptLabel = new System.Windows.Forms.Label();
            this.wiPromptLabel = new System.Windows.Forms.Label();
            this.iaPromptLabel = new System.Windows.Forms.Label();
            this.sdPromptLabel = new System.Windows.Forms.Label();
            this.ndPromptLabel = new System.Windows.Forms.Label();
            this.mnPromptLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.removeRecordButton = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.SearchRecordButton = new System.Windows.Forms.Button();
            this.lowestTempButton = new System.Windows.Forms.Button();
            this.highestTempButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.dateListBoxLabel = new System.Windows.Forms.Label();
            this.cityListBoxLabel = new System.Windows.Forms.Label();
            this.stateListboxLabel = new System.Windows.Forms.Label();
            this.tempListBoxlabel = new System.Windows.Forms.Label();
            this.saveEditbutton = new System.Windows.Forms.Button();
            this.weatherpictureBox = new System.Windows.Forms.PictureBox();
            this.mnAverageLabel = new System.Windows.Forms.Label();
            this.ndAverageLabel = new System.Windows.Forms.Label();
            this.sdAverageLabel = new System.Windows.Forms.Label();
            this.iaAverageLabel = new System.Windows.Forms.Label();
            this.wiAverageLabel = new System.Windows.Forms.Label();
            this.weatherInfoGroupBox.SuspendLayout();
            this.AverageTempGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // weatherInfoGroupBox
            // 
            this.weatherInfoGroupBox.Controls.Add(this.clearButton);
            this.weatherInfoGroupBox.Controls.Add(this.addButton);
            this.weatherInfoGroupBox.Controls.Add(this.dateTimePicker);
            this.weatherInfoGroupBox.Controls.Add(this.tempTextBox);
            this.weatherInfoGroupBox.Controls.Add(this.stateComboBox);
            this.weatherInfoGroupBox.Controls.Add(this.cityTextBox);
            this.weatherInfoGroupBox.Controls.Add(this.dateLabel);
            this.weatherInfoGroupBox.Controls.Add(this.TempLabel);
            this.weatherInfoGroupBox.Controls.Add(this.stateLabel);
            this.weatherInfoGroupBox.Controls.Add(this.cityLabel);
            this.weatherInfoGroupBox.Location = new System.Drawing.Point(47, 175);
            this.weatherInfoGroupBox.Name = "weatherInfoGroupBox";
            this.weatherInfoGroupBox.Size = new System.Drawing.Size(328, 243);
            this.weatherInfoGroupBox.TabIndex = 0;
            this.weatherInfoGroupBox.TabStop = false;
            this.weatherInfoGroupBox.Text = "Weather Information";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(189, 188);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(121, 49);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(6, 186);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 51);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add Information";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "     MM-dd-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(164, 139);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 23);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_KeyDown);
            // 
            // tempTextBox
            // 
            this.tempTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempTextBox.Location = new System.Drawing.Point(164, 101);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(121, 23);
            this.tempTextBox.TabIndex = 7;
            this.tempTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tempTextBox_KeyDown);
            this.tempTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempTextBox_KeyPress);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "MN",
            "ND",
            "SD",
            "WI",
            "IA"});
            this.stateComboBox.Location = new System.Drawing.Point(164, 64);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 23);
            this.stateComboBox.TabIndex = 6;
            this.stateComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stateComboBox_KeyDown);
            // 
            // cityTextBox
            // 
            this.cityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityTextBox.Location = new System.Drawing.Point(164, 29);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(121, 23);
            this.cityTextBox.TabIndex = 5;
            this.cityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cityTextBox_KeyDown);
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateLabel.Location = new System.Drawing.Point(32, 139);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(103, 23);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempLabel
            // 
            this.TempLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TempLabel.Location = new System.Drawing.Point(32, 101);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(103, 23);
            this.TempLabel.TabIndex = 2;
            this.TempLabel.Text = "Temp (Fahrenheit)";
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateLabel
            // 
            this.stateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stateLabel.Location = new System.Drawing.Point(32, 64);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(103, 23);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "State";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cityLabel.Location = new System.Drawing.Point(32, 32);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(103, 20);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AverageTempGroupBox
            // 
            this.AverageTempGroupBox.Controls.Add(this.wiAverageLabel);
            this.AverageTempGroupBox.Controls.Add(this.iaAverageLabel);
            this.AverageTempGroupBox.Controls.Add(this.sdAverageLabel);
            this.AverageTempGroupBox.Controls.Add(this.ndAverageLabel);
            this.AverageTempGroupBox.Controls.Add(this.mnAverageLabel);
            this.AverageTempGroupBox.Controls.Add(this.regionAverageLabel);
            this.AverageTempGroupBox.Controls.Add(this.regionPromptLabel);
            this.AverageTempGroupBox.Controls.Add(this.wiPromptLabel);
            this.AverageTempGroupBox.Controls.Add(this.iaPromptLabel);
            this.AverageTempGroupBox.Controls.Add(this.sdPromptLabel);
            this.AverageTempGroupBox.Controls.Add(this.ndPromptLabel);
            this.AverageTempGroupBox.Controls.Add(this.mnPromptLabel);
            this.AverageTempGroupBox.Location = new System.Drawing.Point(409, 71);
            this.AverageTempGroupBox.Name = "AverageTempGroupBox";
            this.AverageTempGroupBox.Size = new System.Drawing.Size(250, 347);
            this.AverageTempGroupBox.TabIndex = 1;
            this.AverageTempGroupBox.TabStop = false;
            this.AverageTempGroupBox.Text = "Average Temperature";
            // 
            // regionAverageLabel
            // 
            this.regionAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regionAverageLabel.Location = new System.Drawing.Point(120, 256);
            this.regionAverageLabel.Name = "regionAverageLabel";
            this.regionAverageLabel.Size = new System.Drawing.Size(100, 23);
            this.regionAverageLabel.TabIndex = 11;
            // 
            // regionPromptLabel
            // 
            this.regionPromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regionPromptLabel.Location = new System.Drawing.Point(25, 251);
            this.regionPromptLabel.Name = "regionPromptLabel";
            this.regionPromptLabel.Size = new System.Drawing.Size(66, 33);
            this.regionPromptLabel.TabIndex = 5;
            this.regionPromptLabel.Text = "Region";
            this.regionPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wiPromptLabel
            // 
            this.wiPromptLabel.AutoSize = true;
            this.wiPromptLabel.Location = new System.Drawing.Point(25, 220);
            this.wiPromptLabel.Name = "wiPromptLabel";
            this.wiPromptLabel.Size = new System.Drawing.Size(21, 15);
            this.wiPromptLabel.TabIndex = 4;
            this.wiPromptLabel.Text = "WI";
            // 
            // iaPromptLabel
            // 
            this.iaPromptLabel.AutoSize = true;
            this.iaPromptLabel.Location = new System.Drawing.Point(25, 185);
            this.iaPromptLabel.Name = "iaPromptLabel";
            this.iaPromptLabel.Size = new System.Drawing.Size(18, 15);
            this.iaPromptLabel.TabIndex = 3;
            this.iaPromptLabel.Text = "IA";
            // 
            // sdPromptLabel
            // 
            this.sdPromptLabel.AutoSize = true;
            this.sdPromptLabel.Location = new System.Drawing.Point(25, 141);
            this.sdPromptLabel.Name = "sdPromptLabel";
            this.sdPromptLabel.Size = new System.Drawing.Size(21, 15);
            this.sdPromptLabel.TabIndex = 2;
            this.sdPromptLabel.Text = "SD";
            // 
            // ndPromptLabel
            // 
            this.ndPromptLabel.AutoSize = true;
            this.ndPromptLabel.Location = new System.Drawing.Point(25, 103);
            this.ndPromptLabel.Name = "ndPromptLabel";
            this.ndPromptLabel.Size = new System.Drawing.Size(24, 15);
            this.ndPromptLabel.TabIndex = 1;
            this.ndPromptLabel.Text = "ND";
            // 
            // mnPromptLabel
            // 
            this.mnPromptLabel.AutoSize = true;
            this.mnPromptLabel.Location = new System.Drawing.Point(25, 61);
            this.mnPromptLabel.Name = "mnPromptLabel";
            this.mnPromptLabel.Size = new System.Drawing.Size(27, 15);
            this.mnPromptLabel.TabIndex = 0;
            this.mnPromptLabel.Text = "MN";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(454, 706);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(91, 43);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(568, 707);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(91, 42);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // removeRecordButton
            // 
            this.removeRecordButton.Location = new System.Drawing.Point(394, 638);
            this.removeRecordButton.Name = "removeRecordButton";
            this.removeRecordButton.Size = new System.Drawing.Size(112, 43);
            this.removeRecordButton.TabIndex = 5;
            this.removeRecordButton.Text = "Remove Record";
            this.removeRecordButton.UseVisualStyleBackColor = true;
            this.removeRecordButton.Click += new System.EventHandler(this.removeRecordButton_Click);
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(295, 706);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(112, 42);
            this.removeAllButton.TabIndex = 6;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = true;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // SearchRecordButton
            // 
            this.SearchRecordButton.Location = new System.Drawing.Point(220, 638);
            this.SearchRecordButton.Name = "SearchRecordButton";
            this.SearchRecordButton.Size = new System.Drawing.Size(101, 43);
            this.SearchRecordButton.TabIndex = 7;
            this.SearchRecordButton.Text = "Search  State";
            this.SearchRecordButton.UseVisualStyleBackColor = true;
            this.SearchRecordButton.Click += new System.EventHandler(this.SearchRecordButton_Click);
            // 
            // lowestTempButton
            // 
            this.lowestTempButton.Location = new System.Drawing.Point(160, 707);
            this.lowestTempButton.Name = "lowestTempButton";
            this.lowestTempButton.Size = new System.Drawing.Size(101, 42);
            this.lowestTempButton.TabIndex = 8;
            this.lowestTempButton.Text = "Lowest Temp";
            this.lowestTempButton.UseVisualStyleBackColor = true;
            this.lowestTempButton.Click += new System.EventHandler(this.lowestTempButton_Click);
            // 
            // highestTempButton
            // 
            this.highestTempButton.Location = new System.Drawing.Point(10, 707);
            this.highestTempButton.Name = "highestTempButton";
            this.highestTempButton.Size = new System.Drawing.Size(111, 42);
            this.highestTempButton.TabIndex = 9;
            this.highestTempButton.Text = "Highest Temp";
            this.highestTempButton.UseVisualStyleBackColor = true;
            this.highestTempButton.Click += new System.EventHandler(this.highestTempButton_Click_1);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(29, 649);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(146, 23);
            this.searchTextbox.TabIndex = 10;
            // 
            // outputListBox
            // 
            this.outputListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 19;
            this.outputListBox.Location = new System.Drawing.Point(35, 468);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.ScrollAlwaysVisible = true;
            this.outputListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.outputListBox.Size = new System.Drawing.Size(634, 118);
            this.outputListBox.TabIndex = 12;
            // 
            // dateListBoxLabel
            // 
            this.dateListBoxLabel.AutoSize = true;
            this.dateListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateListBoxLabel.Location = new System.Drawing.Point(35, 442);
            this.dateListBoxLabel.Name = "dateListBoxLabel";
            this.dateListBoxLabel.Size = new System.Drawing.Size(42, 21);
            this.dateListBoxLabel.TabIndex = 13;
            this.dateListBoxLabel.Text = "Date";
            // 
            // cityListBoxLabel
            // 
            this.cityListBoxLabel.AutoSize = true;
            this.cityListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityListBoxLabel.Location = new System.Drawing.Point(264, 442);
            this.cityListBoxLabel.Name = "cityListBoxLabel";
            this.cityListBoxLabel.Size = new System.Drawing.Size(37, 21);
            this.cityListBoxLabel.TabIndex = 14;
            this.cityListBoxLabel.Text = "City";
            // 
            // stateListboxLabel
            // 
            this.stateListboxLabel.AutoSize = true;
            this.stateListboxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateListboxLabel.Location = new System.Drawing.Point(454, 442);
            this.stateListboxLabel.Name = "stateListboxLabel";
            this.stateListboxLabel.Size = new System.Drawing.Size(44, 21);
            this.stateListboxLabel.TabIndex = 15;
            this.stateListboxLabel.Text = "State";
            // 
            // tempListBoxlabel
            // 
            this.tempListBoxlabel.AutoSize = true;
            this.tempListBoxlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempListBoxlabel.Location = new System.Drawing.Point(550, 442);
            this.tempListBoxlabel.Name = "tempListBoxlabel";
            this.tempListBoxlabel.Size = new System.Drawing.Size(97, 21);
            this.tempListBoxlabel.TabIndex = 16;
            this.tempListBoxlabel.Text = "Temperature";
            // 
            // saveEditbutton
            // 
            this.saveEditbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveEditbutton.Location = new System.Drawing.Point(528, 638);
            this.saveEditbutton.Name = "saveEditbutton";
            this.saveEditbutton.Size = new System.Drawing.Size(131, 43);
            this.saveEditbutton.TabIndex = 17;
            this.saveEditbutton.Text = "Save";
            this.saveEditbutton.UseVisualStyleBackColor = true;
            this.saveEditbutton.Visible = false;
            this.saveEditbutton.Click += new System.EventHandler(this.saveEditbutton_Click);
            // 
            // weatherpictureBox
            // 
            this.weatherpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("weatherpictureBox.Image")));
            this.weatherpictureBox.Location = new System.Drawing.Point(56, 12);
            this.weatherpictureBox.Name = "weatherpictureBox";
            this.weatherpictureBox.Size = new System.Drawing.Size(283, 157);
            this.weatherpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.weatherpictureBox.TabIndex = 18;
            this.weatherpictureBox.TabStop = false;
            // 
            // mnAverageLabel
            // 
            this.mnAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mnAverageLabel.Location = new System.Drawing.Point(121, 57);
            this.mnAverageLabel.Name = "mnAverageLabel";
            this.mnAverageLabel.Size = new System.Drawing.Size(100, 23);
            this.mnAverageLabel.TabIndex = 19;
            this.mnAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ndAverageLabel
            // 
            this.ndAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ndAverageLabel.Location = new System.Drawing.Point(121, 95);
            this.ndAverageLabel.Name = "ndAverageLabel";
            this.ndAverageLabel.Size = new System.Drawing.Size(100, 23);
            this.ndAverageLabel.TabIndex = 20;
            this.ndAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdAverageLabel
            // 
            this.sdAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sdAverageLabel.Location = new System.Drawing.Point(121, 137);
            this.sdAverageLabel.Name = "sdAverageLabel";
            this.sdAverageLabel.Size = new System.Drawing.Size(100, 23);
            this.sdAverageLabel.TabIndex = 21;
            this.sdAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iaAverageLabel
            // 
            this.iaAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iaAverageLabel.Location = new System.Drawing.Point(121, 177);
            this.iaAverageLabel.Name = "iaAverageLabel";
            this.iaAverageLabel.Size = new System.Drawing.Size(100, 23);
            this.iaAverageLabel.TabIndex = 22;
            this.iaAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wiAverageLabel
            // 
            this.wiAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wiAverageLabel.Location = new System.Drawing.Point(120, 216);
            this.wiAverageLabel.Name = "wiAverageLabel";
            this.wiAverageLabel.Size = new System.Drawing.Size(100, 23);
            this.wiAverageLabel.TabIndex = 23;
            this.wiAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 771);
            this.Controls.Add(this.weatherpictureBox);
            this.Controls.Add(this.saveEditbutton);
            this.Controls.Add(this.tempListBoxlabel);
            this.Controls.Add(this.stateListboxLabel);
            this.Controls.Add(this.cityListBoxLabel);
            this.Controls.Add(this.dateListBoxLabel);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.highestTempButton);
            this.Controls.Add(this.lowestTempButton);
            this.Controls.Add(this.SearchRecordButton);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.removeRecordButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.AverageTempGroupBox);
            this.Controls.Add(this.weatherInfoGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Analysis Version 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.weatherInfoGroupBox.ResumeLayout(false);
            this.weatherInfoGroupBox.PerformLayout();
            this.AverageTempGroupBox.ResumeLayout(false);
            this.AverageTempGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox weatherInfoGroupBox;
        private DateTimePicker dateTimePicker;
        private TextBox tempTextBox;
        private ComboBox stateComboBox;
        private TextBox cityTextBox;
        private Label dateLabel;
        private Label TempLabel;
        private Label stateLabel;
        private Label cityLabel;
        private Button clearButton;
        private Button addButton;
        private GroupBox AverageTempGroupBox;
        private Label regionPromptLabel;
        private Label wiPromptLabel;
        private Label iaPromptLabel;
        private Label sdPromptLabel;
        private Label ndPromptLabel;
        private Label mnPromptLabel;
        private Button editButton;
        private Button closeButton;
        private Button removeRecordButton;
        private Button removeAllButton;
        private Button SearchRecordButton;
        private Button lowestTempButton;
        private Button highestTempButton;
        private TextBox searchTextbox;
        private ListBox outputListBox;
        private Label dateListBoxLabel;
        private Label cityListBoxLabel;
        private Label stateListboxLabel;
        private Label tempListBoxlabel;
        private Button saveEditbutton;
        private Label regionAverageLabel;
        private PictureBox weatherpictureBox;
        private Label wiAverageLabel;
        private Label iaAverageLabel;
        private Label sdAverageLabel;
        private Label ndAverageLabel;
        private Label mnAverageLabel;
    }
}