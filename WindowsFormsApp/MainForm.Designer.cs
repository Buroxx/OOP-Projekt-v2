namespace WindowsFormsApp
{
    partial class MainForm
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
            this.allPlayersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.favoritePlayersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnCards = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All players:";
            // 
            // allPlayersPanel
            // 
            this.allPlayersPanel.AutoScroll = true;
            this.allPlayersPanel.Location = new System.Drawing.Point(12, 38);
            this.allPlayersPanel.Name = "allPlayersPanel";
            this.allPlayersPanel.Size = new System.Drawing.Size(313, 400);
            this.allPlayersPanel.TabIndex = 1;
            // 
            // favoritePlayersPanel
            // 
            this.favoritePlayersPanel.Location = new System.Drawing.Point(475, 38);
            this.favoritePlayersPanel.Name = "favoritePlayersPanel";
            this.favoritePlayersPanel.Size = new System.Drawing.Size(313, 400);
            this.favoritePlayersPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Favorite players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order by:";
            // 
            // btnGoals
            // 
            this.btnGoals.Location = new System.Drawing.Point(363, 248);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(75, 23);
            this.btnGoals.TabIndex = 5;
            this.btnGoals.Text = "Goal";
            this.btnGoals.UseVisualStyleBackColor = true;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            // 
            // btnCards
            // 
            this.btnCards.Location = new System.Drawing.Point(363, 289);
            this.btnCards.Name = "btnCards";
            this.btnCards.Size = new System.Drawing.Size(75, 23);
            this.btnCards.TabIndex = 6;
            this.btnCards.Text = "Cards";
            this.btnCards.UseVisualStyleBackColor = true;
            this.btnCards.Click += new System.EventHandler(this.btnCards_Click);
            // 
            // btnVisitors
            // 
            this.btnVisitors.Location = new System.Drawing.Point(363, 328);
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.Size = new System.Drawing.Size(75, 23);
            this.btnVisitors.TabIndex = 7;
            this.btnVisitors.Text = "Visitors";
            this.btnVisitors.UseVisualStyleBackColor = true;
            this.btnVisitors.Click += new System.EventHandler(this.btnVisitors_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisitors);
            this.Controls.Add(this.btnCards);
            this.Controls.Add(this.btnGoals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.favoritePlayersPanel);
            this.Controls.Add(this.allPlayersPanel);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Players";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel allPlayersPanel;
        private System.Windows.Forms.FlowLayoutPanel favoritePlayersPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Button btnCards;
        private System.Windows.Forms.Button btnVisitors;
    }
}