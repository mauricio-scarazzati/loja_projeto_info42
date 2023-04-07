using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace loja_projeto_info42
{
    class ClassFornecedor
    {
        public ClassFornecedor()
        {
            codigo_fornecedor = 0;
            data_cadastro = DateTime.Now;
            status = 0;
            CNPJ = null;
            razao_social = null;
            nome_fantasia = null;
            tipo_produto = null;
            telefone = null;
            email = null;
            CEP = null;
            endereco = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
        }


            //PROPRIEDADES 

        public int codigo_fornecedor { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }
        public string CNPJ { get; set; }
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public string tipo_produto { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string CEP { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }



        //MÉTODO

        public int CadastrarFornecedor()
        {
            string query = "INSERT INTO fornecedor VALUES (0, now(), 1, '"+ CNPJ.Replace(",", ".") + "', '"+ razao_social +"', '"+ nome_fantasia +"', '"+ tipo_produto+"', '"+ telefone +"', '"+ email +"', '"+ CEP.Replace(",", ".") + "', '"+ endereco +"', '"+ numero +"', '"+ complemento +"', '"+ bairro +"', '"+ cidade +"', '"+ estado +"')";


            ClassConexao cConexao = new ClassConexao();
            return cConexao.ExecutaQuery(query);

        }
        public DataTable BuscarFornecedor()
        {
            string query = "SELECT codigo_fornecedor, razao_social FROM `fornecedor` WHERE status =1 ORDER BY razao_social;";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }


        //PESQUISAR FORNECEDOR POR STATUS
        public DataTable PesquisarFornecedorPorStatus(int status)
        {
            string query = "SELECT fornecedor.codigo_fornecedor 'cod', fornecedor.CNPJ, fornecedor.razao_social, fornecedor.nome_fantasia, fornecedor.tipo_produto, fornecedor.telefone, fornecedor.email FROM fornecedor WHERE fornecedor.status = " + status + " ORDER BY fornecedor.razao_social";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }
        //PESQUISAR FORNECEDOR POR ESTADO
        public DataTable PesquisarFornecedorPorEstado(string estado)
        {
            string query = "SELECT fornecedor.codigo_fornecedor 'cod', fornecedor.CNPJ, fornecedor.razao_social, fornecedor.nome_fantasia, fornecedor.tipo_produto, fornecedor.telefone, fornecedor.email FROM fornecedor WHERE fornecedor.estado = '" + estado + "' AND fornecedor.status = 1 ORDER BY fornecedor.razao_social";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }


        //PESQUISAR FORNECEDOR POR RAZÃO SOCIAL
        public DataTable PesquisarFornecedorPorRazaoSocial(string razao_social)
        {
            string query = "SELECT fornecedor.codigo_fornecedor 'cod', fornecedor.CNPJ, fornecedor.razao_social, fornecedor.nome_fantasia, fornecedor.tipo_produto, fornecedor.telefone, fornecedor.email FROM fornecedor WHERE fornecedor.razao_social LIKE '%" + razao_social + "%' AND fornecedor.status = 1 ORDER BY fornecedor.razao_social";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISAR FORNECEDOR POR NOME FANTASIA
        public DataTable PesquisarFornecedorPorNomeFantasia(string nome_fantasia)
        {
            string query = "SELECT fornecedor.codigo_fornecedor 'cod', fornecedor.CNPJ, fornecedor.razao_social, fornecedor.nome_fantasia, fornecedor.tipo_produto, fornecedor.telefone, fornecedor.email FROM fornecedor WHERE fornecedor.nome_fantasia  LIKE '%" + nome_fantasia + "%'  AND fornecedor.status = 1 ORDER BY fornecedor.razao_social";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISAR FORNECEDOR POR CNPJ
        public DataTable PesquisarFornecedorPorCnpj(string cnpj)
        {
            string query = "SELECT fornecedor.codigo_fornecedor 'cod', fornecedor.CNPJ, fornecedor.razao_social, fornecedor.nome_fantasia, fornecedor.tipo_produto, fornecedor.telefone, fornecedor.email FROM fornecedor WHERE fornecedor.CNPJ = '" + cnpj + "' AND fornecedor.status = 1 ORDER BY fornecedor.razao_social";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISAR FORNECEDOR POR TIPO DO PRODUTO
        public DataTable PesquisarFornecedorPorProduto(string produto)
        {
            string query = "SELECT fornecedor.codigo_fornecedor 'cod', fornecedor.CNPJ, fornecedor.razao_social, fornecedor.nome_fantasia, fornecedor.tipo_produto, fornecedor.telefone, fornecedor.email FROM fornecedor WHERE fornecedor.tipo_produto = '" + produto + "' AND fornecedor.status = 1 ORDER BY fornecedor.razao_social";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }



        //MÉTODO PARA BUSCAR TODOS OS DADO DO BANCO QUANDO O USUÁRIO ESCOLHER O FUNCIONÁRIO NA GRID PARA EDITAR
        public bool ConsultaFornecedor(int cod)

        {

            //EXIBIR TODOS DOS DADOS DO FUNCIONARIO ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM fornecedor WHERE codigo_fornecedor = " + cod + "";

            ClassConexao cConexao = new ClassConexao();

            //MONTAR O DATATABLE - RECEBER TODOS OS DADOS DO BANCO DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORMULARIO DE CADASTRO/ATUALIZAÇÃO DO FUNCIONÁRIO
            DataTable dt = cConexao.RetornaDataTable(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                codigo_fornecedor = Convert.ToInt32(dt.Rows[0]["codigo_fornecedor"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                CNPJ = Convert.ToString(dt.Rows[0]["CNPJ"]);
                razao_social = Convert.ToString(dt.Rows[0]["razao_social"]);
                nome_fantasia = Convert.ToString(dt.Rows[0]["nome_fantasia"]);
                tipo_produto = Convert.ToString(dt.Rows[0]["tipo_produto"]);
                telefone = Convert.ToString(dt.Rows[0]["telefone"]);
                email = Convert.ToString(dt.Rows[0]["email"]);
                CEP = Convert.ToString(dt.Rows[0]["CEP"]);
                endereco = Convert.ToString(dt.Rows[0]["endereco"]);
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = Convert.ToString(dt.Rows[0]["complemento"]);
                bairro = Convert.ToString(dt.Rows[0]["bairro"]);
                cidade = Convert.ToString(dt.Rows[0]["cidade"]);
                estado = Convert.ToString(dt.Rows[0]["estado"]);

                return true;
            }
            //SE A CONSULTA NÃO DER CERTO
            else
            {
                return false;
            }
        }

        //MÉTODO ATUALIZAR FUNCIONARIO
        public bool AtualizarFornecedor()
        {
            string query = "UPDATE fornecedor SET status = " + status + ", CNPJ = '" + CNPJ.Replace(",", ".") + "', razao_social = '" + razao_social + "', nome_fantasia = '"+ nome_fantasia +"', tipo_produto = '" + tipo_produto + "', telefone = '" + telefone + "', email = '" + email + "' , CEP = '" + CEP + "', endereco = '" + endereco + "', numero = " + numero + ", complemento = '" + complemento + "' , bairro ='" + bairro + "', cidade = '" + cidade + "', estado = '" + estado + "' WHERE codigo_fornecedor = " + codigo_fornecedor + "";

            ClassConexao cConexao = new ClassConexao();

            int resp = cConexao.ExecutaQuery(query);
            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //MÉTODO DELETAR FUNCIONARIO
        public bool DeletarFornecedor()
        {
            string query = "DELETE FROM fornecedor WHERE codigo_fornecedor = " + codigo_fornecedor + "";

            ClassConexao cConexao = new ClassConexao();

            int resp = cConexao.ExecutaQuery(query);
            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataTable BuscarTipoProdutoFornecedor()
        {
            string query = "SELECT * FROM fornecedor  ORDER BY tipo_produto";

            ClassConexao cConexao = new ClassConexao();

            return cConexao.RetornaDataTable(query);
            
        }
    }

}
