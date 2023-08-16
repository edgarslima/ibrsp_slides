
namespace IBRSP_Slides
{
    partial class frmSlide
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
            this.imagemSlide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagemSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemSlide
            // 
            this.imagemSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagemSlide.Location = new System.Drawing.Point(0, 0);
            this.imagemSlide.Name = "imagemSlide";
            this.imagemSlide.Size = new System.Drawing.Size(1101, 716);
            this.imagemSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemSlide.TabIndex = 0;
            this.imagemSlide.TabStop = false;
            // 
            // frmSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 716);
            this.Controls.Add(this.imagemSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSlide";
            ((System.ComponentModel.ISupportInitialize)(this.imagemSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemSlide;
    }
}