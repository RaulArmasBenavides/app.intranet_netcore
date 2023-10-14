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
            //Categoria = new CategoriaRepository(_db);
            //Articulo = new ArticuloRepository(_db);
            //Slider = new SliderRepository(_db);
            Usuario = new UsuarioRepository(_db);
        }

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
