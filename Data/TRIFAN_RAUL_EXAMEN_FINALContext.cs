using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRIFAN_RAUL_EXAMEN_FINAL.Models;

namespace TRIFAN_RAUL_EXAMEN_FINAL.Data
{
    public class TRIFAN_RAUL_EXAMEN_FINALContext : DbContext
    {
        public TRIFAN_RAUL_EXAMEN_FINALContext (DbContextOptions<TRIFAN_RAUL_EXAMEN_FINALContext> options)
            : base(options)
        {
        }

        public DbSet<TRIFAN_RAUL_EXAMEN_FINAL.Models.Restaurant> Restaurant { get; set; }
    }
}
