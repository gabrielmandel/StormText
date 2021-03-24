using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StormText
{
    class Metodos
    {

        public void Novo(RichTextBox richTextBox)
        {
            richTextBox.Clear();
            richTextBox.Focus();
        }
        public void Abrir(OpenFileDialog openFileDialog, RichTextBox richTextBox)
        {
            openFileDialog.Title = "Abrir arquivo";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "(*.TXT)|*.TXT";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader leitor = new StreamReader(arquivo);

                    leitor.BaseStream.Seek(0, SeekOrigin.Begin);
                    richTextBox.Clear();
                    string linha = leitor.ReadLine();
                    while (linha != null)
                    {
                        richTextBox.Text += linha + "\n";
                        linha = leitor.ReadLine();
                    }

                    leitor.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de leitura" + ex.Message);
                }
            }
        }
        public void Salvar(SaveFileDialog saveFileDialog, RichTextBox richTextBox)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter escrever = new StreamWriter(arquivo);
                    escrever.Flush();
                    escrever.BaseStream.Seek(0, SeekOrigin.Begin);
                    escrever.Write(richTextBox.Text);
                    escrever.Flush();
                    escrever.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Imprimir(PrintDialog printDialog, PrintDocument printDocument, RichTextBox richTextBox )
        {
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        public void Copiar(RichTextBox richTextBox)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Copy();
            }
        }
        public void Colar(RichTextBox richTextBox)
        {
            richTextBox.Paste();
        }
        public void Negrito(RichTextBox richTextBox)
        {
            string fonte = richTextBox.Font.Name;
            float tamanho = richTextBox.Font.Size;
            bool n, s, i;
            n = richTextBox.SelectionFont.Bold;
            s = richTextBox.SelectionFont.Underline;
            i = richTextBox.SelectionFont.Italic;

            if (!richTextBox.SelectionFont.Bold)
            {
                if (s == true & i == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                }
                if (s == true & i == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Underline);
                }
                if (s == false & i == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Italic);
                }
                if (s == false & i == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold);
                }
            }
            else
            {
                if (s == true & i == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline | FontStyle.Italic);
                }
                if (s == true & i == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline);
                }
                if (s == false & i == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic);
                }
                if (s == false & i == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Regular);
                }
            }
        }
        public void Sublinhado(RichTextBox richTextBox)
        {
            string fonte = richTextBox.Font.Name;
            float tamanho = richTextBox.Font.Size;
            bool n, s, i;
            n = richTextBox.SelectionFont.Bold;
            s = richTextBox.SelectionFont.Underline;
            i = richTextBox.SelectionFont.Italic;


            if (!richTextBox.SelectionFont.Underline)
            {
                if (n == true & i == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                }
                if (n == true & i == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Underline);
                }
                if (n == false & i == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline | FontStyle.Italic);
                }
                if (n == false & i == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline);
                }
            }
            else
            {
                if (n == true & i == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Italic);
                }
                if (n == true & i == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold);
                }
                if (n == false & i == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic);
                }
                if (n == false & i == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Regular);
                }
            }
        }
        public void Italico(RichTextBox richTextBox)
        {
            string fonte = richTextBox.Font.Name;
            float tamanho = richTextBox.Font.Size;
            bool n, s, i;
            n = richTextBox.SelectionFont.Bold;
            s = richTextBox.SelectionFont.Underline;
            i = richTextBox.SelectionFont.Italic;


            if (!richTextBox.SelectionFont.Italic)
            {
                if (true)
                {

                }
                if (s == true & n == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                }
                if (s == true & n == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic | FontStyle.Underline);
                }
                if (s == false & n == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Italic);
                }
                if (s == false & n == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic);
                }
            }
            else
            {
                if (s == true & n == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline | FontStyle.Bold);
                }
                if (s == true & n == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline);
                }
                if (s == false & n == true)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold);
                }
                if (s == false & n == false)
                {
                    richTextBox.SelectionFont = new Font(fonte, tamanho, FontStyle.Regular);
                }
            }
        }
        public void AlinharEsq(RichTextBox richTextBox)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }
        public void AlinharDir(RichTextBox richTextBox)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }
        public void AlinharCent(RichTextBox richTextBox)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }
        
    }
}
