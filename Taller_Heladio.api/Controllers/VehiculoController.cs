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
    public class VehiculoController : ControllerBase
    {
        private readonly Contexto _bd;

        public VehiculoController(Contexto contexto)
        {
            _bd = contexto;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.Vehiculo;
            return Ok(lista);
        }
        [HttpPost]
        public IActionResult Guardar(Vehiculo obj)
        {
            _bd.Vehiculo.Add(obj);
            _bd.SaveChanges();
            return Ok(obj);
        }
        [HttpPut]
        public IActionResult Modificar(Vehiculo obj, int id)
        {

            var modificar = _bd.Vehiculo.Find(id);
            return Ok(modificar);
        }
        [HttpDelete]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Vehiculo.Find(id);
            _bd.Vehiculo.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }
    }
}