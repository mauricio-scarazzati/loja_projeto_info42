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
    public partial class formCategoria : Form
    {
        public formCategoria()
        {
            InitializeComponent();
        }
        private void formCategoria_Load(object sender, EventArgs e)
        {
            txtDataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void Limpar()
        {
            {
                txtNomeCategoria.Clear();
                txtObservacao.Clear();
                txtNomeCategoria.Focus();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClassCategoria cCategoria = new ClassCategoria();


            if (txtNomeCategoria.Text != "")
            {
                cCategoria.nome = txtNomeCategoria.Text;
                cCategoria.observacao = txtObservacao.Text;


                int resp = cCategoria.CadastrarCategoria();

                if (resp == 1)
                {
                    MessageBox.Show("Categoria " + txtNomeCategoria.Text + " cadastrada com sucesso!", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Categoria!", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpar();
                }
            }
            else
            {
                MessageBox.Show("Verificar todos os campos Obrigatórios!", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCategoria.BackColor = Color.LemonChiffon;
                txtNomeCategoria.Focus();
            }
        }

       

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
