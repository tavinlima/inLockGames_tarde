using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório JogoRepository
    /// </summary>
    interface IJogoRepository
    {
        /// <summary>
        /// Cadastra um novo jogo no sistema
        /// </summary>
        /// <param name="novoJogo">Objeto novoJogo com seus dados</param>
        void Cadastrar(JogoDomain novoJogo);

        /// <summary>
        /// Lista todos os jogos cadastrados
        /// </summary>
        /// <returns>Lista de todos os jogos cadastrados</returns>
        List<JogoDomain> ListarTodos();

        /// <summary>
        /// Atualiza um jogo cadastrado
        /// </summary>
        /// <param name="jogoAtualizado">Objeto jogoAtualizado com seus dados Atualizados</param>
        void AtualizarJogo(JogoDomain jogoAtualizado);

        /// <summary>
        /// Busca de um jogo por meio do seu Id
        /// </summary>
        /// <param name="idJogo">Id do jogo que será buscado</param>
        /// <returns>Um jogo buscado</returns>
        JogoDomain BuscarPorId(int idJogo);

        /// <summary>
        /// Deleta um jogo cadastrado
        /// </summary>
        /// <param name="idJogo">Id do jogo que será deletado</param>
        void Deletar(int idJogo);
    }
}
