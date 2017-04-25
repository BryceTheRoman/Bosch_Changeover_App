namespace Bosch_Changeover_App
{
    partial class LinesLayoutUserControl
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
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.panelLine3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelLine1
            // 
            this.panelLine1.AutoScroll = true;
            this.panelLine1.Location = new System.Drawing.Point(16, 33);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(466, 636);
            this.panelLine1.TabIndex = 61;
            // 
            // panelLine2
            // 
            this.panelLine2.AutoScroll = true;
            this.panelLine2.Location = new System.Drawing.Point(485, 33);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(466, 636);
            this.panelLine2.TabIndex = 62;
            // 
            // panelLine3
            // 
            this.panelLine3.AutoScroll = true;
            this.panelLine3.Location = new System.Drawing.Point(955, 33);
            this.panelLine3.Name = "panelLine3";
            this.panelLine3.Size = new System.Drawing.Size(466, 636);
            this.panelLine3.TabIndex = 63;
            // 
            // LinesLayoutUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLine3);
            this.Controls.Add(this.panelLine2);
            this.Controls.Add(this.panelLine1);
            this.Name = "LinesLayoutUserControl";
            this.Size = new System.Drawing.Size(1493, 693);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.Panel panelLine3;
    }
}
