
namespace loja_projeto_info42
{
    partial class formPrincipal
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
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroSetor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroCargo,
            this.menuCadastroCategoria,
            this.menuCadastroCliente,
            this.menuCadastroFuncionario,
            this.menuCadastroMarca,
            this.menuCadastroProduto,
            this.menuCadastroSetor,
            this.menuCadastroFornecedor});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuCadastroCargo
            // 
            this.menuCadastroCargo.Name = "menuCadastroCargo";
            this.menuCadastroCargo.Size = new System.Drawing.Size(137, 22);
            this.menuCadastroCargo.Text = "Cargo";
            // 
            // menuCadastroCategoria
            // 
            this.menuCadastroCategoria.Name = "menuCadastroCategoria";
            this.menuCadastroCategoria.Size = new System.Drawing.Size(137, 22);
            this.menuCadastroCategoria.Text = "Categoria";
            this.menuCadastroCategoria.Click += new System.EventHandler(this.menuCadastroCategoria_Click);
            // 
            // menuCadastroCliente
            // 
            this.menuCadastroCliente.Name = "menuCadastroCliente";
            this.menuCadastroCliente.Size = new System.Drawing.Size(137, 22);
            this.menuCadastroCliente.Text = "Cliente";
            // 
            // menuCadastroFuncionario
            // 
            this.menuCadastroFuncionario.Name = "menuCadastroFuncionario";
            this.menuCadastroFuncionario.Size = new System.Drawing.Size(137, 22);
            this.menuCadastroFuncionario.Text = "Funcionário";
            this.menuCadastroFuncionario.Click += new System.EventHandler(this.menuCadastroFuncionario_Click);
            // 
            // menuCadastroMarca
            // 
            this.menuCadastroMarca.Name = "menuCadastroMarca";
            this.menuCadastroMarca.Size = new System.Drawing.Size(137, 22);
            this.menuCadastroMarca.Text = "Marca";
            this.menuCadastroMarca.Click += new System.EventHandler(this.menuCadastroMarca_Click);
            // 
            // menuCadastroProduto
            // 
            this.menuCadastroProduto.Name = "menuCadastroProduto";
            this.menuCadastroProduto.Size = new System.Drawing.Size(137, 22);
            this.menuCadastroProduto.Text = "Produto";
            this.menuCadastroProduto.Click += new System.EventHandler(this.menuCadastroProduto_Click);
            // 
            // menuCadastroSetor
            // 
            this.menuCadastroSetor.Name = "menuCadastroSetor";
            this.menuCadastroSetor.Size = new System.Drawing.Size(137, 22);
            this.menuCadastroSetor.Text = "Setor";
            // 
            // menuCadastroFornecedor
            // 
            this.menuCadastroFornecedor.Name = "menuCadastroFornecedor";
            this.menuCadastroFornecedor.Size = new System.Drawing.Size(137, 22);
            this.menuCadastroFornecedor.Text = "Fornecedor";
            this.menuCadastroFornecedor.Click += new System.EventHandler(this.menuCadastroFornecedor_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsFornecedor,
            this.produtoToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // menuConsFornecedor
            // 
            this.menuConsFornecedor.Name = "menuConsFornecedor";
            this.menuConsFornecedor.Size = new System.Drawing.Size(180, 22);
            this.menuConsFornecedor.Text = "Fornecedor";
            this.menuConsFornecedor.Click += new System.EventHandler(this.menuConsFornecedor_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(888, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 515);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPrincipal";
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroCargo;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroCategoria;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroMarca;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroSetor;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFornecedor;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuConsFornecedor;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
    }
}

