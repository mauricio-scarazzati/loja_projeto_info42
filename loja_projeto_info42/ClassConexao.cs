using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace loja_projeto_info42
{
    class ClassConexao
    {
        private MySqlConnection c;

        private MySqlCommand cmd;

        private MySqlDataAdapter mDataAdapter;

        private string erros;

        public ClassConexao()
        {
            this.c = new MySqlConnection();
            this.cmd = null;
            this.mDataAdapter = null;
            erros = null;
        }

        public string ComandoErro
        {
            get { return erros; }
        }

        private void Conectar()
        {
            
            string conex = @"Persist Security Info=False; Server = localhost; Database = loja_projeto_info42; uid=root; pwd= ''";

             
            if (this.c.State == ConnectionState.Closed || this.c.State == ConnectionState.Broken)
            {
                
                this.c.ConnectionString = conex;
                 
                this.c.Open();
            }
        }

        private void Desconectar()
        {
            if (this.c.State == ConnectionState.Open)
            {
                this.c.Dispose();
                this.c.Close();
            }
        }

        public int ExecutaQuery(string query)
        {
            try
            {
                
                Conectar();

               
                this.cmd = new MySqlCommand();
                this.cmd.Connection = this.c;
                this.cmd.CommandText = query;
                this.cmd.CommandType = CommandType.Text;

                
                int resp = this.cmd.ExecuteNonQuery();

                Desconectar();
                return resp;
            }
            catch (MySqlException sqlex)
            {
                erros = sqlex.Message;
                Desconectar();
                return 0;
            }
        }

        public DataTable RetornaDataTable(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                this.cmd = new MySqlCommand(query, this.c);
                this.cmd.CommandType = CommandType.Text;
                this.mDataAdapter = new MySqlDataAdapter(this.cmd);

                Conectar();
                this.mDataAdapter.Fill(dt);
                this.mDataAdapter.Dispose();
                Desconectar();
                return dt;
            }
            catch (MySqlException sqlex)
            {
                erros = sqlex.Message;
                Desconectar();
                return null;
            }
        }

       
        public int ExecutaQueryID(string query)
        {
            try
            {
                int aux = 0;
                Conectar();

                this.cmd = new MySqlCommand(query, this.c);
               
                aux = Convert.ToInt32(cmd.ExecuteScalar());

                Desconectar();
                return aux;
            }
            catch (MySqlException sqlex)
            {
                erros = sqlex.Message;
                Desconectar();
                return 0;
            }
        }

    }

}
