using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_projeto_info42
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuCadastroMarca_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formMarca>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Marcas já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                formMarca fCadMarca = new formMarca();
                fCadMarca.MdiParent = this;
                fCadMarca.Show();
            }
        }

        private void menuCadastroFornecedor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formFornecedor>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Forncedor já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                formFornecedor fCadFornecedor = new formFornecedor();
                fCadFornecedor.MdiParent = this;
                fCadFornecedor.Show();
            }
        }

        private void menuCadastroCategoria_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formCategoria>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Categorias já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                formCategoria fCadCategoria = new formCategoria();
                fCadCategoria.MdiParent = this;
                fCadCategoria.Show();
            }
        }

        private void menuCadastroFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void menuCadastroProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Cadastro de Produtos já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                formProduto fCadProduto = new formProduto();
                fCadProduto.MdiParent = this;
                fCadProduto.Show();
            }
        }

        private void menuConsFornecedor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaFornecedor>().Count() > 0)
            {
                MessageBox.Show("O Formulário Consulta de Fornecedor já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                formConsultaFornecedor fConsFornecedor = new formConsultaFornecedor();
                fConsFornecedor.MdiParent = this;
                fConsFornecedor.Show();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaProduto>().Count() > 0)
            {
                MessageBox.Show("O Formulário Consulta de Produto já está aberto!",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                formConsultaProduto fConsProduto = new formConsultaProduto();
                fConsProduto.MdiParent = this;
                fConsProduto.Show();
            }
        }
    }
}
