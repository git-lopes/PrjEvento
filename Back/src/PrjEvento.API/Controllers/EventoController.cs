using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrjEvento.API.Models;

namespace PrjEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

       public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                Id = 1,
                Local = "Fortaleza",
                Tema ="Angular 11",
                QtdPessoas = 300,
                Lote = "1a Lote",
             },
             new Evento() {
                Id = 2,
                Local = "São Paulo",
                Tema ="Angular 11 e suas novidades",
                QtdPessoas = 200,
                Lote = "2a Lote"
             }
           };   
               
        public EventoController(ILogger<EventoController> logger)
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _evento;
        }

        [HttpGet("{Id}")]
        public IEnumerable<Evento> GetById(int Id)
        {
          return _evento.Where(evento => evento.Id == Id);
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post" ;     
        }

        [HttpPut("{Id}")]
        public string Put(int Id)
        {
           return $"Exemplo de Put com Id = {Id}" ;     
        }

        [HttpDelete("{Id}")]
        public string Delete(int Id)
        {
           return $"Exemplo de Delete com Id = {Id}" ;     
        }

    }
}
