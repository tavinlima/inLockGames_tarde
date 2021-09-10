using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que represent a entidade USUARIO
    /// </summary>
    public class UsuarioDomain
    {
        public int idUsuario { get; set; }
        [Required(ErrorMessage = "Informe o e-mail")]
        public string email { get; set; }
        [Required(ErrorMessage = "Informe a senha")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "O campo senha precisa ter no mínimo 4 e no máximo 10 caracteres")]
        public string senha { get; set; }
        public int idTipoUsuario { get; set; }
    }
}
