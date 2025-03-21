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
    public partial class AdicionarJogador : Form
    {
        Controle controle = new Controle();

        public AdicionarJogador()
        {
            InitializeComponent();
        }

        private void AdicionarJogador_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controle.Listar(new string[] {"idClube", "nomeClube"}, "Clube");
                comboBoxClubeJogador.ValueMember = "idClube";
                comboBoxClubeJogador.DisplayMember = "nomeClube";
                comboBoxClubeJogador.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                {"nomeJogador", $"'{textBoxJogador.Text}'"},
                {"clubeJogador", $"{comboBoxClubeJogador.SelectedValue}"}
            };
            MessageBox.Show(controle.Adicionar("Jogador", values));
            textBoxJogador.Text = "";
            textBoxJogador.Focus();
        }
    }
}

 
