
namespace TVVN01_CS486_Team06
{
    partial class TheVoice
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrentMembersOfEachTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addATrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAPerformanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCurrentMembersOfEachTeamToolStripMenuItem,
            this.addATrainerToolStripMenuItem,
            this.addAPerformanceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // showCurrentMembersOfEachTeamToolStripMenuItem
            // 
            this.showCurrentMembersOfEachTeamToolStripMenuItem.Name = "showCurrentMembersOfEachTeamToolStripMenuItem";
            this.showCurrentMembersOfEachTeamToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.showCurrentMembersOfEachTeamToolStripMenuItem.Text = "Show current members of each Team";
            this.showCurrentMembersOfEachTeamToolStripMenuItem.Click += new System.EventHandler(this.showCurrentMembersOfEachTeamToolStripMenuItem_Click);
            // 
            // addATrainerToolStripMenuItem
            // 
            this.addATrainerToolStripMenuItem.Name = "addATrainerToolStripMenuItem";
            this.addATrainerToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.addATrainerToolStripMenuItem.Text = "Add a trainer";
            this.addATrainerToolStripMenuItem.Click += new System.EventHandler(this.addATrainerToolStripMenuItem_Click);
            // 
            // addAPerformanceToolStripMenuItem
            // 
            this.addAPerformanceToolStripMenuItem.Name = "addAPerformanceToolStripMenuItem";
            this.addAPerformanceToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.addAPerformanceToolStripMenuItem.Text = "Add a performance";
            this.addAPerformanceToolStripMenuItem.Click += new System.EventHandler(this.addAPerformanceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(12, 75);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(384, 251);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(43, 40);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(109, 20);
            this.tbInfo.TabIndex = 2;
            this.tbInfo.Text = "The Voice 2021";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(453, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start A Performance";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TheVoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 350);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TheVoice";
            this.Text = "The Voice";
            this.Load += new System.EventHandler(this.TheVoice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrentMembersOfEachTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addATrainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAPerformanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnStart;
    }
}

