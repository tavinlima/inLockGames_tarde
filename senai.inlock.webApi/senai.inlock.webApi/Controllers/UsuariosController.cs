using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Controllers
{
    [Produces("application/json")]

    //Define que a rota de uma requisição será no formato domino/api/nomeController.
    // ex: http://localhost:5000/api/usuarios
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            List<UsuarioDomain> listaUsuarios = _usuarioRepository.ListarTodos();

            return Ok(listaUsuarios);
        }

        [HttpPost("login")]
        public IActionResult Login(UsuarioDomain login)
        {
            UsuarioDomain usuarioEncontrado = _usuarioRepository.Login(login.email, login.senha);

            if (usuarioEncontrado == null)
            {
                return NotFound("E-mail ou senha inválidos!");
            }

            var minhasClaims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, usuarioEncontrado.email),
                new Claim(JwtRegisteredClaimNames.Jti, usuarioEncontrado.idUsuario.ToString()),
                new Claim(ClaimTypes.Role, usuarioEncontrado.idTipoUsuario.ToString())
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("1d9w4e7fgwasDFSS165SDZfsddsf418few534984fs"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var meuToken = new JwtSecurityToken(
                issuer: "senai.inlock.webApi",
                audience: "senai.inlock.webApi",
                claims: minhasClaims,
                expires: DateTime.Now.AddMinutes(35),
                signingCredentials: creds
                );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(meuToken)
            });
        }
    }
}
