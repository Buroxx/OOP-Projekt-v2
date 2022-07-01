namespace WindowsFormsApp
{
    partial class FavoriteTeam
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
            this.label1 = new System.Windows.Forms.Label();
            this.ddlTeam = new System.Windows.Forms.ComboBox();
            this.btnPickTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick your favorite team:";
            // 
            // ddlTeam
            // 
            this.ddlTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeam.FormattingEnabled = true;
            this.ddlTeam.Location = new System.Drawing.Point(15, 39);
            this.ddlTeam.Name = "ddlTeam";
            this.ddlTeam.Size = new System.Drawing.Size(226, 21);
            this.ddlTeam.TabIndex = 1;
            // 
            // btnPickTeam
            // 
            this.btnPickTeam.Location = new System.Drawing.Point(96, 77);
            this.btnPickTeam.Name = "btnPickTeam";
            this.btnPickTeam.Size = new System.Drawing.Size(75, 23);
            this.btnPickTeam.TabIndex = 2;
            this.btnPickTeam.Text = "Save";
            this.btnPickTeam.UseVisualStyleBackColor = true;
            this.btnPickTeam.Click += new System.EventHandler(this.btnPickTeam_Click);
            // 
            // FavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 125);
            this.Controls.Add(this.btnPickTeam);
            this.Controls.Add(this.ddlTeam);
            this.Controls.Add(this.label1);
            this.Name = "FavoriteTeam";
            this.Text = "Favorite team";
            this.Load += new System.EventHandler(this.FavoriteTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlTeam;
        private System.Windows.Forms.Button btnPickTeam;
    }
}