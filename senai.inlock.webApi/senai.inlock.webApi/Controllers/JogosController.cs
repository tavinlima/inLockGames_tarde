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
    }
}
