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
    public partial class AdicionarJogo : Form
    {
        Controle controle = new Controle();

        public AdicionarJogo()
        {
            InitializeComponent();
        }

        private void AdicionarJogo_Load(object sender, EventArgs e)
        {
            try
            {  
                foreach (var item in new ComboBox[] {comboBoxClubeCasa, comboBoxClubeFora})
                {
                    DataTable dt = controle.Listar(new string[] {"idClube", "nomeClube"}, "Clube");
                    item.ValueMember = "idClube";
                    item.DisplayMember = "nomeClube";
                    item.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            { 
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!comboBoxClubeCasa.SelectedValue.Equals(comboBoxClubeFora.SelectedValue))
            {
                Dictionary<string, string> values = new Dictionary<string, string>
                {
                    {"clubeCasa", $"{comboBoxClubeCasa.SelectedValue}"},
                    {"clubeFora", $"{comboBoxClubeFora.SelectedValue}"}
                };


                MessageBox.Show(controle.Adicionar("Jogo", values));
                Close();
            }
            else
            {
                MessageBox.Show("Você não pode inserir um jogo entre os mesmos clubes");
            }  
        }
    }
}
