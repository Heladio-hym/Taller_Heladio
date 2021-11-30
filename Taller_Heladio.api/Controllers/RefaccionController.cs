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
    public class RefaccionController : ControllerBase
    {
        private readonly Contexto _bd;

        public RefaccionController(Contexto contexto)
        {
            _bd = contexto;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.Refaccion;
            return Ok(lista);
        }
        [HttpPost]
        public IActionResult Guardar(Refaccion obj)
        {
            _bd.Refaccion.Add(obj);
            _bd.SaveChanges();
            return Ok(obj);
        }
        [HttpPut]
        public IActionResult Modificar(Refaccion obj, int id)
        {

            var modificar = _bd.Refaccion.Find(id);
            return Ok(modificar);
        }
        [HttpDelete]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Refaccion.Find(id);
            _bd.Refaccion.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }
    }
}