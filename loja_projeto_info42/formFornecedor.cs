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
    public partial class formFornecedor : Form
    {
        public formFornecedor()
        {
            InitializeComponent();
        }

        //VARIÁVEL tipo: GUARDAR COMO O FORMULÁRIO DEVE SER ABERTO SE PARA CADASTRO OU ATUALIZAÇÃO/EXCLUSÃO
        //VARIÁVEL estado, estado_civil, cargo e setor: INFORMAÇÃO É MOSTRADA EM UMA COMBO
        public string tipo, estado, produto;
        //VARIÁVEL datacad: MOSTRAR INFORMAÇÃO GUARDADA NO BD E NÃO DATA ATUAL COMO PROGRAMADO NO LOAD DO FORM
        public DateTime datacad;
        private void formFornecedor_Load(object sender, EventArgs e)
        {
            lblDataAtual.Text = DateTime.Now.ToShortDateString();

           
            cbEstado.Items.Add("SP");
            cbEstado.Items.Add("RJ");
            cbEstado.Items.Add("AC");
            cbEstado.Items.Add("MG");

            cbEstado.Sorted = true;
            cbEstado.SelectedItem = "SP";

            //QUANDO ABRIR O FORMULÁRIO PARA ATUALIZAR/EXCLUIR
            if (tipo == "Atualização")
            {
                btnCadastrar.Enabled = false;
                cbStatus.Enabled = true;
                lblDataAtual.Text = datacad.ToString();
                cbEstado.SelectedItem = estado;
                txtTipoProduto.Text = produto;
            }
            else
            {
                btnAtualizar.Enabled = false;
                btnDeletar.Enabled = false;
            }


        }

        private void Limpar()
        {
            txtCodigoFornecedor.Clear();
            cbStatus.Checked = true;
            mskCnpj.Clear();
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            txtTipoProduto.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            mskCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbEstado.SelectedItem = "SP";
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
            ClassFornecedor cFornecedor = new ClassFornecedor();

            if (mskCnpj.Text != "  ,   ,   /    -" && txtRazaoSocial.Text != "" && txtTipoProduto.Text != "" && mskTelefone.Text != "(  )      -" && txtEmail.Text != "" && txtEndereco.Text != "" && txtNumero.Text != ""  && txtBairro.Text != "" && txtCidade.Text != "")
            {
                cFornecedor.CNPJ = mskCnpj.Text;
                cFornecedor.razao_social = txtRazaoSocial.Text;
                cFornecedor.nome_fantasia = txtNomeFantasia.Text;
                cFornecedor.tipo_produto = txtTipoProduto.Text;
                cFornecedor.telefone = mskTelefone.Text;
                cFornecedor.email = txtEmail.Text;
                if (mskCep.Text == "     -")
                {
                    cFornecedor.CEP = "";
                }
                else
                {
                    cFornecedor.CEP = mskCep.Text;
                }
                cFornecedor.endereco = txtEndereco.Text;
                cFornecedor.numero = Convert.ToInt32(txtNumero.Text);
                cFornecedor.complemento = txtComplemento.Text;
                cFornecedor.bairro = txtBairro.Text;
                cFornecedor.cidade = txtCidade.Text;
                cFornecedor.estado = cbEstado.SelectedItem.ToString();

                int resp = cFornecedor.CadastrarFornecedor();
                if (resp == 1)
                {
                    MessageBox.Show("Fornecedor Cadastrado com Sucesso", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LIMPAR OS CAMPOS
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Fornecedor", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar Campos Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //PINTAR OS CAMPOS OBRIGATÓRIOS
                mskCnpj.BackColor = Color.LemonChiffon;
                txtRazaoSocial.BackColor = Color.LemonChiffon;
                txtTipoProduto.BackColor = Color.LemonChiffon;
                mskTelefone.BackColor = Color.LemonChiffon;
                txtEmail.BackColor = Color.LemonChiffon;
                txtEndereco.BackColor = Color.LemonChiffon;
                txtNumero.BackColor = Color.LemonChiffon;
                txtBairro.BackColor = Color.LemonChiffon;
                txtCidade.BackColor = Color.LemonChiffon;
                cbEstado.BackColor = Color.LemonChiffon;
            }
            Limpar();


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
           
            ClassFornecedor cFornecedor = new ClassFornecedor();

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            //PREENCHER PELO MENOS 1 TELEFONE
            if (mskTelefone.Text != "(  )      -" && mskCnpj.Text != "  ,   ,   /    -" && txtRazaoSocial.Text != "" && txtNomeFantasia.Text != "" && txtTipoProduto.Text != "" && txtEmail.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && cbEstado.SelectedIndex != -1)
            {
              
                cFornecedor.razao_social = txtRazaoSocial.Text;
                cFornecedor.nome_fantasia = txtNomeFantasia.Text;
                cFornecedor.CNPJ = mskCnpj.Text;
                
                //MÁSCARA TELEFONE RESIDENCIAL
                if (mskTelefone.Text == "(  )      -")
                {
                    cFornecedor.telefone = "";
                }
                else
                {
                    cFornecedor.telefone = mskTelefone.Text;
                }
                cFornecedor.email = txtEmail.Text;
                //MÁSCARA CEP
                if (mskCep.Text == "  ,   -")
                {
                    cFornecedor.CEP = "";
                }
                else
                {
                    cFornecedor.CEP = mskCep.Text;
                }
                cFornecedor.endereco = txtEndereco.Text;
                cFornecedor.numero = Convert.ToInt32(txtNumero.Text);
                cFornecedor.complemento = txtComplemento.Text;
                cFornecedor.bairro = txtBairro.Text;
                cFornecedor.cidade = txtCidade.Text;
                cFornecedor.estado = cbEstado.SelectedItem.ToString();

                if (cbStatus.Checked == true)
                {
                    cFornecedor.status = 1;
                }
                else
                {
                    cFornecedor.status = 0;
                }


                cFornecedor.codigo_fornecedor = Convert.ToInt32(txtCodigoFornecedor.Text);
                cFornecedor.tipo_produto = txtTipoProduto.Text;
                cFornecedor.data_cadastro = Convert.ToDateTime(lblDataAtual.Text);
                //CHAMAR O MÉTODO CADASTRAR DA CLASSE FUNCIONÁRIO
                bool resp = cFornecedor.AtualizarFornecedor();
                //PEGAR A RESPOSTA DO MÉTODO CADASTRAR - SE RETORNAR 1 FOI CADASTRADO
                if (resp == true)
                {
                    MessageBox.Show("Fornecedor " + txtRazaoSocial.Text + " atualizado com sucesso!", "Sistema Loja Informática", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close();
                    //LIMPAR OS CAMPOS
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar Fornecedor", "Sistema Loja Informática", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar Campos Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //PINTAR OS CAMPOS OBRIGATÓRIOS
                mskCnpj.BackColor = Color.LemonChiffon;
                txtRazaoSocial.BackColor = Color.LemonChiffon;
                txtTipoProduto.BackColor = Color.LemonChiffon;
                mskTelefone.BackColor = Color.LemonChiffon;
                txtEmail.BackColor = Color.LemonChiffon;
                txtEndereco.BackColor = Color.LemonChiffon;
                txtNumero.BackColor = Color.LemonChiffon;
                txtBairro.BackColor = Color.LemonChiffon;
                txtCidade.BackColor = Color.LemonChiffon;
                cbEstado.BackColor = Color.LemonChiffon;
            }
        }


        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o fornecedor ?", "Sistema Loja de Cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClassFornecedor cFornecedor = new ClassFornecedor();
                cFornecedor.codigo_fornecedor = Convert.ToInt32(txtCodigoFornecedor.Text);
                bool resp = cFornecedor.DeletarFornecedor();
                if (resp == true)
                {
                    MessageBox.Show("Fornecedor " + txtRazaoSocial.Text + " excluído com sucesso!", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Fornecedor não pode ser excluído, pois existem registros em outras tabelas!", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
