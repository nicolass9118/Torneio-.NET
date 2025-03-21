using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Torneio
{
    internal class Controle
    {
        Conexao conexao = new Conexao();

        public string Adicionar(string table, Dictionary<string, string> values)
        {
            try
            {
                string sql = $@"
                    insert into {table}({string.Join(", ", values.Keys)})
                        values ({string.Join(", ", values.Values)});";

                MySqlCommand cmd = new MySqlCommand(sql, conexao.con);

                conexao.Conectar();
                cmd.ExecuteNonQuery();  
                conexao.Desconectar();
                return "Cadastro realizado com sucesso!";
            }
            catch (MySqlException e) 
            {
                return e.ToString();
            }
        }

        public string Alterar(string table, Dictionary<string, string> values, string cond)
        {
            try
            {
                var a = from i in values select $"{i.Key} = {i.Value}";

                string sql = $@"
                    update {table} set
                        {string.Join(", ", a)}
                    where {cond}";

                MySqlCommand cmd = new MySqlCommand(sql, conexao.con);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                return "Cadastro Alterado com sucesso!";
            }
            catch (MySqlException e)
            {
                return e.ToString();
            }
        }

        public string Deletar(string table, string cond)
        {
            try
            {
                string sql = $@"
                    delete from {table} where {cond}";

                MySqlCommand cmd = new MySqlCommand(sql, conexao.con);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                return "Cadastro Excluído com sucesso!";
            }
            catch (MySqlException e)
            {
                return e.ToString();
            }
        }

        public DataTable Listar(string[] values, string table, string cond = "")
        {
            try
            {
                string sql = $@"
                    select {string.Join(", ", values)} from {table}";

                if (cond != "")
                {
                    sql += $" where {cond}";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conexao.con);
                DataTable dt = new DataTable();

                conexao.Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw e;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}


