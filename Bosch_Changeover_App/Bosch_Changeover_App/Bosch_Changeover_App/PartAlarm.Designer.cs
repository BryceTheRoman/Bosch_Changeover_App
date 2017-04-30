namespace Bosch_Changeover_App

{
    partial class PartAlarm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartAlarm));
            this.partTypeLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.timeRemainingText = new System.Windows.Forms.Label();
            this.timeRemaining = new System.Windows.Forms.Label();
            this.emailNotification = new System.Windows.Forms.CheckBox();
            this.partsText = new System.Windows.Forms.Label();
            this.numberOfParts = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.lineNum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // partTypeLabel
            // 
            this.partTypeLabel.AutoSize = true;
            this.partTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partTypeLabel.Location = new System.Drawing.Point(50, 41);
            this.partTypeLabel.Name = "partTypeLabel";
            this.partTypeLabel.Size = new System.Drawing.Size(110, 24);
            this.partTypeLabel.TabIndex = 0;
            this.partTypeLabel.Text = "5308542642";
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(178, 7);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(26, 30);
            this.editButton.TabIndex = 1;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(5, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(27, 35);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // timeRemainingText
            // 
            this.timeRemainingText.AutoSize = true;
            this.timeRemainingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRemainingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(95)))), ((int)(((byte)(139)))));
            this.timeRemainingText.Location = new System.Drawing.Point(49, 80);
            this.timeRemainingText.Name = "timeRemainingText";
            this.timeRemainingText.Size = new System.Drawing.Size(110, 16);
            this.timeRemainingText.TabIndex = 4;
            this.timeRemainingText.Text = "Time Remaining:";
            // 
            // timeRemaining
            // 
            this.timeRemaining.AutoSize = true;
            this.timeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRemaining.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeRemaining.Location = new System.Drawing.Point(33, 96);
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(141, 37);
            this.timeRemaining.TabIndex = 6;
            this.timeRemaining.Text = "00:04:15";
            // 
            // emailNotification
            // 
            this.emailNotification.Checked = true;
            this.emailNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.emailNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))));
            this.emailNotification.Location = new System.Drawing.Point(29, 174);
            this.emailNotification.Name = "emailNotification";
            this.emailNotification.Size = new System.Drawing.Size(154, 28);
            this.emailNotification.TabIndex = 0;
            this.emailNotification.Text = "Recieve Email Notification";
            this.emailNotification.UseVisualStyleBackColor = true;
            this.emailNotification.CheckedChanged += new System.EventHandler(this.emailNotification_CheckedChanged);
            // 
            // partsText
            // 
            this.partsText.AutoSize = true;
            this.partsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.partsText.Location = new System.Drawing.Point(51, 150);
            this.partsText.Name = "partsText";
            this.partsText.Size = new System.Drawing.Size(31, 13);
            this.partsText.TabIndex = 7;
            this.partsText.Text = "Parts";
            // 
            // numberOfParts
            // 
            this.numberOfParts.AutoSize = true;
            this.numberOfParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.numberOfParts.Location = new System.Drawing.Point(30, 150);
            this.numberOfParts.Name = "numberOfParts";
            this.numberOfParts.Size = new System.Drawing.Size(25, 13);
            this.numberOfParts.TabIndex = 8;
            this.numberOfParts.Text = "125";
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = true;
            this.lineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.lineLabel.Location = new System.Drawing.Point(122, 150);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(30, 13);
            this.lineLabel.TabIndex = 10;
            this.lineLabel.Text = "Line:";
            // 
            // lineNum
            // 
            this.lineNum.AutoSize = true;
            this.lineNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.lineNum.Location = new System.Drawing.Point(152, 150);
            this.lineNum.Name = "lineNum";
            this.lineNum.Size = new System.Drawing.Size(13, 13);
            this.lineNum.TabIndex = 9;
            this.lineNum.Text = "1";
            // 
            // PartAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.lineNum);
            this.Controls.Add(this.numberOfParts);
            this.Controls.Add(this.partsText);
            this.Controls.Add(this.emailNotification);
            this.Controls.Add(this.timeRemaining);
            this.Controls.Add(this.timeRemainingText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.partTypeLabel);
            this.Name = "PartAlarm";
            this.Size = new System.Drawing.Size(211, 203);
            this.Load += new System.EventHandler(this.PartAlarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label partTypeLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label timeRemainingText;
        private System.Windows.Forms.Label timeRemaining;
        private System.Windows.Forms.CheckBox emailNotification;
        private System.Windows.Forms.Label partsText;
        private System.Windows.Forms.Label numberOfParts;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Label lineNum;
        private System.Windows.Forms.Timer timer1;
    }
}
