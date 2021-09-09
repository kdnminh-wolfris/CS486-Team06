
namespace TVVN01_CS486_Team06
{
    partial class ContestantSelect
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
            this.cbTrainers = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTrainers
            // 
            this.cbTrainers.FormattingEnabled = true;
            this.cbTrainers.Location = new System.Drawing.Point(27, 34);
            this.cbTrainers.Name = "cbTrainers";
            this.cbTrainers.Size = new System.Drawing.Size(145, 21);
            this.cbTrainers.TabIndex = 0;
            this.cbTrainers.SelectedIndexChanged += new System.EventHandler(this.cbTrainers_SelectedIndexChanged);
            this.cbTrainers.SelectionChangeCommitted += new System.EventHandler(this.cbTrainers_SelectionChangeCommitted);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(193, 34);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ContestantSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 151);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbTrainers);
            this.Name = "ContestantSelect";
            this.Text = "ContestantSelect";
            this.Load += new System.EventHandler(this.ContestantSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTrainers;
        private System.Windows.Forms.Button btnSelect;
    }
}