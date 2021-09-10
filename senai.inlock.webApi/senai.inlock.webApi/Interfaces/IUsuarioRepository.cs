using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório UsuarioRepository
    /// </summary>
    interface IUsuarioRepository
    {
        /// <summary>
        /// Cadastra um novo Usuario no sistema
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario com seus dados</param>
        void Cadastrar(UsuarioDomain novoUsuario);

        /// <summary>
        /// Lista todos os usuarios cadastrado
        /// </summary>
        /// <returns>Lista de todos os usuarios cadastrado</returns>
        List<UsuarioDomain> ListarTodos();

        /// <summary>
        /// Atualiza um usuario cadastrado
        /// </summary>
        /// <param name="usuarioAtualizado">objeto usuarioAtualizado com os dados atualizados</param>
        void AtualizarUsuario(UsuarioDomain usuarioAtualizado);

        /// <summary>
        /// Busca um usuário por meio de seu Id
        /// </summary>
        /// <param name="idUsuario">Id do usuário que será buscado</param>
        /// <returns>Um usuário buscado</returns>
        UsuarioDomain BuscarPorId(int idUsuario);

        /// <summary>
        /// Deleta um usuário cadastrado
        /// </summary>
        /// <param name="idUsuario">Id do usuário que será deletado</param>
        void Deletar(int idUsuario);

        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="email">Email do usuario</param>
        /// <param name="senha">Senha do usuario</param>
        /// <returns>Retorna um usuário encontrado</returns>
        UsuarioDomain Login(string email, string senha);
    }
}
