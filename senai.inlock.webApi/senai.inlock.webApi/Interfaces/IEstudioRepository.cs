using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório EstudioRepository
    /// </summary>
    interface IEstudioRepository
    {
        /// <summary>
        /// Cadastra um novo estúdio no sistema
        /// </summary>
        /// <param name="novoEstudio">Objeto no</param>
        void Cadastrar(EstudioDomain novoEstudio);

        /// <summary>
        /// Lista todos os estúdios cadastrados
        /// </summary>
        /// <returns>Uma lista de todos os estúdios cadastrados</returns>
        List<EstudioDomain> ListarTodos();

        /// <summary>
        /// Atualiza um estúdio cadastrado
        /// </summary>
        /// <param name="estudioAtualizado">objeto estudioAtualizado com os dados atualizados</param>
        void AtualizarEstudio(EstudioDomain estudioAtualizado);

        /// <summary>
        /// Busca um estúdio por meio do seu Id
        /// </summary>
        /// <param name="idEstudio">Id do estúdio que será buscado</param>
        /// <returns>Um estúdio buscado</returns>
        EstudioDomain BuscarPorId(int idEstudio);

        /// <summary>
        /// Deleta um estúdio cadastrado
        /// </summary>
        /// <param name="idUsuario">Id do estúdio que será deletado</param>
        void Deletar(int iEstudio);
    }
}
