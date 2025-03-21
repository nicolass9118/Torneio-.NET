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
    public partial class EditarJogador : Form
    {
        Controle controle = new Controle();
        private int id;
        public int Id { set => id = value; }

        public EditarJogador()
        {
            InitializeComponent();
        }

        private void EditarJogador_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controle.Listar(new string[] {"idClube", "nomeClube"}, "Clube");
                DataTable dt2 = controle.Listar(new string[] {"nomeJogador", "clubeJogador"}, "Jogador", $"idJogador = {id}");

                comboBoxClubeJogador.ValueMember = "idClube";
                comboBoxClubeJogador.DisplayMember = "nomeClube";
                comboBoxClubeJogador.DataSource = dt;

                textBoxJogador.Text = dt2.Rows[0].Field<string>("nomeJogador");
                comboBoxClubeJogador.SelectedValue = dt2.Rows[0].Field<int>("clubeJogador");
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
                {"nomeJogador", $"'{textBoxJogador.Text}'"},
                {"clubeJogador", $"{comboBoxClubeJogador.SelectedValue}"}
            };
            MessageBox.Show(controle.Alterar("Jogador", values, $"idJogador = {id}"));
            Close();
        }
    }
}
