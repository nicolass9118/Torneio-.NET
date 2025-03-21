using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Torneio
{
    internal class Conexao
    {
        public MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=Torneio;User=root;pwd=");

        public string Conectar(){
            try 
            {
                con.Open();
                return "Conexão Realizada com sucesso";
            } 
            catch (MySqlException e)
            {
                return e.ToString();
            }
        }

        public string Desconectar(){
            try 
            {
                con.Close();
                return "Conexão encerrada";
            } 
            catch (MySqlException e) 
            {
                return e.ToString();
            }
        }
    }
}
