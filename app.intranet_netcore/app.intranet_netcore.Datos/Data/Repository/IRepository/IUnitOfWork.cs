using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.intranet_netcore.Datos.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {

        IUsuarioRepository Usuario { get; }
        void Save();
    }
}
