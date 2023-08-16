using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace IBRSP_Slides
{
    class clsImagemSlide
    {

        private string[] MeasureStringAndSplit(string text, Graphics g, Font font, int maxWidth, float lineSpacing)
        {
            // Medir a largura da frase
            var size = g.MeasureString(text, font);

            if (size.Width <= maxWidth)
            {
                return new[] { text };
            }

            var words = text.Split(' ');
            var lines = new List<string>();
            var currentLine = "";

            foreach (var word in words)
            {
                var line = currentLine + word + " ";
                var lineSize = g.MeasureString(line, font);

                if (lineSize.Width > maxWidth)
                {
                    lines.Add(currentLine.TrimEnd());
                    currentLine = word + " ";
                }
                else
                {
                    currentLine = line;
                }
            }

            if (!string.IsNullOrWhiteSpace(currentLine))
            {
                lines.Add(currentLine.TrimEnd());
            }

            return lines.ToArray();
        }

        public Bitmap geraImagem(string texto, string nome_fonte, int tamanho_fonte, float espaco_linha, float espaco_superior, string patch_image_fundo, float fator_resolucao)
        {
            texto = texto.ToUpper();
            int largura = (int)Math.Round(1920.0f * fator_resolucao);
            int altura = (int)Math.Round(1080.0f * fator_resolucao);

            using (Bitmap bitmap = new Bitmap(largura, altura))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Carregue a imagem de fundo
                    Image background = Image.FromFile(patch_image_fundo);

                    // Desenhe a imagem de fundo na imagem Bitmap
                    g.DrawImage(background, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

                    // Defina a fonte e o tamanho do texto
                    Font font = new Font(nome_fonte, tamanho_fonte * 2);

                    // Defina a cor do texto
                    Brush brush = new SolidBrush(Color.Black);

                    texto = texto.Replace("\r", "");
                    string[] textoLinhas = texto.Split('\n');
                    List<string> linesList = new List<string>();
                    for (int i = 0; i < textoLinhas.Length; i++)
                    {
                        string[] lines_ = MeasureStringAndSplit(textoLinhas[i], g, font, bitmap.Width, 3.5f);
                        for (int y = 0; y < lines_.Length; y++)
                        {
                            linesList.Add(lines_[y].ToString());
                        }

                    }
                    string[] lines = new string[linesList.Count];
                    for (int i = 0; i < linesList.Count; i++)
                    {
                        lines[i] = linesList[i];
                    }
                    // Defina a frase e converta todas as letras para maíusculas


                    // Defina a largura máxima do texto
                    float maxWidth = bitmap.Width - (font.Size * 2);

                    // Quebra o texto em várias linhas
                    /*
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Trimming = StringTrimming.Character;
                    stringFormat.FormatFlags = StringFormatFlags.LineLimit;
                    */
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;

                    RectangleF rect = new RectangleF(0, 0, maxWidth, bitmap.Height);

                    //g.DrawString(text, font, brush, rect, stringFormat);

                    for (int i = 0; i < lines.Length; i++)
                    {

                        g.DrawString(lines[i], font, Brushes.Black, new RectangleF(0, (i) * font.Size * espaco_linha, bitmap.Width, font.Size * espaco_superior), stringFormat);
                    }


                    // Salve a imagem Bitmap
                    //bitmap.Save("e:\\ibrsp\\saida.png", ImageFormat.Jpeg);
                    return (Bitmap)bitmap.Clone();
                }
            }

        }

        public Image GeraImagemSlide(string texto, string nome_fonte, int tamanho_fonte, float espaco_linha, float espaco_superior, string patch_image_fundo, float fator_resolucao)
        {

            Bitmap bitmap = geraImagem(texto, nome_fonte, tamanho_fonte, espaco_linha, espaco_superior, patch_image_fundo, fator_resolucao);


            using (var memory = new MemoryStream())
            {
                Image imgReturn;
                using (var cloneBitmap = new Bitmap(bitmap.Width, bitmap.Height))
                {
                    using (var g = Graphics.FromImage(cloneBitmap))
                    {
                        g.DrawImage(bitmap, new Point());
                        cloneBitmap.Save(memory, ImageFormat.Jpeg);
                        memory.Position = 0;
                        imgReturn = Image.FromStream(memory);
                    }
                }
                return imgReturn;
            }

        }

    }
}
