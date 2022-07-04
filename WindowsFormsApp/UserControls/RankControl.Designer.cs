namespace WindowsFormsApp.UserControls
{
    partial class RankControl
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblGoalsText = new System.Windows.Forms.Label();
            this.lblCardsText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCards = new System.Windows.Forms.Label();
            this.lblGoals = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::WindowsFormsApp.Properties.Resources.playerIcon;
            this.pictureBox.Location = new System.Drawing.Point(210, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(98, 86);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // lblGoalsText
            // 
            this.lblGoalsText.AutoSize = true;
            this.lblGoalsText.Location = new System.Drawing.Point(15, 86);
            this.lblGoalsText.Name = "lblGoalsText";
            this.lblGoalsText.Size = new System.Drawing.Size(37, 13);
            this.lblGoalsText.TabIndex = 8;
            this.lblGoalsText.Text = "Goals:";
            // 
            // lblCardsText
            // 
            this.lblCardsText.AutoSize = true;
            this.lblCardsText.Location = new System.Drawing.Point(15, 59);
            this.lblCardsText.Name = "lblCardsText";
            this.lblCardsText.Size = new System.Drawing.Size(37, 13);
            this.lblCardsText.TabIndex = 7;
            this.lblCardsText.Text = "Cards:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblCards
            // 
            this.lblCards.AutoSize = true;
            this.lblCards.Location = new System.Drawing.Point(65, 59);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(0, 13);
            this.lblCards.TabIndex = 11;
            // 
            // lblGoals
            // 
            this.lblGoals.AutoSize = true;
            this.lblGoals.Location = new System.Drawing.Point(65, 86);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(0, 13);
            this.lblGoals.TabIndex = 12;
            // 
            // RankControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGoals);
            this.Controls.Add(this.lblCards);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblGoalsText);
            this.Controls.Add(this.lblCardsText);
            this.Controls.Add(this.lblName);
            this.Name = "RankControl";
            this.Size = new System.Drawing.Size(323, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblGoalsText;
        private System.Windows.Forms.Label lblCardsText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.Label lblGoals;
    }
}
