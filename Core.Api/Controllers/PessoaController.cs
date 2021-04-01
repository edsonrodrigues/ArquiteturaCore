using Core.Dao;
using Core.Entities.Entidade;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Core.Api.Controllers
{
    [ApiController]
    [Authorize("bearer")] 
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly Contexto _context;

       /* public PessoaController(Contexto context)
        {
           // _context = context;
        }
       */
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger, Contexto context)
        {
            _logger = logger;
            _context = context;
        }

  
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //valida
            if (true)
            {
             
                return Ok(_context.Pessoas.ToList());
            }

            return BadRequest(" invaid input");

        }

    }
}
