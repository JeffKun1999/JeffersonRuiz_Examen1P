using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JeffersonRuiz_Examen1P.Models;

namespace JeffersonRuiz_Examen1P.Data
{
    public class JeffersonRuiz_Examen1PContext : DbContext
    {
        public JeffersonRuiz_Examen1PContext (DbContextOptions<JeffersonRuiz_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<JeffersonRuiz_Examen1P.Models.JR_tabla1> JR_tabla1 { get; set; } = default!;
    }
}
