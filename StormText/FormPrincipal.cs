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

namespace StormText
{
    public partial class FormPrincipal : Form
    {
        StreamReader leitura = null;
        Metodos metodos = new Metodos();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void tsbtnNovo_Click(object sender, EventArgs e)
        {
            metodos.Novo(richTextBox1);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodos.Novo(richTextBox1);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            metodos.Salvar(this.saveFileDialog1, richTextBox1);
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodos.Salvar(this.saveFileDialog1, richTextBox1);
        }

        private void tsbtnAbrir_Click(object sender, EventArgs e)
        {
            metodos.Abrir(this.openFileDialog1, richTextBox1);
        }

        private void tsbtnCopiar_Click(object sender, EventArgs e)
        {
            metodos.Copiar(richTextBox1);
        }

        private void tsbtnColar_Click(object sender, EventArgs e)
        {
            metodos.Colar(richTextBox1);
        }

        private void tsbtnNegrito_Click(object sender, EventArgs e)
        {
           
            tsbtnNegrito.Checked = tsbtnNegrito.Checked ? false : true ;

            metodos.Negrito(richTextBox1);
        }

        private void tsbtnItalico_Click(object sender, EventArgs e)
        {
            tsbtnItalico.Checked = tsbtnItalico.Checked ? false : true;
            metodos.Italico(richTextBox1);
        }

        private void tsbtnSublinhado_Click(object sender, EventArgs e)
        {
            tsbtnSublinhado.Checked = tsbtnSublinhado.Checked ? false : true;
            metodos.Sublinhado(richTextBox1);
        }

        private void tsbtnAlinharEsq_Click(object sender, EventArgs e)
        {
            metodos.AlinharEsq(richTextBox1);
        }

        private void tsbtnAlinharDir_Click(object sender, EventArgs e)
        {
            metodos.AlinharDir(richTextBox1);

        }

        private void tsbtnCentralizar_Click(object sender, EventArgs e)
        {
            metodos.AlinharCent(richTextBox1);

        }

        private void tstnJustificar_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnImprimir_Click(object sender, EventArgs e)
        {
            metodos.Imprimir(printDialog1,printDocument1,richTextBox1);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPag = 0;
            float posY = 0;
            int cont = 0;
            float margemEsq = e.MarginBounds.Left - 50;
            float margemSup = e.MarginBounds.Top - 50;
            StringReader leitor = new StringReader(richTextBox1.Text);

            if (margemEsq < 5)
            {
                margemEsq = 20;
            }
            if (margemSup < 5)
            {
                margemSup = 20;
            }

            string linha = null;
            Font fonte = richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPag = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitor.ReadLine();

            while (cont < linhasPag)
            {
                posY = (margemSup + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemEsq, posY, new StringFormat());
                cont++;

                linha = leitor.ReadLine();
            }

            e.HasMorePages = linha != null ? true : false;
            pincel.Dispose();
        }
    }
}
