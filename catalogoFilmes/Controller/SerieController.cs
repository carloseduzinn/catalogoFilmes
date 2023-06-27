using catalogoFilmes.Model;
using catalogoFilmes.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogoFilmes.Controller
{
    internal class SerieController
    {
        public void CadastrarSerie()

        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("InserirS", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("nomeSerie", serie.NomeSerie);
                cmd.Parameters.AddWithValue("temporadas", serie.Temporadas);
                cmd.Parameters.AddWithValue("categoriaSerie", serie.CategoriaSerie);
                cmd.Parameters.AddWithValue("lancamento", serie.Lancamento);

                SqlParameter nv = cmd.Parameters.Add("@Id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Serie Cadastrado com sucesso, Deseja cadastrar outra serie ?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    teladeserie TelaSerie = new teladeserie();
                    TelaSerie.Show();

                    serie.NomeSerie = string.Empty;
                    serie.Temporadas = string.Empty;
                    serie.CategoriaSerie = string.Empty;
                    serie.Lancamento = string.Empty;
                    serie.RetornoSerie1 = string.Empty;
                }

                else
                {
                    serie.RetornoSerie1 = "s";
                   
                    return;
                }

            }
            catch (Exception)


            {
                throw;
            }

        }
    }
}
    

