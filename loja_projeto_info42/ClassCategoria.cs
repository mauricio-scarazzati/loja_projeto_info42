using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace loja_projeto_info42
{
    class ClassCategoria
    {
        public ClassCategoria()
        {
            codigo_categoria = 0;
            data_cadastro = DateTime.Now;
            status = 0;
            nome = null;
            observacao = null;
        }

        //PROPRIEDADES

        public int codigo_categoria { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }

        public int CadastrarCategoria()
        {
            string query = " INSERT INTO categoria VALUES (0, now(), 1, '" + nome + "', '" + observacao + "') ";

            ClassConexao cConexao = new ClassConexao();

            return cConexao.ExecutaQuery(query);
        }

        public DataTable BuscarCategoria()
        {
            string query = "SELECT codigo_categoria, nome FROM categoria WHERE status = 1 ORDER BY nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }
    }
}
