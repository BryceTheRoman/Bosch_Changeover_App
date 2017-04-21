namespace Bosch_Changeover_App
{
    partial class CreateAlarmPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAlarmPopup));
            this.partTypeLabel = new System.Windows.Forms.Label();
            this.partTypeTextBox = new System.Windows.Forms.TextBox();
            this.lineLabel = new System.Windows.Forms.Label();
            this.lineComboBox = new System.Windows.Forms.ComboBox();
            this.stationLabel = new System.Windows.Forms.Label();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.alarmTimeLabel = new System.Windows.Forms.Label();
            this.alarmTimeComboBox = new System.Windows.Forms.ComboBox();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.desktopCheckBox = new System.Windows.Forms.CheckBox();
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // partTypeLabel
            // 
            this.partTypeLabel.AutoSize = true;
            this.partTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partTypeLabel.Location = new System.Drawing.Point(84, 113);
            this.partTypeLabel.Name = "partTypeLabel";
            this.partTypeLabel.Size = new System.Drawing.Size(80, 20);
            this.partTypeLabel.TabIndex = 5;
            this.partTypeLabel.Text = "Part Type:";
            // 
            // partTypeTextBox
            // 
            this.partTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partTypeTextBox.Location = new System.Drawing.Point(174, 110);
            this.partTypeTextBox.MaxLength = 10;
            this.partTypeTextBox.Name = "partTypeTextBox";
            this.partTypeTextBox.Size = new System.Drawing.Size(120, 26);
            this.partTypeTextBox.TabIndex = 1;
            this.partTypeTextBox.Text = "XXXXXXXXXX";
            this.partTypeTextBox.TextChanged += new System.EventHandler(this.partTypeTextBox_TextChanged);
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = true;
            this.lineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel.Location = new System.Drawing.Point(121, 158);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(43, 20);
            this.lineLabel.TabIndex = 8;
            this.lineLabel.Text = "Line:";
            // 
            // lineComboBox
            // 
            this.lineComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineComboBox.FormattingEnabled = true;
            this.lineComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.lineComboBox.Location = new System.Drawing.Point(174, 158);
            this.lineComboBox.Name = "lineComboBox";
            this.lineComboBox.Size = new System.Drawing.Size(62, 24);
            this.lineComboBox.TabIndex = 2;
            this.lineComboBox.Text = "1";
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationLabel.Location = new System.Drawing.Point(51, 207);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(113, 16);
            this.stationLabel.TabIndex = 11;
            this.stationLabel.Text = "(Optional) Station:";
            // 
            // stationComboBox
            // 
            this.stationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationComboBox.FormattingEnabled = true;
            this.stationComboBox.Items.AddRange(new object[] {
            "02",
            "18",
            "17",
            "16",
            "12",
            "14",
            "20",
            "22",
            "24",
            "25",
            "28",
            "29",
            "30",
            "31",
            "32",
            "38",
            "48",
            "49",
            "39",
            "42",
            "40",
            "140",
            "44",
            "46",
            "34",
            "50",
            "150",
            "51",
            "53",
            "58",
            "60",
            "62",
            "64",
            "66",
            "94",
            "68",
            "70",
            "71",
            "72",
            "74"});
            this.stationComboBox.Location = new System.Drawing.Point(174, 204);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(62, 24);
            this.stationComboBox.TabIndex = 3;
            this.stationComboBox.Text = "02";
            // 
            // alarmTimeLabel
            // 
            this.alarmTimeLabel.AutoSize = true;
            this.alarmTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmTimeLabel.Location = new System.Drawing.Point(74, 266);
            this.alarmTimeLabel.Name = "alarmTimeLabel";
            this.alarmTimeLabel.Size = new System.Drawing.Size(96, 20);
            this.alarmTimeLabel.TabIndex = 14;
            this.alarmTimeLabel.Text = "Alarm Time: ";
            // 
            // alarmTimeComboBox
            // 
            this.alarmTimeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.alarmTimeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmTimeComboBox.FormattingEnabled = true;
            this.alarmTimeComboBox.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "Custom"});
            this.alarmTimeComboBox.Location = new System.Drawing.Point(174, 263);
            this.alarmTimeComboBox.Name = "alarmTimeComboBox";
            this.alarmTimeComboBox.Size = new System.Drawing.Size(90, 28);
            this.alarmTimeComboBox.TabIndex = 4;
            this.alarmTimeComboBox.Text = "30";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.minutesLabel.Location = new System.Drawing.Point(270, 266);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(290, 20);
            this.minutesLabel.TabIndex = 16;
            this.minutesLabel.Text = "Minutes Before Part Enters Line/Station";
            // 
            // desktopCheckBox
            // 
            this.desktopCheckBox.AutoSize = true;
            this.desktopCheckBox.Checked = true;
            this.desktopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.desktopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(95)))), ((int)(((byte)(139)))));
            this.desktopCheckBox.Location = new System.Drawing.Point(174, 321);
            this.desktopCheckBox.Name = "desktopCheckBox";
            this.desktopCheckBox.Size = new System.Drawing.Size(232, 24);
            this.desktopCheckBox.TabIndex = 5;
            this.desktopCheckBox.Text = "Recieve Desktop Notification";
            this.desktopCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Checked = true;
            this.emailCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.emailCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(95)))), ((int)(((byte)(139)))));
            this.emailCheckBox.Location = new System.Drawing.Point(174, 357);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(211, 24);
            this.emailCheckBox.TabIndex = 6;
            this.emailCheckBox.Text = "Recieve Email Notification";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(482, 427);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(149, 54);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(95)))), ((int)(((byte)(139)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(58, 427);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 54);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))));
            this.panel3.Controls.Add(this.currentTimeLabel);
            this.panel3.Controls.Add(this.selectionLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 72);
            this.panel3.TabIndex = 21;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.currentTimeLabel.Location = new System.Drawing.Point(475, 13);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(178, 42);
            this.currentTimeLabel.TabIndex = 3;
            this.currentTimeLabel.Text = "00:00 PM";
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectionLabel.Location = new System.Drawing.Point(32, 18);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(274, 37);
            this.selectionLabel.TabIndex = 0;
            this.selectionLabel.Text = "Create Part Alarm";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CreateAlarmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.desktopCheckBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.stationComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.emailCheckBox);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.alarmTimeComboBox);
            this.Controls.Add(this.alarmTimeLabel);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.lineComboBox);
            this.Controls.Add(this.partTypeLabel);
            this.Controls.Add(this.partTypeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAlarmPopup";
            this.Text = "Create Part Alarm";
            this.Load += new System.EventHandler(this.CreateAlarmPopup_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label partTypeLabel;
        private System.Windows.Forms.TextBox partTypeTextBox;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.Label alarmTimeLabel;
        private System.Windows.Forms.ComboBox alarmTimeComboBox;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox stationComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.ComboBox lineComboBox;
        private System.Windows.Forms.CheckBox desktopCheckBox;
        private System.Windows.Forms.Label currentTimeLabel;
        public System.Windows.Forms.Timer timer1;
    }
}