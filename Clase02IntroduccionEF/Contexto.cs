using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02IntroduccionEF
{
    public class Contexto : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Persona> Persona { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Usaremos un archivo local llamado "escuela.db"
            options.UseSqlite("Data Source=escuela.db");
        }
    }

}
