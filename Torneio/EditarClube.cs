using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Torneio
{
    public partial class EditarClube : Form
    {
        Controle controle = new Controle();
        private int id;
        public int Id { set => id = value; }

        public EditarClube()
        {
            InitializeComponent();
        }

        private void EditarClube_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controle.Listar(new string[] {"nomeClube"}, "Clube", $"idCLube = {id}");
                textBoxClube.Text = dt.Rows[0].Field<string>("nomeClube");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                {"nomeClube", $"'{textBoxClube.Text}'"},
            };
            MessageBox.Show(controle.Alterar("Clube", values, $"idClube = {id}"));
            Close();
        }
    }
}
