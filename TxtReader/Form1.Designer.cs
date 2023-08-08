
namespace TxtReader
{
    partial class Form1
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
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(4, 37);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(542, 593);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(471, 11);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(8, 11);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(454, 20);
            this.txtPath.TabIndex = 2;
            this.txtPath.Text = "C:\\Users\\H531731\\Downloads\\denis\\1\\test\\test\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 637);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txtContent);
            this.Name = "Form1";
            this.Text = "TxtReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txtPath;
    }
}

