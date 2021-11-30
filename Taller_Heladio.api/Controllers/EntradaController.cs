using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller_Heladio.api.Modelos;

namespace Taller_Heladio.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaController : ControllerBase
    {
        private readonly Contexto _bd;

        public EntradaController(Contexto contexto)
        {
            _bd = contexto;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.Entrada;
            return Ok(lista);
        }
        [HttpPost]
        public IActionResult Guardar(Entrada obj)
        {
            _bd.Entrada.Add(obj);
            _bd.SaveChanges();
            return Ok(obj);
        }
        [HttpPut]
        public IActionResult Modificar(Entrada obj, int id)
        {

            var modificar = _bd.Entrada.Find(id);
            return Ok(modificar);
        }
        [HttpDelete]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Entrada.Find(id);
            _bd.Entrada.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }
    }
}