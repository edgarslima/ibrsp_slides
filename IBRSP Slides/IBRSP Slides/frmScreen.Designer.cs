
namespace IBRSP_Slides
{
    partial class frmScreen
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
            this.imgFundo = new System.Windows.Forms.PictureBox();
            this.laSlide0 = new System.Windows.Forms.Label();
            this.laSlide1 = new System.Windows.Forms.Label();
            this.laSlide2 = new System.Windows.Forms.Label();
            this.laSlide3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFundo
            // 
            this.imgFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFundo.Image = global::IBRSP_Slides.imagens.fundo_ppt_musicas;
            this.imgFundo.Location = new System.Drawing.Point(0, 0);
            this.imgFundo.Name = "imgFundo";
            this.imgFundo.Size = new System.Drawing.Size(1156, 716);
            this.imgFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFundo.TabIndex = 0;
            this.imgFundo.TabStop = false;
            this.imgFundo.Click += new System.EventHandler(this.imgFundo_Click);
            // 
            // laSlide0
            // 
            this.laSlide0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laSlide0.Font = new System.Drawing.Font("Arial Narrow", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSlide0.Location = new System.Drawing.Point(12, 9);
            this.laSlide0.Name = "laSlide0";
            this.laSlide0.Size = new System.Drawing.Size(1132, 141);
            this.laSlide0.TabIndex = 2;
            this.laSlide0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laSlide1
            // 
            this.laSlide1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laSlide1.Font = new System.Drawing.Font("Arial Narrow", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSlide1.Location = new System.Drawing.Point(12, 150);
            this.laSlide1.Name = "laSlide1";
            this.laSlide1.Size = new System.Drawing.Size(1132, 141);
            this.laSlide1.TabIndex = 3;
            this.laSlide1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laSlide2
            // 
            this.laSlide2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laSlide2.Font = new System.Drawing.Font("Arial Narrow", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSlide2.Location = new System.Drawing.Point(12, 288);
            this.laSlide2.Name = "laSlide2";
            this.laSlide2.Size = new System.Drawing.Size(1132, 141);
            this.laSlide2.TabIndex = 4;
            this.laSlide2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laSlide3
            // 
            this.laSlide3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laSlide3.Font = new System.Drawing.Font("Arial Narrow", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSlide3.Location = new System.Drawing.Point(12, 429);
            this.laSlide3.Name = "laSlide3";
            this.laSlide3.Size = new System.Drawing.Size(1132, 141);
            this.laSlide3.TabIndex = 5;
            this.laSlide3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 716);
            this.ControlBox = false;
            this.Controls.Add(this.laSlide3);
            this.Controls.Add(this.laSlide2);
            this.Controls.Add(this.laSlide1);
            this.Controls.Add(this.laSlide0);
            this.Controls.Add(this.imgFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmScreen";
            this.Resize += new System.EventHandler(this.frmScreen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFundo;
        private System.Windows.Forms.Label laSlide0;
        private System.Windows.Forms.Label laSlide1;
        private System.Windows.Forms.Label laSlide2;
        private System.Windows.Forms.Label laSlide3;
    }
}