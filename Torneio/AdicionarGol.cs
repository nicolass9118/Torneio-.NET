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
    public partial class AdicionarGol : Form
    {
        Controle controle = new Controle();

        private int club;
        private int game;
        public int Club { set => club = value; }
        public int Game { set => game = value; }

        public AdicionarGol()
        {
            InitializeComponent();
        }

        private void AdicionarGol_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controle.Listar(new string[] {"idJogador", "nomeJogador"}, "Jogador", $"clubeJogador = {club}");
                comboBoxPlayer.ValueMember = "idJogador";
                comboBoxPlayer.DisplayMember = "nomeJogador";
                comboBoxPlayer.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAddGoal_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                {"jogadorGol", $"{comboBoxPlayer.SelectedValue}"},
                {"jogoGol", $"{game}"},
                {"tempoGol", $"{maskedTextBoxTime.Text}"}
            };
            MessageBox.Show(controle.Adicionar("Gol", values));
            Close();
        }
    }
}
