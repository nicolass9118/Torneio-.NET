using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace Torneio
{
    public partial class FormMain : Form
    {
        Controle controle = new Controle();

        public FormMain()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            dataGridViewClubes.DataSource = controle.Listar(
                new string[] {
                    "idClube", 
                    "row_number() over(order by Pontos desc) as Posição", 
                    "nomeClube as Nome", 
                    "3*Vitorias(idClube) + Empates(idClube) as Pontos",
                    "(select count(*) from Jogo where clubeCasa = idClube or clubeFora = idClube) as Jogos",
                    "Vitorias(idClube) as Vitórias",
                    "Empates(idClube) as Empates",
                    "Derrotas(idClube) as Derrotas"
                }, 
                "Clube"
            );

            dataGridViewJogos.DataSource = controle.Listar(
                new string[] {
                    "idJogo", 
                    "(select nomeClube from Clube where idClube = clubeCasa) as Casa", 
                    "GolsCasa(idJogo) as 'Gols casa'",
                    "GolsFora(idJogo) as 'Gols fora'",
                    "(select nomeClube from Clube where idClube = clubeFora) as Fora"
                }, 
                "Jogo", 
                "true order by idJogo desc"
            );

            dataGridViewJogadores.DataSource = controle.Listar(
                new string[] {
                    "idJogador", 
                    "nomeJogador as Nome", 
                    "(select nomeClube from Clube where idClube = clubeJogador) as Clube",
                    "(select count(*) from Gol where jogadorGol = idJogador) as Gols"
                }, 
                "Jogador",
                "true order by Gols desc"
            );
            
            foreach (var item in new DataGridView[] {dataGridViewClubes, dataGridViewJogadores, dataGridViewJogos})
            {
                item.Columns[0].Visible = false;
                if (item.Rows.Count > 0)
                {
                    item.Rows[0].Cells[1].Selected = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MessageBox.Show(conexao.Conectar());
            Reload();
        }

        private void btnGameAdd_Click(object sender, EventArgs e)
        {  
            AdicionarJogo addJogo = new AdicionarJogo();
            addJogo.ShowDialog();
            Reload();
        }

        private void btnClubAdd_Click(object sender, EventArgs e)
        {
            AdicionarClube addClube = new AdicionarClube();
            addClube.ShowDialog();
            Reload();
        }

        private void btnPlayerAdd_Click(object sender, EventArgs e)
        {
            AdicionarJogador addJogador = new AdicionarJogador();
            addJogador.ShowDialog();
            Reload();
        }

        private void btnGameAlter_Click(object sender, EventArgs e)
        {
            var row = dataGridViewJogos.Rows[dataGridViewJogos.CurrentCell.RowIndex];
            EditarJogo editGame = new EditarJogo
            {
                Game = (int) row.Cells[0].Value
            };
            editGame.ShowDialog();
            Reload();
        }

        private void btnClubAlter_Click(object sender, EventArgs e)
        {
            var row = dataGridViewClubes.Rows[dataGridViewClubes.CurrentCell.RowIndex];
            EditarClube editClub = new EditarClube()
            {
                Id = (int) row.Cells[0].Value
            };
            editClub.ShowDialog();
            Reload();
        }

        private void btnPlayerAlter_Click(object sender, EventArgs e)
        {
            var row = dataGridViewJogadores.Rows[dataGridViewJogadores.CurrentCell.RowIndex];
            EditarJogador editPlayer = new EditarJogador()
            {
                Id = (int) row.Cells[0].Value
            };
            editPlayer.ShowDialog();
            Reload();
        }

        private void btnGameDel_Click(object sender, EventArgs e)
        {
            var id = dataGridViewJogos.Rows[dataGridViewJogos.CurrentCell.RowIndex].Cells[0].Value;
            controle.Deletar("Gol", $"jogoGol = {id}");
            MessageBox.Show(controle.Deletar("Jogo", $"idJogo = {id}"));
            Reload();
        }

        private void btnClubDel_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dataGridViewClubes.Rows[dataGridViewClubes.CurrentCell.RowIndex].Cells[0].Value;
                MessageBox.Show(controle.Deletar("Clube", $"idClube = {id}"));
                Reload();
            }
            catch
            {
                MessageBox.Show("Não foi possível deletar o clube");
            }
        }

        private void btnPlayerDel_Click(object sender, EventArgs e)
        {
            var id = dataGridViewJogadores.Rows[dataGridViewJogadores.CurrentCell.RowIndex].Cells[0].Value;
            controle.Deletar("Gol", $"jogadorGol = {id}");
            MessageBox.Show(controle.Deletar("Jogador", $"idJogador = {id}"));
            Reload();
        }
    }
}




