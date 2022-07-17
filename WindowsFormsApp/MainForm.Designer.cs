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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.allPlayersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.favoritePlayersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnCards = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.lblSettings = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // allPlayersPanel
            // 
            this.allPlayersPanel.AllowDrop = true;
            resources.ApplyResources(this.allPlayersPanel, "allPlayersPanel");
            this.allPlayersPanel.Name = "allPlayersPanel";
            this.allPlayersPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.allPlayersPanel_DragDrop);
            this.allPlayersPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.allPlayersPanel_DragEnter);
            // 
            // favoritePlayersPanel
            // 
            this.favoritePlayersPanel.AllowDrop = true;
            resources.ApplyResources(this.favoritePlayersPanel, "favoritePlayersPanel");
            this.favoritePlayersPanel.Name = "favoritePlayersPanel";
            this.favoritePlayersPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.favoritePlayersPanel_DragDrop);
            this.favoritePlayersPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.favoritePlayersPanel_DragEnter);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnGoals
            // 
            resources.ApplyResources(this.btnGoals, "btnGoals");
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.UseVisualStyleBackColor = true;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            // 
            // btnCards
            // 
            resources.ApplyResources(this.btnCards, "btnCards");
            this.btnCards.Name = "btnCards";
            this.btnCards.UseVisualStyleBackColor = true;
            this.btnCards.Click += new System.EventHandler(this.btnCards_Click);
            // 
            // btnVisitors
            // 
            resources.ApplyResources(this.btnVisitors, "btnVisitors");
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.UseVisualStyleBackColor = true;
            this.btnVisitors.Click += new System.EventHandler(this.btnVisitors_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSettings});
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Name = "toolStrip";
            // 
            // lblSettings
            // 
            resources.ApplyResources(this.lblSettings, "lblSettings");
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Click += new System.EventHandler(this.lblSettings_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnVisitors);
            this.Controls.Add(this.btnCards);
            this.Controls.Add(this.btnGoals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.favoritePlayersPanel);
            this.Controls.Add(this.allPlayersPanel);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel allPlayersPanel;
        private System.Windows.Forms.FlowLayoutPanel favoritePlayersPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Button btnCards;
        private System.Windows.Forms.Button btnVisitors;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel lblSettings;
        private System.Windows.Forms.Label label1;
    }
}