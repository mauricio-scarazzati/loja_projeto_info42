using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace loja_projeto_info42
{
    class ClassMarca
    {
        public ClassMarca()
        {
            codigo_marca = 0;
            nome = null;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        public int codigo_marca { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }



        public int CadastrarMarca()
        {
            string query = "INSERT INTO marca VALUES (0, now(), 1, '" + nome + "', '" + observacao + "' )";
            ClassConexao cConexao = new ClassConexao();
            return cConexao.ExecutaQuery(query);
        }

        public DataTable BuscarMarca()
        {
            string query = "SELECT * FROM marca WHERE status = 1 ORDER BY nome";

            ClassConexao cConexao = new ClassConexao();
            return cConexao.RetornaDataTable(query);

        }
    }
}
