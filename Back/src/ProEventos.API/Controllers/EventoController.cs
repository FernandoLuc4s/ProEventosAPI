using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // rota
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento []{
              new Evento(){ // retornando array de eventos
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "Image.png"
              },
               new Evento(){ // retornando array de eventos
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
              }
            }; // retornando a string na chamada do request
        public EventoController()
        {
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
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
