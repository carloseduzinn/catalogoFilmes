using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catalogoFilmes.View
{
    public partial class telademenu : Form
    {
        public telademenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teladeserie mostrar = new teladeserie();
            mostrar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCadastroFilme mostrarfilme = new TelaCadastroFilme();
            mostrarfilme.Show();
            this.Hide();
        }
    }
}
