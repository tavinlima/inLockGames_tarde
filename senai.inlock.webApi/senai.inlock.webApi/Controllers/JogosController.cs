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

    [Route("api/[controller]")]
    [ApiController]

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





        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _JogoRepository.Deletar(id);

            return StatusCode(204);
        }

    }
}
