using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // rota
    public class EventosController : ControllerBase
    {

       
        private readonly DataContext context;
        public EventosController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return this.context.Eventos.FirstOrDefault(evento => evento.EventoId == id); // retorna os dados sem o conchete
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return this.context.Eventos ;
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post"; // retornando a string na chamada do request
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id = {id}"; // retornando a string na chamada do request
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com id = {id}"; // retornando a string na chamada do request
        }
    }
}
