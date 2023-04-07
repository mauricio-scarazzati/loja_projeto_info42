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
    public partial class formConsultaFornecedor : Form
    {
        public formConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void gbCNPJ_Enter(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void formConsultaFornecedor_Load(object sender, EventArgs e)
        {
            //CARREGAR OPÇÕES DE BUSCA NA COMBO
            cbOpcoes.Items.Add("Estado");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.Items.Add("Razão Social");
            cbOpcoes.Items.Add("Nome Fantasia");
            cbOpcoes.Items.Add("CNPJ");
            cbOpcoes.Items.Add("Produto");

            //DEIXAR SELECIONADA A OPÇÃO NOME
            cbOpcoes.SelectedItem = "Status";


            cbEstado.Items.Add("SP");
            cbEstado.Items.Add("RJ");
            cbEstado.Items.Add("AC");
            cbEstado.Items.Add("MG");

            cbEstado.Sorted = true;
            cbEstado.SelectedItem = "SP";


            ClassFornecedor cFornecedor = new ClassFornecedor();
            cbTipoProduto.DataSource = cFornecedor.BuscarTipoProdutoFornecedor();
            //EXIBIR NA COMBO
            cbTipoProduto.DisplayMember = "tipo_produto";
            //GUARDAR NO BD
            cbTipoProduto.ValueMember = "tipo_produto";
            cbTipoProduto.SelectedIndex = -1;

        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HABILITAR/DESABILITAR ELEMENTOS DO FORM CONFORME OPÇÃO ESCOLHIDA PELO USUÁRIO
            if (cbOpcoes.SelectedIndex == 0) //ESTADO
            {
                gbEstado.Enabled = true;
                gbStatus.Enabled = false;
                gbRazaoSocial.Enabled = false;
                gbNomeFantasia.Enabled = false;
                gbTipoProduto.Enabled = false;
                gbCNPJ.Enabled = false;
                cbEstado.Focus();
            }

            if (cbOpcoes.SelectedIndex == 1) //STATUS
            {
                gbEstado.Enabled = false;
                gbStatus.Enabled = true;
                gbRazaoSocial.Enabled = false;
                gbNomeFantasia.Enabled = false;
                gbTipoProduto.Enabled = false;
                gbCNPJ.Enabled = false;
                rbAtivo.Focus();
                rbInativo.Focus();
            }

            if (cbOpcoes.SelectedIndex == 2) //RAZÃO SOCIAL
            {
                gbEstado.Enabled = false;
                gbStatus.Enabled = false;
                gbRazaoSocial.Enabled = true;
                gbNomeFantasia.Enabled = false;
                gbTipoProduto.Enabled = false;
                gbCNPJ.Enabled = false;
                txtRazaoSocial.Focus();
            }

            if (cbOpcoes.SelectedIndex == 3) //NOME FANTASIA
            {
                gbEstado.Enabled = false;
                gbStatus.Enabled = false;
                gbRazaoSocial.Enabled = false;
                gbNomeFantasia.Enabled = true;
                gbTipoProduto.Enabled = false;
                gbCNPJ.Enabled = false;
                txtNomeFantasia.Focus();
            }

            if (cbOpcoes.SelectedIndex == 4) //CNPJ
            {
                gbEstado.Enabled = false;
                gbStatus.Enabled = false;
                gbRazaoSocial.Enabled = false;
                gbNomeFantasia.Enabled = false;
                gbTipoProduto.Enabled = false;
                gbCNPJ.Enabled = true;
                cbTipoProduto.Focus();
            }

            if (cbOpcoes.SelectedIndex == 5) //PRODUTO
            {
                gbEstado.Enabled = false;
                gbStatus.Enabled = false;
                gbRazaoSocial.Enabled = false;
                gbNomeFantasia.Enabled = false;
                gbTipoProduto.Enabled = true;
                gbCNPJ.Enabled = false;
                mskCnpj.Focus();
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE FUNCIONARIO PARA USAR OS MÉTODOS DE CONSULTA
            ClassFornecedor cFornecedor = new ClassFornecedor();

            //VARIÁVEL QUE SERÁ UTILIZADO PELO SWITCH/CASE COM A ESCOLHA FEITA PELO USUÁRIO NA COMBO DE OPÇÕES
            string consulta = cbOpcoes.SelectedItem.ToString();

            //DECLARAR O SWITCH
            switch (consulta)
            {
                case "Estado":
                    //VERIFICAR SE O USUÁRIO PREENCHEU O NOME
                    if (cbEstado.SelectedIndex != -1)
                    {
                        
                            dgvFornecedor.DataSource = cFornecedor.PesquisarFornecedorPorEstado(Convert.ToString(cbEstado.SelectedItem));

                    }
                    else //VALIDAÇÃO DA CAIXINHA NOME
                    {
                        MessageBox.Show("Favor selecionar um Estado!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbEstado.Focus();
                    }
                    break;

                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        dgvFornecedor.DataSource = cFornecedor.PesquisarFornecedorPorStatus(1);
                    }
                    else
                    {
                        dgvFornecedor.DataSource = cFornecedor.PesquisarFornecedorPorStatus(0);
                    }
                        break;

                case "Razão Social":
                    if (txtRazaoSocial.Text != "")
                    {
                        dgvFornecedor.DataSource = cFornecedor.PesquisarFornecedorPorRazaoSocial(txtRazaoSocial.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor informar a Razão Social!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRazaoSocial.Focus();
                    }
                    break;

                case "Nome Fantasia":
                    if (txtNomeFantasia.Text != "")
                    {
                        dgvFornecedor.DataSource = cFornecedor.PesquisarFornecedorPorNomeFantasia(txtNomeFantasia.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor informar o Nome Fantasia!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNomeFantasia.Focus();
                    }
                    break;

                case "CNPJ":
                    if (mskCnpj.Text != "   .   .   / -")
                    {
                        dgvFornecedor.DataSource = cFornecedor.PesquisarFornecedorPorCnpj(mskCnpj.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor informar um CNPJ válido!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mskCnpj.Focus();
                    }
                    break;

                case "Produto":
                    if (cbTipoProduto.SelectedIndex != -1)
                    {
                        dgvFornecedor.DataSource = cFornecedor.PesquisarFornecedorPorProduto(Convert.ToString(cbTipoProduto.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor selecionar um Tipo de Produto!", "Sistema loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbTipoProduto.Focus();
                    }
                    break;

                
            }//FIM DO SWITCH
        }

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //PERGUNTAR SE DESEJA ALTERAR O FUNCIONARIO SELECIONADO
            if (MessageBox.Show("Deseja alterar o funcionário selecionado ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //INSTANCIAR A CLASSE FUNCIONÁRIO PARA USAR MÉTODOS E PROPRIEDADES
                ClassFornecedor cFornecedor = new ClassFornecedor();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO/ATUALIZAÇÃO DE FUNCIONÁRIO PARA OS CONTROLES DO FORM
                formFornecedor fFornecedor = new formFornecedor();

                //PEGAR O CÓDIGO DO FUNCIONÁRIO SELECIONADO PELO USUÁRIO NA GRID
                cFornecedor.ConsultaFornecedor(Convert.ToInt32(dgvFornecedor.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM DE FUNCIONÁRIO
                fFornecedor.txtCodigoFornecedor.Text = cFornecedor.codigo_fornecedor.ToString();
                fFornecedor.datacad = cFornecedor.data_cadastro;//PASSAR A VARIÁVEL DECLARADA NO FORM DE CADASTRO - DATA ARMAZENADA NO BD
                if (cFornecedor.status == 1)
                {
                    fFornecedor.cbStatus.Checked = true;
                }
                else
                {
                    fFornecedor.cbStatus.Checked = false;
                }
                fFornecedor.mskCnpj.Text = cFornecedor.CNPJ;
                fFornecedor.txtRazaoSocial.Text = cFornecedor.razao_social;
                fFornecedor.txtNomeFantasia.Text = cFornecedor.nome_fantasia;
                fFornecedor.produto = cFornecedor.tipo_produto;
                fFornecedor.mskTelefone.Text = cFornecedor.telefone;
                fFornecedor.txtEmail.Text = cFornecedor.email;
                fFornecedor.mskCep.Text = cFornecedor.CEP;
                fFornecedor.txtEndereco.Text = cFornecedor.endereco;
                fFornecedor.txtNumero.Text = cFornecedor.numero.ToString();
                fFornecedor.txtComplemento.Text = cFornecedor.complemento;
                fFornecedor.txtBairro.Text = cFornecedor.bairro;
                fFornecedor.txtCidade.Text = cFornecedor.cidade;
                fFornecedor.estado = cFornecedor.estado;//PASSAR A VARIÁVEL DECLARADA NO FORM DE CADASTRO - INFORMAÇÃO EXIBIDA EM COMBOBOX.

                //MANDAR A INFORMAÇÃO DE UPDATE PARA A VARIAVEL DO FORM DE CADASTRO
                fFornecedor.tipo = "Atualização";
                //ABRIR FORMULÁRIO DE CADASTRO PARA ATUALIZAÇÃO EM MODO EXCLUSIVO
                fFornecedor.ShowDialog();
                //CHAMAR MÉTODO DE PESQUISA
                btPesquisar_Click(this, new EventArgs());
            }
        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
