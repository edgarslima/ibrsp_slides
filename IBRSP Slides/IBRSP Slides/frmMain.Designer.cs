
namespace IBRSP_Slides
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.escolherPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lsLinhas = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.imgFundo = new System.Windows.Forms.PictureBox();
            this.btnImagemFundo = new System.Windows.Forms.Button();
            this.tbImagemFundo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numEspacoSuperior = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTamanhoImagem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckLetraMaiuscula = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numEspacoLinha = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numTamanhoFonte = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.listArquivos = new System.Windows.Forms.ListView();
            this.arquivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.laInfoServidor = new System.Windows.Forms.Label();
            this.cmdCarregar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSlide = new System.Windows.Forms.Button();
            this.tbPorta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEnderecoIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.laMonitor = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOnLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspacoSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspacoLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanhoFonte)).BeginInit();
            this.SuspendLayout();
            // 
            // escolherPasta
            // 
            this.escolherPasta.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.Location = new System.Drawing.Point(12, 12);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnOnLine);
            this.splitContainer4.Panel2.Controls.Add(this.laInfoServidor);
            this.splitContainer4.Panel2.Controls.Add(this.cmdCarregar);
            this.splitContainer4.Panel2.Controls.Add(this.btnFechar);
            this.splitContainer4.Panel2.Controls.Add(this.btnSlide);
            this.splitContainer4.Panel2.Controls.Add(this.tbPorta);
            this.splitContainer4.Panel2.Controls.Add(this.label4);
            this.splitContainer4.Panel2.Controls.Add(this.tbEnderecoIP);
            this.splitContainer4.Panel2.Controls.Add(this.label3);
            this.splitContainer4.Panel2.Controls.Add(this.cbMonitor);
            this.splitContainer4.Panel2.Controls.Add(this.laMonitor);
            this.splitContainer4.Panel2MinSize = 60;
            this.splitContainer4.Size = new System.Drawing.Size(942, 587);
            this.splitContainer4.SplitterDistance = 523;
            this.splitContainer4.TabIndex = 24;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.listArquivos);
            this.splitContainer3.Size = new System.Drawing.Size(942, 523);
            this.splitContainer3.SplitterDistance = 417;
            this.splitContainer3.TabIndex = 24;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsLinhas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(942, 417);
            this.splitContainer1.SplitterDistance = 471;
            this.splitContainer1.TabIndex = 23;
            // 
            // lsLinhas
            // 
            this.lsLinhas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsLinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsLinhas.FormattingEnabled = true;
            this.lsLinhas.ItemHeight = 16;
            this.lsLinhas.Location = new System.Drawing.Point(0, 0);
            this.lsLinhas.Name = "lsLinhas";
            this.lsLinhas.Size = new System.Drawing.Size(471, 417);
            this.lsLinhas.TabIndex = 3;
            this.lsLinhas.SelectedIndexChanged += new System.EventHandler(this.lsLinhas_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.imgFundo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnImagemFundo);
            this.splitContainer2.Panel2.Controls.Add(this.tbImagemFundo);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.numEspacoSuperior);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.comboTamanhoImagem);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.ckLetraMaiuscula);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.numEspacoLinha);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.numTamanhoFonte);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(467, 417);
            this.splitContainer2.SplitterDistance = 224;
            this.splitContainer2.TabIndex = 0;
            // 
            // imgFundo
            // 
            this.imgFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFundo.Image = global::IBRSP_Slides.imagens.fundo_ppt_musicas;
            this.imgFundo.Location = new System.Drawing.Point(0, 0);
            this.imgFundo.Name = "imgFundo";
            this.imgFundo.Size = new System.Drawing.Size(467, 224);
            this.imgFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFundo.TabIndex = 8;
            this.imgFundo.TabStop = false;
            // 
            // btnImagemFundo
            // 
            this.btnImagemFundo.Location = new System.Drawing.Point(348, 114);
            this.btnImagemFundo.Name = "btnImagemFundo";
            this.btnImagemFundo.Size = new System.Drawing.Size(28, 23);
            this.btnImagemFundo.TabIndex = 34;
            this.btnImagemFundo.Text = "...";
            this.btnImagemFundo.UseVisualStyleBackColor = true;
            this.btnImagemFundo.Click += new System.EventHandler(this.btnImagemFundo_Click);
            // 
            // tbImagemFundo
            // 
            this.tbImagemFundo.Location = new System.Drawing.Point(132, 115);
            this.tbImagemFundo.Name = "tbImagemFundo";
            this.tbImagemFundo.Size = new System.Drawing.Size(210, 20);
            this.tbImagemFundo.TabIndex = 33;
            this.tbImagemFundo.Text = "e:\\ibrsp\\fundo_ibrsp.png";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Imagem Fundo";
            // 
            // numEspacoSuperior
            // 
            this.numEspacoSuperior.DecimalPlaces = 1;
            this.numEspacoSuperior.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEspacoSuperior.Location = new System.Drawing.Point(132, 89);
            this.numEspacoSuperior.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numEspacoSuperior.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEspacoSuperior.Name = "numEspacoSuperior";
            this.numEspacoSuperior.Size = new System.Drawing.Size(244, 20);
            this.numEspacoSuperior.TabIndex = 31;
            this.numEspacoSuperior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEspacoSuperior.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numEspacoSuperior.ValueChanged += new System.EventHandler(this.numEspacoSuperior_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Espaçamento Superior";
            // 
            // comboTamanhoImagem
            // 
            this.comboTamanhoImagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTamanhoImagem.FormattingEnabled = true;
            this.comboTamanhoImagem.Items.AddRange(new object[] {
            "(960, 540) pixels",
            "(1920, 1080) pixels",
            "(3840, 2160) pixels",
            "(7680, 4320) pixels"});
            this.comboTamanhoImagem.Location = new System.Drawing.Point(132, 36);
            this.comboTamanhoImagem.Name = "comboTamanhoImagem";
            this.comboTamanhoImagem.Size = new System.Drawing.Size(244, 21);
            this.comboTamanhoImagem.TabIndex = 29;
            this.comboTamanhoImagem.SelectedIndexChanged += new System.EventHandler(this.comboTamanhoImagem_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tamanho Imagem";
            // 
            // ckLetraMaiuscula
            // 
            this.ckLetraMaiuscula.AutoSize = true;
            this.ckLetraMaiuscula.Checked = true;
            this.ckLetraMaiuscula.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckLetraMaiuscula.Location = new System.Drawing.Point(113, 164);
            this.ckLetraMaiuscula.Name = "ckLetraMaiuscula";
            this.ckLetraMaiuscula.Size = new System.Drawing.Size(43, 17);
            this.ckLetraMaiuscula.TabIndex = 27;
            this.ckLetraMaiuscula.Text = "Sim";
            this.ckLetraMaiuscula.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Letra Maiúscula";
            // 
            // numEspacoLinha
            // 
            this.numEspacoLinha.DecimalPlaces = 1;
            this.numEspacoLinha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEspacoLinha.Location = new System.Drawing.Point(132, 63);
            this.numEspacoLinha.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numEspacoLinha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEspacoLinha.Name = "numEspacoLinha";
            this.numEspacoLinha.Size = new System.Drawing.Size(244, 20);
            this.numEspacoLinha.TabIndex = 25;
            this.numEspacoLinha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEspacoLinha.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.numEspacoLinha.ValueChanged += new System.EventHandler(this.numProporcao_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Espaçamento Linha";
            // 
            // numTamanhoFonte
            // 
            this.numTamanhoFonte.Location = new System.Drawing.Point(132, 10);
            this.numTamanhoFonte.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numTamanhoFonte.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTamanhoFonte.Name = "numTamanhoFonte";
            this.numTamanhoFonte.Size = new System.Drawing.Size(244, 20);
            this.numTamanhoFonte.TabIndex = 23;
            this.numTamanhoFonte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTamanhoFonte.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numTamanhoFonte.ValueChanged += new System.EventHandler(this.numTamanhoFonte_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tamanho Fonte";
            // 
            // listArquivos
            // 
            this.listArquivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.arquivo,
            this.nome});
            this.listArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listArquivos.FullRowSelect = true;
            this.listArquivos.HideSelection = false;
            this.listArquivos.Location = new System.Drawing.Point(0, 0);
            this.listArquivos.Name = "listArquivos";
            this.listArquivos.Size = new System.Drawing.Size(942, 102);
            this.listArquivos.TabIndex = 6;
            this.listArquivos.UseCompatibleStateImageBehavior = false;
            this.listArquivos.View = System.Windows.Forms.View.Details;
            this.listArquivos.Click += new System.EventHandler(this.listArquivos_DoubleClick);
            // 
            // arquivo
            // 
            this.arquivo.Text = "Arquivo";
            this.arquivo.Width = 619;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            // 
            // laInfoServidor
            // 
            this.laInfoServidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.laInfoServidor.AutoSize = true;
            this.laInfoServidor.Location = new System.Drawing.Point(295, 34);
            this.laInfoServidor.Name = "laInfoServidor";
            this.laInfoServidor.Size = new System.Drawing.Size(0, 13);
            this.laInfoServidor.TabIndex = 29;
            // 
            // cmdCarregar
            // 
            this.cmdCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCarregar.Location = new System.Drawing.Point(867, 21);
            this.cmdCarregar.Name = "cmdCarregar";
            this.cmdCarregar.Size = new System.Drawing.Size(75, 23);
            this.cmdCarregar.TabIndex = 28;
            this.cmdCarregar.Text = "&Carregar";
            this.cmdCarregar.UseVisualStyleBackColor = true;
            this.cmdCarregar.Click += new System.EventHandler(this.cmdCarregar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(705, 21);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 27;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlide.Location = new System.Drawing.Point(786, 21);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(75, 23);
            this.btnSlide.TabIndex = 26;
            this.btnSlide.Text = "Slide";
            this.btnSlide.UseVisualStyleBackColor = true;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // tbPorta
            // 
            this.tbPorta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPorta.Location = new System.Drawing.Point(75, 31);
            this.tbPorta.Name = "tbPorta";
            this.tbPorta.Size = new System.Drawing.Size(193, 20);
            this.tbPorta.TabIndex = 25;
            this.tbPorta.Text = "8001";
            this.tbPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Porta ";
            // 
            // tbEnderecoIP
            // 
            this.tbEnderecoIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbEnderecoIP.Location = new System.Drawing.Point(75, 5);
            this.tbEnderecoIP.Name = "tbEnderecoIP";
            this.tbEnderecoIP.Size = new System.Drawing.Size(193, 20);
            this.tbEnderecoIP.TabIndex = 23;
            this.tbEnderecoIP.Text = "192.168.0.117";
            this.tbEnderecoIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Endereço IP";
            // 
            // cbMonitor
            // 
            this.cbMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(343, 5);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(193, 21);
            this.cbMonitor.TabIndex = 21;
            // 
            // laMonitor
            // 
            this.laMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.laMonitor.AutoSize = true;
            this.laMonitor.Location = new System.Drawing.Point(295, 9);
            this.laMonitor.Name = "laMonitor";
            this.laMonitor.Size = new System.Drawing.Size(42, 13);
            this.laMonitor.TabIndex = 20;
            this.laMonitor.Text = "Monitor";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnOnLine
            // 
            this.btnOnLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnLine.BackColor = System.Drawing.SystemColors.Control;
            this.btnOnLine.ForeColor = System.Drawing.Color.Green;
            this.btnOnLine.Location = new System.Drawing.Point(624, 21);
            this.btnOnLine.Name = "btnOnLine";
            this.btnOnLine.Size = new System.Drawing.Size(75, 23);
            this.btnOnLine.TabIndex = 30;
            this.btnOnLine.Text = "On Line";
            this.btnOnLine.UseVisualStyleBackColor = false;
            this.btnOnLine.Click += new System.EventHandler(this.btnOnLine_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 611);
            this.Controls.Add(this.splitContainer4);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(840, 650);
            this.Name = "frmMain";
            this.Text = "Slide IBRSP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspacoSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspacoLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanhoFonte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog escolherPasta;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lsLinhas;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox imgFundo;
        private System.Windows.Forms.CheckBox ckLetraMaiuscula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numEspacoLinha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTamanhoFonte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listArquivos;
        private System.Windows.Forms.ColumnHeader arquivo;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.Button cmdCarregar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSlide;
        private System.Windows.Forms.TextBox tbPorta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEnderecoIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMonitor;
        private System.Windows.Forms.Label laMonitor;
        private System.Windows.Forms.Label laInfoServidor;
        private System.Windows.Forms.ComboBox comboTamanhoImagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numEspacoSuperior;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImagemFundo;
        private System.Windows.Forms.TextBox tbImagemFundo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOnLine;
    }
}

