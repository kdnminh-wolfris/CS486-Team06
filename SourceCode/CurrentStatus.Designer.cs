
namespace TVVN01_CS486_Team06
{
    partial class CurrentStatus
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
            this.dgvTeam1 = new System.Windows.Forms.DataGridView();
            this.dgvTeam2 = new System.Windows.Forms.DataGridView();
            this.dgvTeam3 = new System.Windows.Forms.DataGridView();
            this.dgvTeam4 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeam1
            // 
            this.dgvTeam1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam1.Location = new System.Drawing.Point(42, 118);
            this.dgvTeam1.Name = "dgvTeam1";
            this.dgvTeam1.Size = new System.Drawing.Size(157, 227);
            this.dgvTeam1.TabIndex = 0;
            // 
            // dgvTeam2
            // 
            this.dgvTeam2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam2.Location = new System.Drawing.Point(231, 118);
            this.dgvTeam2.Name = "dgvTeam2";
            this.dgvTeam2.Size = new System.Drawing.Size(159, 227);
            this.dgvTeam2.TabIndex = 1;
            // 
            // dgvTeam3
            // 
            this.dgvTeam3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam3.Location = new System.Drawing.Point(434, 118);
            this.dgvTeam3.Name = "dgvTeam3";
            this.dgvTeam3.Size = new System.Drawing.Size(166, 227);
            this.dgvTeam3.TabIndex = 2;
            // 
            // dgvTeam4
            // 
            this.dgvTeam4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam4.Location = new System.Drawing.Point(632, 118);
            this.dgvTeam4.Name = "dgvTeam4";
            this.dgvTeam4.Size = new System.Drawing.Size(164, 227);
            this.dgvTeam4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Team 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Team 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Team 4";
            // 
            // CurrentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 374);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTeam4);
            this.Controls.Add(this.dgvTeam3);
            this.Controls.Add(this.dgvTeam2);
            this.Controls.Add(this.dgvTeam1);
            this.Name = "CurrentStatus";
            this.Text = "CurrentStatus";
            this.Load += new System.EventHandler(this.CurrentStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeam1;
        private System.Windows.Forms.DataGridView dgvTeam2;
        private System.Windows.Forms.DataGridView dgvTeam3;
        private System.Windows.Forms.DataGridView dgvTeam4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}