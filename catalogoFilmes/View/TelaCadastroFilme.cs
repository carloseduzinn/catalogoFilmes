using catalogoFilmes.Controller;
using catalogoFilmes.Model;
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
    public partial class TelaCadastroFilme : Form
    {
        public TelaCadastroFilme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filme.NomeFilme = txboxfilme.Text;
            Filme.EstreiaFilme = txtestreia.Text;
            Filme.DuracaoFilme= txboxduracao.Text;
            Filme.CategoriaFilme = cboxcategoria.Text;

            FilmeController filmeController = new FilmeController();
            filmeController.CadastrarFilme();

            txboxfilme.Text = Filme.NomeFilme;
               txtestreia.Text = Filme.EstreiaFilme;
               txboxduracao.Text = Filme.DuracaoFilme;
               cboxcategoria.Text = Filme.CategoriaFilme;

            if (Filme. RetornoFilme == "f")
            {
                telademenu telademenul = new telademenu();
                telademenul.Show();
                this.Hide();
            }

        }
    }
}
