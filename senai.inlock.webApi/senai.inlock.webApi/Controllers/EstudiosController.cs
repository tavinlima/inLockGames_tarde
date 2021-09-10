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
    // ex: http://localhost:5000/api/estudios
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EstudiosController : ControllerBase
    {
        private IEstudioRepository _estudioRepository { get; set; }
        public EstudiosController()
        {
            _estudioRepository = new EstudioRepository();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            EstudioDomain estudioEncontrado = _estudioRepository.BuscarPorId(id);

            if (estudioEncontrado ==  null)
            {
                return NotFound("Nenhum estúdio foi encontrado");
            }
            return Ok(estudioEncontrado);
        }
    }
}
