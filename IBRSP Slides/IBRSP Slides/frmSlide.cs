using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace IBRSP_Slides
{
    public partial class frmSlide : Form
    {
        public frmSlide()
        {
            InitializeComponent();
        }

        public string DeviceName { get; set; }

        public void AlteraImagemSlide(Image imgSlide)
        {
            imagemSlide.Image = imgSlide;
        }
    }
}
