
namespace StormText
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnNovo = new FontAwesome.Sharp.IconToolStripButton();
            this.tsbtnAbrir = new FontAwesome.Sharp.IconToolStripButton();
            this.btn_salvar = new FontAwesome.Sharp.IconToolStripButton();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCopiar = new FontAwesome.Sharp.IconToolStripButton();
            this.tsbtnColar = new FontAwesome.Sharp.IconToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnNegrito = new FontAwesome.Sharp.IconToolStripButton();
            this.tsbtnItalico = new FontAwesome.Sharp.IconToolStripButton();
            this.tsbtnSublinhado = new FontAwesome.Sharp.IconToolStripButton();
            this.tsbtnFonte = new FontAwesome.Sharp.IconToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAlinharEsq = new FontAwesome.Sharp.IconToolStripButton();
            this.tsbtnAlinharDir = new FontAwesome.Sharp.IconToolStripButton();
            this.tsbtnCentralizar = new FontAwesome.Sharp.IconToolStripButton();
            this.tstnJustificar = new FontAwesome.Sharp.IconToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.italicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            // 
            // italicoToolStripMenuItem
            // 
            this.italicoToolStripMenuItem.Name = "italicoToolStripMenuItem";
            this.italicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.italicoToolStripMenuItem.Text = "Italico";
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem,
            this.justificarToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            // 
            // justificarToolStripMenuItem
            // 
            this.justificarToolStripMenuItem.Name = "justificarToolStripMenuItem";
            this.justificarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.justificarToolStripMenuItem.Text = "Justificar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNovo,
            this.tsbtnAbrir,
            this.btn_salvar,
            this.tsSeparator,
            this.tsbtnCopiar,
            this.tsbtnColar,
            this.tsSeparator2,
            this.tsbtnNegrito,
            this.tsbtnItalico,
            this.tsbtnSublinhado,
            this.tsbtnFonte,
            this.tsSeparator3,
            this.tsbtnAlinharEsq,
            this.tsbtnAlinharDir,
            this.tsbtnCentralizar,
            this.tstnJustificar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNovo
            // 
            this.tsbtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNovo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.tsbtnNovo.IconColor = System.Drawing.Color.Black;
            this.tsbtnNovo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnNovo.IconSize = 24;
            this.tsbtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNovo.Name = "tsbtnNovo";
            this.tsbtnNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNovo.Text = "Novo";
            this.tsbtnNovo.Click += new System.EventHandler(this.tsbtnNovo_Click);
            // 
            // tsbtnAbrir
            // 
            this.tsbtnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAbrir.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.tsbtnAbrir.IconColor = System.Drawing.Color.Black;
            this.tsbtnAbrir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAbrir.Name = "tsbtnAbrir";
            this.tsbtnAbrir.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAbrir.Text = "Abrir";
            // 
            // btn_salvar
            // 
            this.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_salvar.IconColor = System.Drawing.Color.Black;
            this.btn_salvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(23, 22);
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnCopiar
            // 
            this.tsbtnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCopiar.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.tsbtnCopiar.IconColor = System.Drawing.Color.Black;
            this.tsbtnCopiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopiar.Name = "tsbtnCopiar";
            this.tsbtnCopiar.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCopiar.Text = "Copiar";
            // 
            // tsbtnColar
            // 
            this.tsbtnColar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnColar.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.tsbtnColar.IconColor = System.Drawing.Color.Black;
            this.tsbtnColar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnColar.Name = "tsbtnColar";
            this.tsbtnColar.Size = new System.Drawing.Size(23, 22);
            this.tsbtnColar.Text = "Colar";
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnNegrito
            // 
            this.tsbtnNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNegrito.IconChar = FontAwesome.Sharp.IconChar.Bold;
            this.tsbtnNegrito.IconColor = System.Drawing.Color.Black;
            this.tsbtnNegrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNegrito.Name = "tsbtnNegrito";
            this.tsbtnNegrito.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNegrito.Text = "Negrito";
            // 
            // tsbtnItalico
            // 
            this.tsbtnItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnItalico.IconChar = FontAwesome.Sharp.IconChar.Italic;
            this.tsbtnItalico.IconColor = System.Drawing.Color.Black;
            this.tsbtnItalico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnItalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnItalico.Name = "tsbtnItalico";
            this.tsbtnItalico.Size = new System.Drawing.Size(23, 22);
            this.tsbtnItalico.Text = "Italico";
            // 
            // tsbtnSublinhado
            // 
            this.tsbtnSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSublinhado.IconChar = FontAwesome.Sharp.IconChar.Underline;
            this.tsbtnSublinhado.IconColor = System.Drawing.Color.Black;
            this.tsbtnSublinhado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSublinhado.Name = "tsbtnSublinhado";
            this.tsbtnSublinhado.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSublinhado.Text = "Sublinhado";
            // 
            // tsbtnFonte
            // 
            this.tsbtnFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFonte.IconChar = FontAwesome.Sharp.IconChar.Font;
            this.tsbtnFonte.IconColor = System.Drawing.Color.Black;
            this.tsbtnFonte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFonte.Name = "tsbtnFonte";
            this.tsbtnFonte.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFonte.Text = "Fonte";
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnAlinharEsq
            // 
            this.tsbtnAlinharEsq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAlinharEsq.IconChar = FontAwesome.Sharp.IconChar.AlignLeft;
            this.tsbtnAlinharEsq.IconColor = System.Drawing.Color.Black;
            this.tsbtnAlinharEsq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnAlinharEsq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAlinharEsq.Name = "tsbtnAlinharEsq";
            this.tsbtnAlinharEsq.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAlinharEsq.Text = "Alinhar a esquerda";
            // 
            // tsbtnAlinharDir
            // 
            this.tsbtnAlinharDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAlinharDir.IconChar = FontAwesome.Sharp.IconChar.AlignRight;
            this.tsbtnAlinharDir.IconColor = System.Drawing.Color.Black;
            this.tsbtnAlinharDir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnAlinharDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAlinharDir.Name = "tsbtnAlinharDir";
            this.tsbtnAlinharDir.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAlinharDir.Text = "Alinhar a direita";
            // 
            // tsbtnCentralizar
            // 
            this.tsbtnCentralizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCentralizar.IconChar = FontAwesome.Sharp.IconChar.AlignCenter;
            this.tsbtnCentralizar.IconColor = System.Drawing.Color.Black;
            this.tsbtnCentralizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tsbtnCentralizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCentralizar.Name = "tsbtnCentralizar";
            this.tsbtnCentralizar.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCentralizar.Text = "Centralizar";
            // 
            // tstnJustificar
            // 
            this.tstnJustificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstnJustificar.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.tstnJustificar.IconColor = System.Drawing.Color.Black;
            this.tstnJustificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tstnJustificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstnJustificar.Name = "tstnJustificar";
            this.tstnJustificar.Size = new System.Drawing.Size(23, 22);
            this.tstnJustificar.Text = "Justificar";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 401);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "StormText";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justificarToolStripMenuItem;
        private FontAwesome.Sharp.IconToolStripButton tsbtnNovo;
        private FontAwesome.Sharp.IconToolStripButton tsbtnAbrir;
        private FontAwesome.Sharp.IconToolStripButton btn_salvar;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private FontAwesome.Sharp.IconToolStripButton tsbtnCopiar;
        private FontAwesome.Sharp.IconToolStripButton tsbtnColar;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private FontAwesome.Sharp.IconToolStripButton tsbtnNegrito;
        private FontAwesome.Sharp.IconToolStripButton tsbtnItalico;
        private FontAwesome.Sharp.IconToolStripButton tsbtnSublinhado;
        private FontAwesome.Sharp.IconToolStripButton tsbtnFonte;
        private System.Windows.Forms.ToolStripSeparator tsSeparator3;
        private FontAwesome.Sharp.IconToolStripButton tsbtnAlinharEsq;
        private FontAwesome.Sharp.IconToolStripButton tsbtnAlinharDir;
        private FontAwesome.Sharp.IconToolStripButton tsbtnCentralizar;
        private FontAwesome.Sharp.IconToolStripButton tstnJustificar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

