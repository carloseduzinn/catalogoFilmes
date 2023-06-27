using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogoFilmes.Model
{
    internal class serie
    {
        private static int id;
        private static string nomeSerie;
        private static string temporadas;
        private static string categoriaSerie;
        private static string lancamento;
        private static string RetornoSerie;

        public static int Id { get => id; set => id = value; }
        public static string NomeSerie { get => nomeSerie; set => nomeSerie = value; }
        public static string Temporadas { get => temporadas; set => temporadas = value; }
        public static string CategoriaSerie { get => categoriaSerie; set => categoriaSerie = value; }
        public static string Lancamento { get => lancamento; set => lancamento = value; }
        public static string RetornoSerie1 { get => RetornoSerie; set => RetornoSerie = value; }
    }
}
