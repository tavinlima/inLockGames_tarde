using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Controllers
{
    [Produces("application/json")]

    //Define que a rota de uma requisição será no formato domino/api/nomeController.
    // ex: http://localhost:5000/api/jogos
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class JogosController : ControllerBase
    {

        private IJogoRepository _JogoRepository { get; set; }

        public JogosController()
        {
            _JogoRepository = new JogoRepository();
        }
  
        [HttpGet]
        public IActionResult Get()
        {
            List<JogoDomain> listaJogos = _JogoRepository.ListarTodos();

            return Ok(listaJogos);

        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(JogoDomain novoJogo)
        {

            _JogoRepository.Cadastrar(novoJogo);
            return StatusCode(201);

        }

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {

            JogoDomain jogoBuscado = _JogoRepository.BuscarPorId(id);

            if(jogoBuscado == null)
            {
                return NotFound("Nenhum jogo encontrado!");
            }

            return Ok(jogoBuscado);

        }

        [Authorize(Roles = "1")]
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            JogoDomain jogoEncontrado = _JogoRepository.BuscarPorId(id);

            if (jogoEncontrado != null)
            {
                try
                {
                    _JogoRepository.Deletar(id);
                }
                catch (Exception erro)
                {
                    return BadRequest(erro);
                }

                return StatusCode(204);
            }
            return NotFound("Nenhum jogo foi encontrado");
            
        }

        [Authorize(Roles = "1")]
        [HttpPut]
        public IActionResult Put(JogoDomain jogoAtualizado)
        {
            if (jogoAtualizado.idEstudio <= 0 || jogoAtualizado.nomeJogo == null || jogoAtualizado.descricao == null || jogoAtualizado.idJogo <= 0)
            {
                return BadRequest(
                    new
                    {
                        mensagem = "Dados não informados",
                    }
                    );
            }

            JogoDomain jogoEncontrado = _JogoRepository.BuscarPorId(jogoAtualizado.idJogo);

            if (jogoEncontrado != null)
            {
                try
                {
                    _JogoRepository.AtualizarJogo(jogoAtualizado);

                    return NoContent();
                }
                catch (Exception erro)
                {
                    return BadRequest(erro);
                }
            }

            return NotFound(
                new
                {
                    mensagem = "Jogo não encontrado",
                    errorStatus = true
                }
                );
        }
    }
}
