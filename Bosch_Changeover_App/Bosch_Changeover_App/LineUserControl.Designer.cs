namespace Bosch_Changeover_App
{
    partial class LineUserControl
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
            this.line1Label = new System.Windows.Forms.Label();
            this.line2Label = new System.Windows.Forms.Label();
            this.line2ListBox = new System.Windows.Forms.ListBox();
            this.line3Label = new System.Windows.Forms.Label();
            this.line3ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelOnLine1 = new System.Windows.Forms.Panel();
            this.panelOffLine1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // line1Label
            // 
            this.line1Label.AutoSize = true;
            this.line1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line1Label.Location = new System.Drawing.Point(130, 29);
            this.line1Label.Name = "line1Label";
            this.line1Label.Size = new System.Drawing.Size(93, 31);
            this.line1Label.TabIndex = 1;
            this.line1Label.Text = "Line 1";
            // 
            // line2Label
            // 
            this.line2Label.AutoSize = true;
            this.line2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line2Label.Location = new System.Drawing.Point(357, 29);
            this.line2Label.Name = "line2Label";
            this.line2Label.Size = new System.Drawing.Size(93, 31);
            this.line2Label.TabIndex = 3;
            this.line2Label.Text = "Line 2";
            // 
            // line2ListBox
            // 
            this.line2ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2ListBox.FormattingEnabled = true;
            this.line2ListBox.ItemHeight = 24;
            this.line2ListBox.Items.AddRange(new object[] {
            "553\t          0:57",
            "513\t          2:30",
            "932\t          4:00"});
            this.line2ListBox.Location = new System.Drawing.Point(304, 92);
            this.line2ListBox.Name = "line2ListBox";
            this.line2ListBox.Size = new System.Drawing.Size(189, 388);
            this.line2ListBox.TabIndex = 2;
            // 
            // line3Label
            // 
            this.line3Label.AutoSize = true;
            this.line3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line3Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line3Label.Location = new System.Drawing.Point(584, 29);
            this.line3Label.Name = "line3Label";
            this.line3Label.Size = new System.Drawing.Size(93, 31);
            this.line3Label.TabIndex = 5;
            this.line3Label.Text = "Line 3";
            // 
            // line3ListBox
            // 
            this.line3ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line3ListBox.FormattingEnabled = true;
            this.line3ListBox.ItemHeight = 24;
            this.line3ListBox.Items.AddRange(new object[] {
            "553\t             83",
            "513\t             10",
            "932\t             43"});
            this.line3ListBox.Location = new System.Drawing.Point(534, 92);
            this.line3ListBox.Name = "line3ListBox";
            this.line3ListBox.Size = new System.Drawing.Size(192, 388);
            this.line3ListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Part";
            // 
            // panelOnLine1
            // 
            this.panelOnLine1.AutoScroll = true;
            this.panelOnLine1.Location = new System.Drawing.Point(56, 92);
            this.panelOnLine1.Name = "panelOnLine1";
            this.panelOnLine1.Size = new System.Drawing.Size(231, 137);
            this.panelOnLine1.TabIndex = 10;
            // 
            // panelOffLine1
            // 
            this.panelOffLine1.AutoScroll = true;
            this.panelOffLine1.Location = new System.Drawing.Point(56, 247);
            this.panelOffLine1.Name = "panelOffLine1";
            this.panelOffLine1.Size = new System.Drawing.Size(231, 233);
            this.panelOffLine1.TabIndex = 11;
            // 
            // LineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOffLine1);
            this.Controls.Add(this.panelOnLine1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.line3Label);
            this.Controls.Add(this.line3ListBox);
            this.Controls.Add(this.line2Label);
            this.Controls.Add(this.line2ListBox);
            this.Controls.Add(this.line1Label);
            this.Name = "LineUserControl";
            this.Size = new System.Drawing.Size(834, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label line1Label;
        private System.Windows.Forms.Label line2Label;
        private System.Windows.Forms.ListBox line2ListBox;
        private System.Windows.Forms.Label line3Label;
        private System.Windows.Forms.ListBox line3ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelOnLine1;
        private System.Windows.Forms.Panel panelOffLine1;
    }
}

