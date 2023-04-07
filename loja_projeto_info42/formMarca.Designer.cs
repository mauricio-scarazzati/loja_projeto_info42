
namespace loja_projeto_info42
{
    partial class formMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigoMarca = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNomeMarca = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtCodigoMarca = new System.Windows.Forms.TextBox();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(332, 29);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(97, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Cadastro de Marca";
            // 
            // lblCodigoMarca
            // 
            this.lblCodigoMarca.AutoSize = true;
            this.lblCodigoMarca.Location = new System.Drawing.Point(71, 81);
            this.lblCodigoMarca.Name = "lblCodigoMarca";
            this.lblCodigoMarca.Size = new System.Drawing.Size(73, 13);
            this.lblCodigoMarca.TabIndex = 1;
            this.lblCodigoMarca.Text = "Código Marca";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(315, 81);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDataCadastro.TabIndex = 2;
            this.lblDataCadastro.Text = "Data Cadastro";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(605, 81);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // lblNomeMarca
            // 
            this.lblNomeMarca.AutoSize = true;
            this.lblNomeMarca.Location = new System.Drawing.Point(71, 244);
            this.lblNomeMarca.Name = "lblNomeMarca";
            this.lblNomeMarca.Size = new System.Drawing.Size(35, 13);
            this.lblNomeMarca.TabIndex = 4;
            this.lblNomeMarca.Text = "Nome";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(315, 244);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 5;
            this.lblObservacao.Text = "Observação";
            // 
            // txtCodigoMarca
            // 
            this.txtCodigoMarca.Enabled = false;
            this.txtCodigoMarca.Location = new System.Drawing.Point(74, 114);
            this.txtCodigoMarca.Name = "txtCodigoMarca";
            this.txtCodigoMarca.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoMarca.TabIndex = 6;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Location = new System.Drawing.Point(318, 114);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(72, 20);
            this.txtDataCadastro.TabIndex = 7;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Location = new System.Drawing.Point(608, 116);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(50, 17);
            this.cbStatus.TabIndex = 8;
            this.cbStatus.Text = "Ativo";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Location = new System.Drawing.Point(73, 291);
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(100, 20);
            this.txtNomeMarca.TabIndex = 9;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(318, 291);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(100, 20);
            this.txtObservacao.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(74, 380);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(245, 380);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // formMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtNomeMarca);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.txtCodigoMarca);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblNomeMarca);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblCodigoMarca);
            this.Controls.Add(this.lblMarca);
            this.Name = "formMarca";
            this.Text = "Cadastro de Marca";
            this.Load += new System.EventHandler(this.formMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigoMarca;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNomeMarca;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtCodigoMarca;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.TextBox txtNomeMarca;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSair;
    }
}