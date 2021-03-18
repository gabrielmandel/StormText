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
    }
}
