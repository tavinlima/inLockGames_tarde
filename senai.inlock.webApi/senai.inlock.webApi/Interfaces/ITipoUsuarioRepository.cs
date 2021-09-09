using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório TipoUsuarioRepository
    /// </summary>
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Cadastra um novo tipo de usuario no sistema
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto novoTipoUsuario com seus dados</param>
        void Cadastrar(TipoUsuarioDomain novoTipoUsuario);

        /// <summary>
        /// Lista todos os tipos de Usuario cadastrados
        /// </summary>
        /// <returns>Lista de todos os tipos de usuário cadastrados</returns>
        List<TipoUsuarioDomain> ListarTodos();

        /// <summary>
        /// Atualiza um tipo de usuário cadastrado
        /// </summary>
        /// <param name="tipoAtualizado">Objeto tipoAtualizado com seus novos dados atualizados</param>
        void AtualizarTipoUser(TipoUsuarioDomain tipoAtualizado);

        /// <summary>
        /// Deleta um tipo de usuário do sistema
        /// </summary>
        /// <param name="idTipoUsuario">Id do tipoUsuario que será deletado</param>
        void Deletar(int idTipoUsuario);
    }
}
