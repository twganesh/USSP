using System.Data.Entity.Validation;
using System.Diagnostics;

namespace SLB.USSP.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDataContextFactory _dataContextFactory;
        private GCRCContext _dataContext;

        public UnitOfWork(IDataContextFactory dataContextFactory)
        {
            _dataContextFactory = dataContextFactory;
        }

        protected GCRCContext DataContext
        {
            get { return _dataContext ?? (_dataContext = _dataContextFactory.Get()); }
        }

        public void Commit(string userName)
        {
            try
            {
                DataContext.SaveChanges(userName);
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw dbEx;
            }
        }
    }
}
