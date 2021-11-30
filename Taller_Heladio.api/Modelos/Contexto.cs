using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Heladio.api.Modelos
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> Options) : base(Options)
        {

        }

        public DbSet<Marca> Marca { get; set; }
        public DbSet<Servicios> Servicios { get; set; }

        public DbSet<Color> Color { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }

        public DbSet<Refaccion> Refaccion { get; set; }

        public DbSet<Entrada> Entrada { get; set; }

        public DbSet<EntradaDetalle> EntradaDetalle { get; set; }
    }
}
