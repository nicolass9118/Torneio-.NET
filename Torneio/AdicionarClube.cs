using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Torneio
{
    public partial class AdicionarClube : Form
    {
        Controle controle = new Controle();

        public AdicionarClube()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                {"nomeClube", $"'{textBoxClube.Text}'"},
            };
            MessageBox.Show(controle.Adicionar("Clube", values));
            textBoxClube.Text = "";
            textBoxClube.Focus();
        }
    }
}
