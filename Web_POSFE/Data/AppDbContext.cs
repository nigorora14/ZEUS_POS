using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using WebPOS_FE.Models;

namespace Web_POSFE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
        
        }
       // public DbSet<zz_tablaTest> zz_tablaTest { get; set; }
    }
}
