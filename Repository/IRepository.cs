using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLB.USSP.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> DataSet { get; }

        void Add(T newEntity);

        void Remove(T entity);
    }
}
