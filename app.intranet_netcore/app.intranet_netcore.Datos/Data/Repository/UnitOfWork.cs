using app.intranet_netcore.Datos.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.intranet_netcore.Datos.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Alumnos = new AlumnoRepository(_db);
            Usuario = new UsuarioRepository(_db);
        }
        public IAlumnoRepository Alumnos { get; private set; }
        public IUsuarioRepository Usuario { get; private set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
