using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace loja_projeto_info42
{
    class ClassProduto
    {
        public ClassProduto()
        {
            codigo_produto = 0;
            data_cadastro = DateTime.Now;
            status = 0;
            nome = null;
            descricao = null;
            preco_custo = 0;
            margem_lucro = 0;
            preco_venda = 0;
            quantidade = 0;
            codigo_marca = 0;
            codigo_categoria = 0;
            codigo_fornecedor = 0;
            observacao = null;
        }

        //PROPRIEDADES

        public int codigo_produto { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco_custo { get; set; }
        public int margem_lucro { get; set; }
        public decimal preco_venda { get; set; }
        public int quantidade { get; set; }
        public int codigo_marca { get; set; }
        public int codigo_categoria { get; set; }
        public int codigo_fornecedor { get; set; }
        public string observacao { get; set; }



        public int CadastrarProduto()
        {
            string query = "INSERT INTO produto VALUES (0, now(), 1, '" + nome + "', '" + descricao + "',  '"+ preco_custo.ToString().Replace(",",".") +"',"+ margem_lucro + " , '" + preco_venda.ToString().Replace(",",".") + "', " + quantidade + ", " + codigo_marca + ", " + codigo_categoria + ", " + codigo_fornecedor + ", '" + observacao + "')";


            ClassConexao cConexao = new ClassConexao();
            return cConexao.ExecutaQuery(query);

        }


        //PESQUISAR PRODUTO POR NOME
        public DataTable PesquisarProdutoPorNome(string nome)
        {
            string query = "SELECT produto.codigo_produto 'cod',produto.nome, produto.preco_custo, produto.margem_lucro, produto.preco_venda, produto.quantidade, categoria.nome, marca.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN fornecedor ON fornecedor.codigo_fornecedor = produto.codigo_fornecedor WHERE produto.nome LIKE '%" + nome + "%' AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }
        //PESQUISAR FORNECEDOR POR PREÇO DE CUSTO
        public DataTable PesquisarProdutoPorPrecoCusto(decimal preco_custo)
        {
            string query = "SELECT produto.codigo_produto 'cod',produto.nome, produto.preco_custo, produto.margem_lucro, produto.preco_venda, produto.quantidade, categoria.nome, marca.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN fornecedor ON fornecedor.codigo_fornecedor = produto.codigo_fornecedor WHERE produto.preco_custo = " + preco_custo + " AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }


        //PESQUISAR FORNECEDOR POR PREÇO DE VENDA
        public DataTable PesquisarProdutoPorPrecoVenda(decimal preco_venda)
        {
            string query = "SELECT produto.codigo_produto 'cod',produto.nome, produto.preco_custo, produto.margem_lucro, produto.preco_venda, produto.quantidade, categoria.nome, marca.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN fornecedor ON fornecedor.codigo_fornecedor = produto.codigo_fornecedor WHERE produto.preco_venda = " + preco_venda + " AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISAR FORNECEDOR POR MARGEM DE LUCRO
        public DataTable PesquisarProdutoPorMargemLucro(int margem_lucro)
        {
            string query = "SELECT produto.codigo_produto 'cod',produto.nome, produto.preco_custo, produto.margem_lucro, produto.preco_venda, produto.quantidade, categoria.nome, marca.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN fornecedor ON fornecedor.codigo_fornecedor = produto.codigo_fornecedor WHERE produto.margem_lucro = " + margem_lucro + " AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISAR FORNECEDOR POR MARCA
        public DataTable PesquisarProdutoPorMarca(int marca)
        {
            string query = "SELECT produto.codigo_produto 'cod',produto.nome, produto.preco_custo, produto.margem_lucro, produto.preco_venda, produto.quantidade, categoria.nome, marca.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN fornecedor ON fornecedor.codigo_fornecedor = produto.codigo_fornecedor WHERE produto.codigo_marca = " + marca + " AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISAR FORNECEDOR POR CATEGORIA
        public DataTable PesquisarProdutoPorCategoria(int categoria)
        {
            string query = "SELECT produto.codigo_produto 'cod',produto.nome, produto.preco_custo, produto.margem_lucro, produto.preco_venda, produto.quantidade, categoria.nome, marca.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN fornecedor ON fornecedor.codigo_fornecedor = produto.codigo_fornecedor WHERE produto.codigo_marca = " + categoria + " AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISAR FORNECEDOR POR CATEGORIA
        public DataTable PesquisarProdutoPorFornecedor(int fornecedor)
        {
            string query = "SELECT produto.codigo_produto 'cod',produto.nome, produto.preco_custo, produto.margem_lucro, produto.preco_venda, produto.quantidade, categoria.nome, marca.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN fornecedor ON fornecedor.codigo_fornecedor = produto.codigo_fornecedor WHERE produto.codigo_fornecedor = " + fornecedor + " AND produto.status = 1 ORDER BY produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }

        //PESQUISAR FORNECEDOR POR STATUS
        public DataTable PesquisarProdutoPorStatus(int status)
        {
            string query = "SELECT produto.codigo_produto 'cod',produto.nome, produto.preco_custo, produto.margem_lucro, produto.preco_venda, produto.quantidade, categoria.nome, marca.nome FROM produto JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN fornecedor ON fornecedor.codigo_fornecedor = produto.codigo_fornecedor WHERE produto.status = " + status + " ORDER BY produto.nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);
        }





        //MÉTODO PARA BUSCAR TODOS OS DADO DO BANCO QUANDO O USUÁRIO ESCOLHER O PRODUTO NA GRID PARA EDITAR
        public bool ConsultaProduto(int cod)

        {

            //EXIBIR TODOS DOS DADOS DO FUNCIONARIO ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM produto WHERE codigo_produto = " + cod + "";

            ClassConexao cConexao = new ClassConexao();

            //MONTAR O DATATABLE - RECEBER TODOS OS DADOS DO BANCO DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORMULARIO DE CADASTRO/ATUALIZAÇÃO DO FUNCIONÁRIO
            DataTable dt = cConexao.RetornaDataTable(query);

            //SE A CONSULTA DER CERTO
            if (dt.Rows.Count > 0)
            {
                codigo_produto = Convert.ToInt32(dt.Rows[0]["codigo_produto"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                descricao = Convert.ToString(dt.Rows[0]["descricao"]);
                preco_custo = Convert.ToDecimal(dt.Rows[0]["preco_custo"]);
                margem_lucro = Convert.ToInt32(dt.Rows[0]["margem_lucro"]);
                preco_venda = Convert.ToDecimal(dt.Rows[0]["preco_venda"]);
                quantidade = Convert.ToInt32(dt.Rows[0]["quantidade"]);
                codigo_marca = Convert.ToInt32(dt.Rows[0]["codigo_marca"]);
                codigo_categoria = Convert.ToInt32(dt.Rows[0]["codigo_categoria"]);
                codigo_fornecedor = Convert.ToInt32(dt.Rows[0]["codigo_fornecedor"]);
                observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                return true;
            }
            //SE A CONSULTA NÃO DER CERTO
            else
            {
                return false;
            }
        }


        //MÉTODO ATUALIZAR FUNCIONARIO
        public bool AtualizarProduto()
        {
            string query = "UPDATE produto SET status = " + status + ", nome = '" + nome + "', descricao = '" + descricao + "', preco_custo = " + preco_custo.ToString().Replace(",",".") + ", preco_venda = " + preco_venda.ToString().Replace(",",".") + ", margem_lucro = " + margem_lucro + " , quantidade = " + quantidade + ", codigo_marca = " + codigo_marca + ",codigo_categoria = " + codigo_categoria + ", codigo_fornecedor = " + codigo_fornecedor + " , observacao = '" + observacao + "' WHERE codigo_produto = " + codigo_produto + "";

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
            string query = "DELETE FROM produto WHERE codigo_produto = " + codigo_produto + "";

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

        public DataTable BuscarMargemLucroProduto()
        {
            string query = "SELECT margem_lucro FROM produto ORDER BY margem_lucro ASC";

            ClassConexao cConexao = new ClassConexao();

            return cConexao.RetornaDataTable(query);

        }
    }
}
