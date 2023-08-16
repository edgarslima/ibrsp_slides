using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBRSP_Slides
{
    public partial class frmScreen : Form
    {
        public frmScreen()
        {
            InitializeComponent();
        }

        private int numProporcao = 100;

        private string strDeviceName;
        public string DeviceName
        {
            get
            {
                return strDeviceName;
            }

            set
            {
                strDeviceName = value;
            }
        }

        private void posicionaLabel(Label label)
        {
            decimal numMedidaTop = Convert.ToDecimal(numProporcao) * 0.2m;

            label.Left = numProporcao * 1;
            label.Top = Convert.ToInt32(numMedidaTop);
            label.Height = imgFundo.Height - (numProporcao * 2);
            label.Width = imgFundo.Width - (numProporcao * 2);
            label.BackColor = Color.Transparent;

        }
        public void carregarSlide()
        {
            try
            {
                
                
                posicionaLabel(laSlide0);
                posicionaLabel(laSlide1);
                posicionaLabel(laSlide2);
                posicionaLabel(laSlide3);
                
                imgFundo.Controls.Add(laSlide0);
                laSlide0.BackColor = Color.Transparent;
                laSlide0.AutoSize = true;

                laSlide0.Height = 200;
                laSlide1.Height = 200;
                laSlide2.Height = 200;
                laSlide3.Height = 200;

                laSlide1.Top  = laSlide0.Top  + (laSlide0.Height / 2) + 60;

                laSlide2.Visible = false;
                laSlide3.Visible = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção!", "Erro ao carregar" + ex.Message);
            }
        }

        public void alteraTexto(string linha)
        {
            laSlide0.Text = "";
            laSlide1.Text = "";
            laSlide2.Text = "";
            laSlide3.Text = "";

            string[] linahs = linha.Split('\n');
            if (linahs.Length >= 1)
            {
                laSlide0.Text = linahs[0];
            }
            if (linahs.Length >= 2)
            {
                laSlide1.Text = linahs[1];
            }
            if (linahs.Length >= 3)
            {
                laSlide2.Text = linahs[2];
            }
            if (linahs.Length >= 4)
            {
                laSlide3.Text = linahs[3];
            }

            

        }
        public void alteraTamanhoTexto(long tamanho)
        {
            laSlide0.Font = new Font("Arial", tamanho);
            laSlide1.Font = new Font("Arial", tamanho);
            laSlide2.Font = new Font("Arial", tamanho);
            laSlide3.Font = new Font("Arial", tamanho);

        }

        public void alteraProporcao(int _proporcao)
        {
            numProporcao = _proporcao;
            carregarSlide();
        }
        private void imgFundo_Click(object sender, EventArgs e)
        {

        }

        private void frmScreen_Resize(object sender, EventArgs e)
        {
            carregarSlide();
        }
    }
}
