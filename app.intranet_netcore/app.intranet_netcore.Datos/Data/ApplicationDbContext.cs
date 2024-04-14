using app.intranet_netcore.Models;
using app.intranet_netcore.Models.Log;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.intranet_netcore.Datos.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<DbLog> AuditLogs { get; set; }

    }
}
