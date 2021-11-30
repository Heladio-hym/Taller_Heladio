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
    public class EntradaDetalleController : ControllerBase
    {
        private readonly Contexto _bd;

        public EntradaDetalleController(Contexto contexto)
        {
            _bd = contexto;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.EntradaDetalle;
            return Ok(lista);
        }
        [HttpPost]
        public IActionResult Guardar(EntradaDetalle obj)
        {
            _bd.EntradaDetalle.Add(obj);
            _bd.SaveChanges();
            return Ok(obj);
        }
        [HttpPut]
        public IActionResult Modificar(EntradaDetalle obj, int id)
        {

            var modificar = _bd.EntradaDetalle.Find(id);
            return Ok(modificar);
        }
        [HttpDelete]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.EntradaDetalle.Find(id);
            _bd.EntradaDetalle.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }
    }
}