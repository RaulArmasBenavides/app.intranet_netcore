using app.intranet_netcore.Datos.Data.Repository.IRepository;
using app.intranet_netcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.intranet_netcore.Datos.Data.Repository
{
    internal class AlumnoRepository : Repository<Alumno>, IAlumnoRepository
    {
        private readonly ApplicationDbContext _db;

        public AlumnoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


    }
}
