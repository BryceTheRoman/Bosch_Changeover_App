namespace Bosch_Changeover_App
{
    partial class SettingsUserControl
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
            this.sendDefaultEmail = new System.Windows.Forms.CheckBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.desktopAlarmCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sendDefaultEmail
            // 
            this.sendDefaultEmail.AutoSize = true;
            this.sendDefaultEmail.Checked = true;
            this.sendDefaultEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sendDefaultEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendDefaultEmail.Location = new System.Drawing.Point(39, 107);
            this.sendDefaultEmail.Name = "sendDefaultEmail";
            this.sendDefaultEmail.Size = new System.Drawing.Size(197, 20);
            this.sendDefaultEmail.TabIndex = 0;
            this.sendDefaultEmail.Text = "Send Alarm Email by Default";
            this.sendDefaultEmail.UseVisualStyleBackColor = true;
            this.sendDefaultEmail.CheckedChanged += new System.EventHandler(this.settingsCheckBox_CheckedChanged);
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTextBox.Location = new System.Drawing.Point(237, 52);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(250, 22);
            this.emailAddressTextBox.TabIndex = 1;
            this.emailAddressTextBox.Text = "bosch.changeover@gmail.com";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(37, 55);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(195, 16);
            this.emailAddressLabel.TabIndex = 2;
            this.emailAddressLabel.Text = "Email To Recieve Notifications:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(95)))), ((int)(((byte)(139)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(40, 307);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 47);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(329, 307);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 47);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // desktopAlarmCheckbox
            // 
            this.desktopAlarmCheckbox.AutoSize = true;
            this.desktopAlarmCheckbox.Checked = true;
            this.desktopAlarmCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.desktopAlarmCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopAlarmCheckbox.Location = new System.Drawing.Point(39, 143);
            this.desktopAlarmCheckbox.Name = "desktopAlarmCheckbox";
            this.desktopAlarmCheckbox.Size = new System.Drawing.Size(221, 20);
            this.desktopAlarmCheckbox.TabIndex = 9;
            this.desktopAlarmCheckbox.Text = "Sound Desktop Alarm by Default";
            this.desktopAlarmCheckbox.UseVisualStyleBackColor = true;
            this.desktopAlarmCheckbox.CheckedChanged += new System.EventHandler(this.desktopAlarmCheckbox_CheckedChanged);
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.desktopAlarmCheckbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.sendDefaultEmail);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(641, 458);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox sendDefaultEmail;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox desktopAlarmCheckbox;
    }
}

