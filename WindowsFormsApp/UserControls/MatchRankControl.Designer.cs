namespace WindowsFormsApp.UserControls
{
    partial class MatchRankControl
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblVisitor = new System.Windows.Forms.Label();
            this.lblViewers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(55, 20);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(35, 13);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "label1";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(55, 49);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(35, 13);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "label1";
            // 
            // lblVisitor
            // 
            this.lblVisitor.AutoSize = true;
            this.lblVisitor.Location = new System.Drawing.Point(55, 75);
            this.lblVisitor.Name = "lblVisitor";
            this.lblVisitor.Size = new System.Drawing.Size(35, 13);
            this.lblVisitor.TabIndex = 2;
            this.lblVisitor.Text = "label1";
            // 
            // lblViewers
            // 
            this.lblViewers.AutoSize = true;
            this.lblViewers.Location = new System.Drawing.Point(55, 97);
            this.lblViewers.Name = "lblViewers";
            this.lblViewers.Size = new System.Drawing.Size(35, 13);
            this.lblViewers.TabIndex = 3;
            this.lblViewers.Text = "label1";
            // 
            // MatchRankControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblViewers);
            this.Controls.Add(this.lblVisitor);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblLocation);
            this.Name = "MatchRankControl";
            this.Size = new System.Drawing.Size(145, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblVisitor;
        private System.Windows.Forms.Label lblViewers;
    }
}
