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
    public class ColorController : ControllerBase
    {
        private readonly Contexto _bd;

        public ColorController(Contexto contexto)
        {
            _bd = contexto;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.Color;
            return Ok(lista);
        }
        [HttpPost]
        public IActionResult Guardar(Color obj)
        {
            _bd.Color.Add(obj);
            _bd.SaveChanges();
            return Ok(obj);
        }
        [HttpPut]
        public IActionResult Modificar(Color obj, int id)
        {

            var modificar = _bd.Color.Find(id);
            return Ok(modificar);
        }
        [HttpDelete]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Color.Find(id);
            _bd.Color.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }
    }
}