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
    public partial class teladeserie : Form
    {
        public teladeserie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serie.NomeSerie = txboxserie.Text;
            serie.Temporadas = comboBox1.Text;
            serie.CategoriaSerie = cboxcategoria.Text;
            serie.Lancamento = txboxlancamento.Text;

            SerieController TelaSerie = new SerieController();
            TelaSerie.CadastrarSerie();

            txboxserie.Text = serie.NomeSerie;
            comboBox1.Text = serie.Temporadas;
            txboxlancamento.Text = serie.CategoriaSerie;
            cboxcategoria.Text = serie.Lancamento;

            if (serie.RetornoSerie1 == "s")
            {
                telademenu telademenul = new telademenu();
                telademenul.Show();
                this.Hide();

            }

        }
    }
}