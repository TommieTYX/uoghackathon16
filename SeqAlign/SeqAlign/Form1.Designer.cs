namespace SeqAlign
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
            this.resultsTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultsTb
            // 
            this.resultsTb.Location = new System.Drawing.Point(13, 13);
            this.resultsTb.Multiline = true;
            this.resultsTb.Name = "resultsTb";
            this.resultsTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultsTb.Size = new System.Drawing.Size(1110, 566);
            this.resultsTb.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 591);
            this.Controls.Add(this.resultsTb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultsTb;
    }
}

