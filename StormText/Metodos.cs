using System;
using System.Collections.Generic;
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

        public void Salvar(SaveFileDialog saveFileDialog, RichTextBox richTextBox)
        {
            try
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog.FileName,FileMode.OpenOrCreate, FileAccess.Write);
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
                MessageBox.Show("Erro ao gravar" + ex.Message, "Erro" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
