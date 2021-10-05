using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaServicios.Api.Libro.Modelo;

namespace TiendaServicios.Api.Libro.Persistencia
{
    public class ContextoLibreria : DbContext

    {
        public ContextoLibreria(DbContextOptions<ContextoLibreria> options) : base(options) { } //Setear la cadena de conexcion desde la clase Startup

        public DbSet<LibreriaMaterial> LibreriaMaterial { get; set; }
    }
}
