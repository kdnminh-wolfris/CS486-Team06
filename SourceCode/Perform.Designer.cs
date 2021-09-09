
namespace TVVN01_CS486_Team06
{
    partial class Perform
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
            this.cbPerformance = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrainer1 = new System.Windows.Forms.CheckBox();
            this.cbTrainer2 = new System.Windows.Forms.CheckBox();
            this.cbTrainer3 = new System.Windows.Forms.CheckBox();
            this.cbTrainer4 = new System.Windows.Forms.CheckBox();
            this.rtbFeedback1 = new System.Windows.Forms.RichTextBox();
            this.rtbFeedback2 = new System.Windows.Forms.RichTextBox();
            this.rtbFeedback3 = new System.Windows.Forms.RichTextBox();
            this.rtbFeedback4 = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPerformance
            // 
            this.cbPerformance.FormattingEnabled = true;
            this.cbPerformance.Location = new System.Drawing.Point(240, 29);
            this.cbPerformance.Name = "cbPerformance";
            this.cbPerformance.Size = new System.Drawing.Size(205, 21);
            this.cbPerformance.TabIndex = 0;
            this.cbPerformance.SelectionChangeCommitted += new System.EventHandler(this.cbPerformance_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a performance";
            // 
            // cbTrainer1
            // 
            this.cbTrainer1.AutoSize = true;
            this.cbTrainer1.Location = new System.Drawing.Point(12, 89);
            this.cbTrainer1.Name = "cbTrainer1";
            this.cbTrainer1.Size = new System.Drawing.Size(77, 17);
            this.cbTrainer1.TabIndex = 2;
            this.cbTrainer1.Text = "cbTrainer1";
            this.cbTrainer1.UseVisualStyleBackColor = true;
            // 
            // cbTrainer2
            // 
            this.cbTrainer2.AutoSize = true;
            this.cbTrainer2.Location = new System.Drawing.Point(200, 89);
            this.cbTrainer2.Name = "cbTrainer2";
            this.cbTrainer2.Size = new System.Drawing.Size(80, 17);
            this.cbTrainer2.TabIndex = 3;
            this.cbTrainer2.Text = "checkBox2";
            this.cbTrainer2.UseVisualStyleBackColor = true;
            // 
            // cbTrainer3
            // 
            this.cbTrainer3.AutoSize = true;
            this.cbTrainer3.Location = new System.Drawing.Point(392, 89);
            this.cbTrainer3.Name = "cbTrainer3";
            this.cbTrainer3.Size = new System.Drawing.Size(80, 17);
            this.cbTrainer3.TabIndex = 4;
            this.cbTrainer3.Text = "checkBox3";
            this.cbTrainer3.UseVisualStyleBackColor = true;
            // 
            // cbTrainer4
            // 
            this.cbTrainer4.AutoSize = true;
            this.cbTrainer4.Location = new System.Drawing.Point(600, 89);
            this.cbTrainer4.Name = "cbTrainer4";
            this.cbTrainer4.Size = new System.Drawing.Size(80, 17);
            this.cbTrainer4.TabIndex = 5;
            this.cbTrainer4.Text = "checkBox4";
            this.cbTrainer4.UseVisualStyleBackColor = true;
            // 
            // rtbFeedback1
            // 
            this.rtbFeedback1.Location = new System.Drawing.Point(13, 113);
            this.rtbFeedback1.Name = "rtbFeedback1";
            this.rtbFeedback1.Size = new System.Drawing.Size(123, 117);
            this.rtbFeedback1.TabIndex = 6;
            this.rtbFeedback1.Text = "";
            // 
            // rtbFeedback2
            // 
            this.rtbFeedback2.Location = new System.Drawing.Point(200, 113);
            this.rtbFeedback2.Name = "rtbFeedback2";
            this.rtbFeedback2.Size = new System.Drawing.Size(114, 117);
            this.rtbFeedback2.TabIndex = 7;
            this.rtbFeedback2.Text = "";
            // 
            // rtbFeedback3
            // 
            this.rtbFeedback3.Location = new System.Drawing.Point(392, 113);
            this.rtbFeedback3.Name = "rtbFeedback3";
            this.rtbFeedback3.Size = new System.Drawing.Size(123, 117);
            this.rtbFeedback3.TabIndex = 8;
            this.rtbFeedback3.Text = "";
            // 
            // rtbFeedback4
            // 
            this.rtbFeedback4.Location = new System.Drawing.Point(600, 112);
            this.rtbFeedback4.Name = "rtbFeedback4";
            this.rtbFeedback4.Size = new System.Drawing.Size(120, 118);
            this.rtbFeedback4.TabIndex = 9;
            this.rtbFeedback4.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(600, 315);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Perform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 359);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rtbFeedback4);
            this.Controls.Add(this.rtbFeedback3);
            this.Controls.Add(this.rtbFeedback2);
            this.Controls.Add(this.rtbFeedback1);
            this.Controls.Add(this.cbTrainer4);
            this.Controls.Add(this.cbTrainer3);
            this.Controls.Add(this.cbTrainer2);
            this.Controls.Add(this.cbTrainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPerformance);
            this.Name = "Perform";
            this.Text = "Perform";
            this.Load += new System.EventHandler(this.Perform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPerformance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTrainer1;
        private System.Windows.Forms.CheckBox cbTrainer2;
        private System.Windows.Forms.CheckBox cbTrainer3;
        private System.Windows.Forms.CheckBox cbTrainer4;
        private System.Windows.Forms.RichTextBox rtbFeedback1;
        private System.Windows.Forms.RichTextBox rtbFeedback2;
        private System.Windows.Forms.RichTextBox rtbFeedback3;
        private System.Windows.Forms.RichTextBox rtbFeedback4;
        private System.Windows.Forms.Button btnConfirm;
    }
}