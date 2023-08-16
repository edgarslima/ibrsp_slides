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
using System.Configuration;
using System.Drawing.Imaging;

namespace IBRSP_Slides
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private frmSlide formSlide;
        private List<string> linhasControle;
        private int intIndiceMonitor;

        int _width = Settings.WindowWidth;
        int _height = Settings.WindowHeight;
        int _tamanhoFonte = Settings.TamanhoFonte;
        float _espacoLinha = Settings.EspacoLinha;
        Boolean _letraMaiuscula = Settings.LetraMaiucscula;
        string _enderecoIP = Settings.EnderecoIP;
        int _portaIP = Settings.PortaIP;
        int _monitorExibicao = Settings.MonitorExibicao;
        string _pastaInicial = Settings.PastaInicial;
        int _tamanhoImagem = Settings.TamanhoImagem;
        float _EspacoSuperior = Settings.EspacoSuperior;
        string _imagemFundo = Settings.ImagemFundo;
        Boolean _online = false;
        Boolean _forceOnline = false;

        string textoAtualSlide = "";
        string nome_fonte = "Arial";

        private void enviarTextoWebSocket(string texto)
        {
            try
            {
                if (_online == false)
                {
                    return;
                }
                clsWebSocket objWebSocket = new clsWebSocket();
                string strRetWebSocket = "";
                if (objWebSocket.servidorOnline(tbEnderecoIP.Text, tbPorta.Text) == false)
                {
                    laInfoServidor.Text = "Servidor fora do ar...";
                    return;
                }
                laInfoServidor.Text = "Servidor encontrado.";
                strRetWebSocket = objWebSocket.enviaMensagem(texto, tbEnderecoIP.Text, tbPorta.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção!", "Erro ao enviar mensagem: " + ex.Message);
            }

        }

        private float buscaConfigResolucao()
        {
            float retResolucao = 0.5f;
            List<float> listaResolucao = new List<float> { 0.5f, 1f, 2f, 3f, 4f };
            if (comboTamanhoImagem.SelectedIndex > -1)
            {
                retResolucao = listaResolucao[comboTamanhoImagem.SelectedIndex];
            }
            return retResolucao;
        }
        private void alteraImagemSlide(string texto)
        {
            textoAtualSlide = texto;
            alteraImagemSlide();
        }
        private void alteraImagemSlide()
        {
            // float espaco_linha, float espaco_superior, string patch_image_fundo, float fator_resolucao

            int tamanho_fonte = Convert.ToInt32(numTamanhoFonte.Value);
            float espaco_linha = (float)numEspacoLinha.Value;
            float espaco_superior = (float)numEspacoSuperior.Value;
            string patch_image_fundo = tbImagemFundo.Text;
            float fator_resolucao = buscaConfigResolucao();
            clsImagemSlide objImagemSlide = new clsImagemSlide();

            Image imgGerada = objImagemSlide.geraImagem(textoAtualSlide, nome_fonte, tamanho_fonte, espaco_linha, espaco_superior, patch_image_fundo, fator_resolucao);
            imgFundo.Image = imgGerada;

            if (formSlide != null)
            {
                formSlide.AlteraImagemSlide(imgGerada);
            }


        }

        string[] GetLinesFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines;
        }

        private List<string> juntarLinhas(List<string> linhas)
        {
            List<string> retLinhas = new List<string> { };
            string strTemp = "";
            foreach (string str in linhas)
            {

                if (str.Length == 0)
                {
                    retLinhas.Add(strTemp);
                    strTemp = "";
                }
                else
                {
                    strTemp += str + "{[NEW_LINE]}";
                }

            }
            if (strTemp.Length > 0)
            {
                retLinhas.Add(strTemp);
            }
            return retLinhas;
        }

        private void carregarLetra(string arquivo)
        {
            lsLinhas.Items.Clear();
            string[] linhas = GetLinesFromFile(arquivo);
            List<string> linhasAgrupadas = juntarLinhas(linhas.ToList());
            linhasControle = new List<string> { };

            foreach (string str in linhasAgrupadas)
            {
                linhasControle.Add(str);
                lsLinhas.Items.Add(str.Replace("{[NEW_LINE]}", " - "));
            }
        }

        private void carregarFormPrincipal()
        {
            try
            {
 
                List<System.Windows.Forms.Screen> monitores = ScreenProperties.getAllScreens();

                foreach (System.Windows.Forms.Screen item in monitores)
                {
                    cbMonitor.Items.Add(item.DeviceName);
                }
                if (intIndiceMonitor >= 0 && cbMonitor.Items.Count > 1)
                {
                    cbMonitor.SelectedIndex = intIndiceMonitor;
                }
                if (monitores.Count == 1)
                {
                    cbMonitor.SelectedItem = monitores[0].DeviceName;
                }

                this.Height = this._height;
                this.Width = this._width;
                this.numTamanhoFonte.Value = this._tamanhoFonte;
                this.numEspacoLinha.Value = (decimal)this._espacoLinha;
                this.ckLetraMaiuscula.Checked = this._letraMaiuscula;
                this.tbEnderecoIP.Text = this._enderecoIP;
                this.tbPorta.Text = this._portaIP.ToString();
                this.cbMonitor.SelectedIndex = this._monitorExibicao;
                this.comboTamanhoImagem.SelectedIndex = this._tamanhoImagem;
                this.numEspacoSuperior.Value = (decimal)this._EspacoSuperior;
                this.tbImagemFundo.Text = (string)this._imagemFundo;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção!", "Erro ao iniciar programa: " + ex.Message);
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            carregarFormPrincipal();


        }


        private void cmdCarregar_Click(object sender, EventArgs e)
        {
            escolherPasta.Description = "Escolha a pasta das letras formato .txt";

            escolherPasta.SelectedPath = _pastaInicial;
            escolherPasta.ShowDialog();

            string pasta = escolherPasta.SelectedPath;
            if (Directory.Exists(pasta))
            {
                this._pastaInicial = pasta;
                string[] files = Directory.GetFiles(pasta, "*.txt");

                listArquivos.Items.Clear();
                foreach (string str in files)
                {
                    FileInfo file = new FileInfo(str);
                    ListViewItem item = listArquivos.Items.Add(file.FullName);
                    item.SubItems.Add(file.Name);
                }
            }
            listArquivos.Columns[1].Width = 300;

        }


        private void listArquivos_DoubleClick(object sender, EventArgs e)
        {
            if (listArquivos.SelectedItems.Count == 1)
            {
                carregarLetra(listArquivos.SelectedItems[0].Text);
            }
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            try
            {
                _online = true;
                formSlide = new frmSlide();
                formSlide.DeviceName = cbMonitor.SelectedText;
                alteraImagemSlide("");
                formSlide.Show();
                formSlide.Location = Screen.AllScreens[cbMonitor.SelectedIndex].WorkingArea.Location;
                formSlide.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção!", "Erro ao carregar o slide: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                _online = false;
                formSlide.Close();
                formSlide = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção!", "Erro ao carregar o slide: " + ex.Message);
            }
        }

        private void lsLinhas_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //laSlide.Parent = imgFundo;
                //laSlide.BackColor = Color.Transparent;
                string linha = this.linhasControle[lsLinhas.SelectedIndex];
                if (ckLetraMaiuscula.Checked == true)
                {
                    linha = linha.ToUpper();
                }
                //laSlide.Text = linha.Replace("{[NEW_LINE]}", Environment.NewLine);

                alteraImagemSlide(linha.Replace("{[NEW_LINE]}", Environment.NewLine));

                enviarTextoWebSocket(linha.Replace("{[NEW_LINE]}", "<br />"));
            }
            catch
            {
            }
        }

        private void numTamanhoFonte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                alteraImagemSlide();
            }
            catch
            {

            }
        }

        private void numProporcao_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                alteraImagemSlide();
            }
            catch
            {

            }
        }

        private void guardaConfiguracao()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["WindowWidth"].Value = this.Width.ToString();
                config.AppSettings.Settings["WindowHeight"].Value = this.Height.ToString();

                config.AppSettings.Settings["TamanhoFonte"].Value = this.numTamanhoFonte.Value.ToString();
                config.AppSettings.Settings["EspacoLinha"].Value = this.numEspacoLinha.Value.ToString();
                config.AppSettings.Settings["LetraMaiucscula"].Value = this.ckLetraMaiuscula.Checked.ToString();
                config.AppSettings.Settings["EnderecoIP"].Value = this.tbEnderecoIP.Text;
                config.AppSettings.Settings["PortaIP"].Value = this.tbPorta.Text;
                config.AppSettings.Settings["MonitorExibicao"].Value = this.cbMonitor.SelectedIndex.ToString();
                config.AppSettings.Settings["PastaInicial"].Value = this._pastaInicial;

                config.AppSettings.Settings["TamanhoImagem"].Value = this.comboTamanhoImagem.SelectedIndex.ToString();
                config.AppSettings.Settings["EspacoSuperior"].Value = this.numEspacoSuperior.Value.ToString();
                config.AppSettings.Settings["ImagemFundo"].Value = this.tbImagemFundo.Text;

                config.Save(ConfigurationSaveMode.Modified);
            }
            catch { }
        }
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            guardaConfiguracao();

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            guardaConfiguracao();
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 190)
            {
                try
                {
                    //laSlide.Parent = imgFundo;
                    //laSlide.BackColor = Color.Transparent;
                    string linha = "";
                    //laSlide.Text = linha.Replace("{[NEW_LINE]}", Environment.NewLine);
                    if (formSlide != null)
                    {
                        alteraImagemSlide(linha.Replace("{[NEW_LINE]}", Environment.NewLine));
                        // formSlide.alteraTexto(linha.Replace("{[NEW_LINE]}", Environment.NewLine));
                    }


                    enviarTextoWebSocket(linha.Replace("{[NEW_LINE]}", "<br />"));
                }
                catch
                {

                }

            }

        }

        private void numEspacoSuperior_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                alteraImagemSlide();
            }
            catch
            {

            }
        }

        private void comboTamanhoImagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                alteraImagemSlide();
            }
            catch
            {

            }
        }

        private void btnImagemFundo_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "PNG Files|*.png";
                openFileDialog.Title = "Selecione uma imagem PNG";

                // Mostra a caixa de diálogo para selecionar o arquivo.
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Verifica se o arquivo indicado existe.
                    if (System.IO.File.Exists(openFileDialog.FileName))
                    {
                        // Atribui a variável o caminho completo do arquivo selecionado.
                        string arquivoSelecionado = openFileDialog.FileName;
                        tbImagemFundo.Text = arquivoSelecionado;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção!", "Erro ao abrir arquivo: " + ex.Message);
            }
        }

        private void btnOnLine_Click(object sender, EventArgs e)
        {
            if (_forceOnline == true)
            {
                Font fontBotao = btnOnLine.Font;

            }
        }
    }
}
