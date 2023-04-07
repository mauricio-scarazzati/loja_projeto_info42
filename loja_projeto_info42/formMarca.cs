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
    public partial class formMarca : Form
    {
        public formMarca()
        {
            InitializeComponent();
        }

        private void formMarca_Load(object sender, EventArgs e)
        {
            txtDataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void Limpar()
        {
            {
                txtNomeMarca.Clear();
                txtObservacao.Clear();
                txtNomeMarca.Focus();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClassMarca cMarca = new ClassMarca();


            if (txtNomeMarca.Text != "")
            {
                cMarca.nome = txtNomeMarca.Text;
                cMarca.observacao = txtObservacao.Text;


                int resp = cMarca.CadastrarMarca();

                if (resp == 1)
                {
                    MessageBox.Show("Marca " + txtNomeMarca.Text + " cadastrada com sucesso!", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Marca!", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpar();
                }
            }
            else
            {
                MessageBox.Show("Verificar todos os campos Obrigatórios!", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeMarca.BackColor = Color.LemonChiffon;
                txtNomeMarca.Focus();
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
