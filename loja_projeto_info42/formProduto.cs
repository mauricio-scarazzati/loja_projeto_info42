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
    public partial class formProduto : Form
    {
        public formProduto()
        {
            InitializeComponent();
        }

        //VARIÁVEL tipo: GUARDAR COMO O FORMULÁRIO DEVE SER ABERTO SE PARA CADASTRO OU ATUALIZAÇÃO/EXCLUSÃO
        //VARIÁVEL estado, estado_civil, cargo e setor: INFORMAÇÃO É MOSTRADA EM UMA COMBO
        public string tipo;
        public int margem_lucro, marca, categoria, fornecedor;
        //VARIÁVEL datacad: MOSTRAR INFORMAÇÃO GUARDADA NO BD E NÃO DATA ATUAL COMO PROGRAMADO NO LOAD DO FORM
        public DateTime datacad;
        private void formProduto_Load(object sender, EventArgs e)
        {
            lblDataCadastro.Text = DateTime.Now.ToShortDateString();


            ClassMarca cMarca = new ClassMarca();
            cbMarca.DataSource = cMarca.BuscarMarca();
            //EXIBIR NA COMBO
            cbMarca.DisplayMember = "nome";
            //GUARDAR NO BD
            cbMarca.ValueMember = "codigo_marca";
            cbMarca.SelectedIndex = -1;

            //CARREGAR COMBOBOX DO BD
            ClassCategoria cCategoria = new ClassCategoria();
            cbCategoria.DataSource = cCategoria.BuscarCategoria();
            //EXIBIR NA COMBO
            cbCategoria.DisplayMember = "nome";
            //GUARDAR NO BD
            cbCategoria.ValueMember = "codigo_categoria";
            cbCategoria.SelectedIndex = -1;


            //CARREGAR COMBOBOX DO BD
            ClassFornecedor cFornecedor = new ClassFornecedor();
            cbFornecedor.DataSource = cFornecedor.BuscarFornecedor();
            //EXIBIR NA COMBO
            cbFornecedor.DisplayMember = "razao_social";
            //GUARDAR NO BD
            cbFornecedor.ValueMember = "codigo_fornecedor";
            cbFornecedor.SelectedIndex = -1;


            if (tipo == "Atualização")
            {
                btnCadastrar.Enabled = false;
                cbStatus.Enabled = true;
                lblDataCadastro.Text = datacad.ToString();
                cbMarca.SelectedValue = marca;
                cbCategoria.SelectedValue = categoria;
                cbFornecedor.SelectedValue = fornecedor;
                txtMargemLucro.Text = Convert.ToString(margem_lucro);
                txtPrecoCusto.Text = Convert.ToString(preco_custo);
            }
            else
            {
                btnAtualizar.Enabled = false;
                btnDeletar.Enabled = false;
            }

        }

        private void Limpar()
        {
            txtCodigoProduto.Clear();
            cbStatus.Checked = true;
            txtNomeProduto.Clear();
            txtDescricao.Clear();
            txtPrecoCusto.Clear();
            txtMargemLucro.Clear();
            lblPrecoVenda.ResetText();
            txtQuantidade.Clear();
            cbMarca.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
            cbFornecedor.SelectedIndex = -1;
            txtObservacao.Clear();

        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClassProduto cProduto = new ClassProduto();

            if (txtNomeProduto.Text != "" && txtPrecoCusto.Text != "" && txtMargemLucro.Text != "" && txtQuantidade.Text != "" && cbCategoria.SelectedIndex != -1 && cbMarca.SelectedIndex != -1 && cbFornecedor.SelectedIndex != -1)
            {
                cProduto.nome = txtNomeProduto.Text;
                cProduto.descricao = txtDescricao.Text;
                cProduto.preco_custo = Convert.ToDecimal(txtPrecoCusto.Text);
                cProduto.margem_lucro = Convert.ToInt32(txtMargemLucro.Text);


                decimal preco_custo;
                decimal margem_lucro;
                decimal preco_venda;
                decimal preco_final;
                preco_custo = Convert.ToDecimal(txtPrecoCusto.Text);
                margem_lucro = Convert.ToDecimal(txtMargemLucro.Text);
                preco_venda = preco_custo * (margem_lucro / 100);
                preco_final = preco_venda + preco_custo;

                lblPrecoVenda.Text = Convert.ToString(preco_final);
                cProduto.preco_venda = preco_final;
                cProduto.quantidade = Convert.ToInt32(txtQuantidade.Text);
                cProduto.codigo_marca = Convert.ToInt32(cbMarca.SelectedValue);
                cProduto.codigo_categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                cProduto.codigo_fornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);

                cProduto.observacao = txtObservacao.Text;

                int resp = cProduto.CadastrarProduto();
                if (resp == 1)
                {
                    MessageBox.Show("Produto Cadastrado com Sucesso", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LIMPAR OS CAMPOS
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Produto", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar Campos Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //PINTAR OS CAMPOS OBRIGATÓRIOS
                txtNomeProduto.BackColor = Color.LemonChiffon;
                txtPrecoCusto.BackColor = Color.LemonChiffon;
                txtMargemLucro.BackColor = Color.LemonChiffon;
                txtQuantidade.BackColor = Color.LemonChiffon;
                cbMarca.BackColor = Color.LemonChiffon;
                cbCategoria.BackColor = Color.LemonChiffon;
                cbFornecedor.BackColor = Color.LemonChiffon;
            }
            Limpar();
        }

        private void txtMargemLucro_TextChanged(object sender, EventArgs e)
        {
            ClassProduto cProduto = new ClassProduto();
            lblPrecoVenda.Text = Convert.ToString(cProduto.preco_venda);
        }

    }
}
