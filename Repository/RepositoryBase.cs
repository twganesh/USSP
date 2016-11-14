using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;

namespace USSP.Repository
{

    public abstract class RepositoryBase<T> where T : class
    {
        private DbContext _dataContext;
        private readonly IDbSet<T> _dbSet;

        protected IDataContextFactory ContextFactory { get; private set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <returns></returns>
        public RepositoryBase(IDataContextFactory contextFactory)
        {
            ContextFactory = contextFactory;
            _dbSet = DataContext.Set<T>();
        }

        protected DbContext DataContext
        {
            get { return _dataContext ?? (_dataContext = ContextFactory.Get()); }
        }

        protected ObjectContext ObjectContext
        {
            get { return ((IObjectContextAdapter)DataContext).ObjectContext; }
        }

        public virtual IQueryable<T> DataSet
        {
            get { return _dbSet.AsQueryable(); }
        }

        public virtual void Add(T newEntity)
        {
            _dbSet.Add(newEntity);
        }

        public virtual void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

  
    }
}
