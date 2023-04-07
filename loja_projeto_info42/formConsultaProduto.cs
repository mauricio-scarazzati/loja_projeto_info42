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
    public partial class formConsultaProduto : Form
    {
        public formConsultaProduto()
        {
            InitializeComponent();
        }

        private void formConsultaProduto_Load(object sender, EventArgs e)
        {
            {
                //CARREGAR OPÇÕES DE BUSCA NA COMBO
                cbOpcoes.Items.Add("Status");
                cbOpcoes.Items.Add("Nome");
                cbOpcoes.Items.Add("Preço de Custo");
                cbOpcoes.Items.Add("Preço de Venda");
                cbOpcoes.Items.Add("Margem de Lucro");
                cbOpcoes.Items.Add("Marca");
                cbOpcoes.Items.Add("Categoria");
                cbOpcoes.Items.Add("Fornecedor");

                //DEIXAR SELECIONADA A OPÇÃO NOME
                cbOpcoes.SelectedItem = "Status";

                ClassMarca cMarca = new ClassMarca();
                cbMarca.DataSource = cMarca.BuscarMarca();
                //EXIBIR NA COMBO
                cbMarca.DisplayMember = "nome";
                //GUARDAR NO BD
                cbMarca.ValueMember = "codigo_marca";
                cbMarca.SelectedIndex = -1;


                ClassCategoria cCategoria = new ClassCategoria();
                cbCategoria.DataSource = cCategoria.BuscarCategoria();
                //EXIBIR NA COMBO
                cbCategoria.DisplayMember = "nome";
                //GUARDAR NO BD
                cbCategoria.ValueMember = "codigo_categoria";
                cbCategoria.SelectedIndex = -1;


                ClassFornecedor cFornecedor = new ClassFornecedor();
                cbFornecedor.DataSource = cFornecedor.BuscarFornecedor();
                //EXIBIR NA COMBO
                cbFornecedor.DisplayMember = "razao_social";
                //GUARDAR NO BD
                cbFornecedor.ValueMember = "codigo_fornecedor";
                cbFornecedor.SelectedIndex = -1;

                ClassProduto cProduto = new ClassProduto();
                cbMargemLucro.DataSource = cProduto.BuscarMargemLucroProduto();
                //EXIBIR NA COMBO
                cbMargemLucro.DisplayMember = "margem_lucro";
                //GUARDAR NO BD
                cbMargemLucro.ValueMember = "margem_lucro";
                cbMargemLucro.SelectedIndex = -1;
            }
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HABILITAR/DESABILITAR ELEMENTOS DO FORM CONFORME OPÇÃO ESCOLHIDA PELO USUÁRIO
            if (cbOpcoes.SelectedIndex == 0) //STATUS
            {
                gbStatus.Enabled = true;
                gbNome.Enabled = false;
                gbMarca.Enabled = false;
                gbCategoria.Enabled = false;
                gbFornecedor.Enabled = false;
                gbMargemLucro.Enabled = false;
                gbPrecoCusto.Enabled = false;
                gbPrecoVenda.Enabled = false;

            }

            if (cbOpcoes.SelectedIndex == 1) //NOME
            {
                gbStatus.Enabled = false;
                gbNome.Enabled = true;
                gbMarca.Enabled = false;
                gbCategoria.Enabled = false;
                gbFornecedor.Enabled = false;
                gbMargemLucro.Enabled = false;
                gbPrecoCusto.Enabled = false;
                gbPrecoVenda.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 2) //PREÇO DE CUSTO
            {
                gbStatus.Enabled = false;
                gbNome.Enabled = false;
                gbMarca.Enabled = false;
                gbCategoria.Enabled = false;
                gbFornecedor.Enabled = false;
                gbMargemLucro.Enabled = false;
                gbPrecoCusto.Enabled = true;
                gbPrecoVenda.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 3) //PREÇO DE VENDA
            {
                gbStatus.Enabled = false;
                gbNome.Enabled = false;
                gbMarca.Enabled = false;
                gbCategoria.Enabled = false;
                gbFornecedor.Enabled = false;
                gbMargemLucro.Enabled = false;
                gbPrecoCusto.Enabled = false;
                gbPrecoVenda.Enabled = true;
            }

            if (cbOpcoes.SelectedIndex == 4) //MARGEM DE LUCRO
            {
                gbStatus.Enabled = false;
                gbNome.Enabled = false;
                gbMarca.Enabled = false;
                gbCategoria.Enabled = false;
                gbFornecedor.Enabled = false;
                gbMargemLucro.Enabled = true;
                gbPrecoCusto.Enabled = false;
                gbPrecoVenda.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 5) //MARCA
            {
                gbStatus.Enabled = false;
                gbNome.Enabled = false;
                gbMarca.Enabled = true;
                gbCategoria.Enabled = false;
                gbFornecedor.Enabled = false;
                gbMargemLucro.Enabled = false;
                gbPrecoCusto.Enabled = false;
                gbPrecoVenda.Enabled = false;
            }
            if (cbOpcoes.SelectedIndex == 6) //CATEGORIA
            {
                gbStatus.Enabled = false;
                gbNome.Enabled = false;
                gbMarca.Enabled = false;
                gbCategoria.Enabled = true;
                gbFornecedor.Enabled = false;
                gbMargemLucro.Enabled = false;
                gbPrecoCusto.Enabled = false;
                gbPrecoVenda.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 7) //FORNECEDOR
            {
                gbStatus.Enabled = false;
                gbNome.Enabled = false;
                gbMarca.Enabled = false;
                gbCategoria.Enabled = false;
                gbFornecedor.Enabled = true;
                gbMargemLucro.Enabled = false;
                gbPrecoCusto.Enabled = false;
                gbPrecoVenda.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE FUNCIONARIO PARA USAR OS MÉTODOS DE CONSULTA
            ClassProduto cProduto = new ClassProduto();

            //VARIÁVEL QUE SERÁ UTILIZADO PELO SWITCH/CASE COM A ESCOLHA FEITA PELO USUÁRIO NA COMBO DE OPÇÕES
            string consulta = cbOpcoes.SelectedItem.ToString();

            //DECLARAR O SWITCH
            switch (consulta)
            {
                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        dgvProduto.DataSource = cProduto.PesquisarProdutoPorStatus(1);
                    }
                    else
                    {
                        dgvProduto.DataSource = cProduto.PesquisarProdutoPorStatus(0);
                    }
                    break;



                case "Nome":
                    if (txtNome.Text != "")
                    {
                        dgvProduto.DataSource = cProduto.PesquisarProdutoPorNome(txtNome.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor informar o Nome!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                    }
                    break;


                case "Preço de Custo":
                    if (cbPrecoCusto.SelectedIndex != -1)
                    {
                        dgvProduto.DataSource = cProduto.PesquisarProdutoPorPrecoCusto(Convert.ToDecimal(cbPrecoCusto.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor informar o Preço de Custo!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbPrecoCusto.Focus();
                    }
                    break;

                case "Preço de Venda":
                    if (cbPrecoVenda.SelectedIndex != -1)
                    {
                        dgvProduto.DataSource = cProduto.PesquisarProdutoPorPrecoVenda(Convert.ToDecimal(cbPrecoCusto.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor informar o Preço de Venda!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbPrecoVenda.Focus();
                    }
                    break;

                case "Margem de Lucro":
                    if (cbMargemLucro.SelectedIndex != -1)
                    {
                        dgvProduto.DataSource = cProduto.PesquisarProdutoPorMargemLucro(Convert.ToInt32(cbMargemLucro.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor selecione a Margem de Lucro!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbMargemLucro.Focus();
                    }
                    break;

                case "Marca":
                    if (cbMarca.SelectedIndex != -1)
                    {
                        dgvProduto.DataSource = cProduto.PesquisarProdutoPorMarca(Convert.ToInt32(cbMarca.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor selecione uma Marca!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbMarca.Focus();
                    }
                    break;

                case "Categoria":
                    if (cbCategoria.SelectedIndex != -1)
                    {
                        dgvProduto.DataSource = cProduto.PesquisarProdutoPorCategoria(Convert.ToInt32(cbCategoria.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor selecione uma Categoria!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbCategoria.Focus();
                    }
                    break;

                case "Fornecedor":
                    if (cbFornecedor.SelectedIndex != -1)
                    {
                        dgvProduto.DataSource = cProduto.PesquisarProdutoPorFornecedor(Convert.ToInt32(cbFornecedor.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor selecione um Fornecedor!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbFornecedor.Focus();
                    }
                    break;

            }//FIM DO SWITCH
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //PERGUNTAR SE DESEJA ALTERAR O FUNCIONARIO SELECIONADO
            if (MessageBox.Show("Deseja alterar o produto selecionado ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //INSTANCIAR A CLASSE FUNCIONÁRIO PARA USAR MÉTODOS E PROPRIEDADES
                ClassProduto cProduto = new ClassProduto();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO/ATUALIZAÇÃO DE FUNCIONÁRIO PARA OS CONTROLES DO FORM
                formProduto fProduto = new formProduto();

                //PEGAR O CÓDIGO DO FUNCIONÁRIO SELECIONADO PELO USUÁRIO NA GRID
                cProduto.ConsultaProduto(Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM DE FUNCIONÁRIO
                fProduto.txtCodigoProduto.Text = cProduto.codigo_produto.ToString();
                fProduto.datacad = cProduto.data_cadastro;//PASSAR A VARIÁVEL DECLARADA NO FORM DE CADASTRO - DATA ARMAZENADA NO BD
                if (cProduto.status == 1)
                {
                    fProduto.cbStatus.Checked = true;
                }
                else
                {
                    fProduto.cbStatus.Checked = false;
                }
                fProduto.txtNomeProduto.Text = cProduto.nome;
                fProduto.txtDescricao.Text = cProduto.descricao;
                fProduto.preco_custo = cProduto.preco_custo;
                fProduto.margem_lucro = cProduto.margem_lucro;
                fProduto.lblPrecoVenda.Text = cProduto.preco_venda.ToString();
                fProduto.cbMarca.SelectedValue = cProduto.codigo_marca;
                fProduto.cbCategoria.SelectedValue = cProduto.codigo_categoria;
                fProduto.cbFornecedor.SelectedValue = cProduto.codigo_fornecedor;


                //MANDAR A INFORMAÇÃO DE UPDATE PARA A VARIAVEL DO FORM DE CADASTRO
                fProduto.tipo = "Atualização";
                //ABRIR FORMULÁRIO DE CADASTRO PARA ATUALIZAÇÃO EM MODO EXCLUSIVO
                fProduto.ShowDialog();
                //CHAMAR MÉTODO DE PESQUISA
                btPesquisar_Click(this, new EventArgs());
            }
        }
    }
}
