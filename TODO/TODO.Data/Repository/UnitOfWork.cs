using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.Data.Data;

namespace TODO.Data.Repository
{
    class UnitOfWork : IDisposable
    {
        private Data.TODO context = new Data.TODO();
        private Repository<List> listRepository;
        private Repository<Categorias> categoriasRepository;

        public Repository<List> ListRepository
        {
            get
            {

                if (this.listRepository == null)
                {
                    this.listRepository = new Repository<List>(context);
                }
                return listRepository;
            }
        }

        public Repository<Categorias> CategoriasRepository
        {
            get
            {

                if (this.categoriasRepository == null)
                {
                    this.categoriasRepository = new Repository<Categorias>(context);
                }
                return categoriasRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}