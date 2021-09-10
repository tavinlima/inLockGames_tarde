using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private string stringConexao = @"Data Source=DESKTOP-QMET0P1\SQLEXPRESS; initial catalog=inlock_games_tarde; user Id=sa; pwd=123enzzo";
        public void AtualizarJogo(JogoDomain jogoAtualizado)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

            }
        }

        public JogoDomain BuscarPorId(int idJogo)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(JogoDomain novoJogo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

            }
        }

        public void Deletar(int idJogo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

            }
        }

        public List<JogoDomain> ListarTodos()
        {
<<<<<<< HEAD
            List<JogoDomain> listaJogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string querySelectAll = "SELECT   idJogo, ISNULL(JOGOS.idEstudio), nomeEstudio, nomeJogo, descricao, dataLancamento, valor  FROM JOGOS FULL OUTER JOIN ESTUDIO ON JOGOS.idEstudio = ESTUDIO.idEstudio";

                con.Open();
                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        JogoDomain jogo = new JogoDomain()
                        {

                            idJogo = Convert.ToInt32(rdr[0]),
                            idEstudio = Convert.ToInt32(rdr[1]),
                            estudio = new EstudioDomain()
                            {
                                idEstudio = Convert.ToInt32(rdr[1]),
                                nomeEstudio = rdr[2].ToString()

                            },
                            nomeJogo = rdr[3].ToString(),
                            descricao = rdr[4].ToString(),
                            dataLancamento = Convert.ToDateTime(rdr[5]),
                            valor = Convert.ToInt32(rdr[6])

                        };

                        listaJogos.Add(jogo);
                    }

                }

            }

            return listaJogos;
=======
            throw new NotImplementedException();
>>>>>>> 089c23fe163a6625a099cdaad4e108270b37dacb
        }
    }
}