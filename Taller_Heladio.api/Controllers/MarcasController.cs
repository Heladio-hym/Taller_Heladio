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
    public class MarcasController : ControllerBase
    {
        private readonly Contexto _bd;

        public MarcasController(Contexto contexto)
        {
            _bd = contexto;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.Marca;
            return Ok(lista);
        }
        [HttpPost]
        public IActionResult Guardar(Marca obj)
        {
            _bd.Marca.Add(obj);
            _bd.SaveChanges();
            return Ok(obj);
        }
        [HttpPut]
        public IActionResult Modificar(Marca obj, int id)
        {

            var modificar = _bd.Marca.Find(id);
            return Ok(modificar);
    }
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Marca.Find(id);
            _bd.Marca.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }
    }
} 
