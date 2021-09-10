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
        private string stringConexao = @"Data Source=DESKTOP-8FOKHBA\SQLEXPRESS; initial catalog=inlock_games_tarde; user Id=sa; pwd=senai@132";
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
            List<JogoDomain> listaJogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string querySelectAll = @"SELECT ISNULL(idJogo, 0), 
                                          ISNULL(JOGOS.idEstudio, 0), 
                                          ISNULL(nomeEstudio, 'Não cadastrado'), 
                                          ISNULL(nomeJogo, 'Não cadastrado'), 
                                          ISNULL(descricao, 'Sem descrição'), ISNULL(dataLancamento, ''), 
                                          ISNULL(valor, 0)  FROM JOGOS 
                                          FULL OUTER JOIN ESTUDIO ON JOGOS.idEstudio = ESTUDIO.idEstudio";

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
                            valor = Convert.ToDouble(rdr[6].ToString().Replace("R$ ", ""))

                        };

                        listaJogos.Add(jogo);
                    }

                }

            }

            return listaJogos;
        }
    }
}