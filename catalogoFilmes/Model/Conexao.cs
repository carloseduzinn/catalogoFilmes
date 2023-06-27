using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogoFilmes.Model
{
    internal class Conexao
    {

        public static string Conectar() 
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlos.efspires\source\repos\catalogoFilmes\catalogoFilmes\Model\Filmesbd.mdf;Integrated Security=True";
        }
    }
}
