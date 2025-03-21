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
    public partial class EditarJogo : Form
    {
        private int game;
        private int clubeCasa;
        private int clubeFora;
        public int Game { set => game = value; }

        private Dictionary<Label, Button> goals = new Dictionary<Label, Button>();

        Controle controle = new Controle();

        public EditarJogo()
        {
            InitializeComponent();
        }

        private DataTable Reload() 
        {
            try
            {
                DataTable dt = controle.Listar(
                    new string[] {
                        "(select nomeClube from Clube where idClube = clubeCasa) as Casa", 
                        "(select nomeClube from Clube where idClube = clubeFora) as Fora", 
                        "clubeCasa", 
                        "clubeFora", 
                        "GolsCasa(idJogo) as GolsCasa", 
                        "GolsFora(idJogo) as GolsFora"
                    }, 
                    "Jogo",
                    $"idjogo = {game}"
                );

                DataTable goalsHome = controle.Listar(
                    new string[] 
                    {
                        "idGol",
                        "tempoGol", 
                        "(select nomeJogador from Jogador where idJogador = jogadorGol) as jogador"
                    }, 
                    "Gol", 
                    $"jogoGol = {game} and jogadorGol in (select idJogador from Jogador where clubeJogador = (select clubeCasa from Jogo where idJogo = {game})) order by tempoGol"
                );

                DataTable goalsAway = controle.Listar(
                    new string[] 
                    {
                        "idGol", 
                        "tempoGol", 
                        "(select nomeJogador from Jogador where idJogador = jogadorGol) as jogador"
                    }, 
                    "Gol", 
                    $"jogoGol = {game} and jogadorGol in (select idJogador from Jogador where clubeJogador = (select clubeFora from Jogo where idJogo = {game})) order by tempoGol"
                );

                int dh, da;
                dh = da = 200;

                foreach (var item in goals)
                {
                    Controls.Remove(item.Key);
                    Controls.Remove(item.Value);
                }

                foreach (DataRow row in goalsHome.Rows)
                {
                    Label label = new Label
                    {
                        Location = new Point(175, dh), 
                        Text = $"{row.Field<int>("tempoGol")}'  {row.Field<string>("jogador")}",
                        AutoSize = true,
                        ForeColor = Color.White,

                    };

                    Button btn = new Button
                    {
                        Location = new Point(135, dh-9),
                        Text = "-",
                        AutoSize = true,
                        Size = new Size(20, 20),
                        BackColor = Color.White,

                    };

                    btn.Click += new EventHandler((_, __) => {controle.Deletar("Gol", $"idGol = {row.Field<int>("idGol")}"); Reload();});
                    Controls.Add(label);
                    Controls.Add(btn);
                    goals.Add(label, btn);
                    dh += 20;
                }

                foreach (DataRow row in goalsAway.Rows)
                {
                    Label label = new Label
                    {
                        Location = new Point(720, da), 
                        Text = $"{row.Field<int>("tempoGol")}'  {row.Field<string>("jogador")}",
                        AutoSize = true,
                        ForeColor = Color.White,
                    };

                    Button btn = new Button
                    {
                        Location = new Point(680, da-9),
                        Text = "-",
                        AutoSize = true,
                        Size = new Size(20, 20),
                        BackColor = Color.White,
                    };

                    btn.Click += new EventHandler((_, __) => {controle.Deletar("Gol", $"idGol = {row.Field<int>("idGol")}"); Reload();});
                    Controls.Add(label);
                    Controls.Add(btn);
                    goals.Add(label, btn);
                    da += 20;
                }

                labelClubeCasa.Text = dt.Rows[0].Field<string>("Casa");
                labelClubeFora.Text = dt.Rows[0].Field<string>("Fora");
                labelGolCasa.Text = dt.Rows[0].Field<int>("GolsCasa").ToString();
                labelGolFora.Text = dt.Rows[0].Field<int>("GolsFora").ToString();

                return dt;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        private void EditarJogo_Load(object sender, EventArgs e)
        {
            DataTable dt = Reload();

            clubeCasa = dt.Rows[0].Field<int>("clubeCasa");
            clubeFora = dt.Rows[0].Field<int>("clubeFora");
        }

        private void buttonAddGoalH_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarGol addGoalH = new AdicionarGol
                {
                    Club = clubeCasa,
                    Game = game
                };
                addGoalH.ShowDialog();
                Reload();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAddGoalA_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarGol addGoalA = new AdicionarGol
                {
                    Club = clubeFora,
                    Game = game
                };
                addGoalA.ShowDialog();
                Reload();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}


