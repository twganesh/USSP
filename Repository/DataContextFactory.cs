using System;

namespace USSP.Repository
{
    public class DataContextFactory : 
        IDataContextFactory,
        IDisposable
    {
        private GCRCContext _dataContext;

        public DataContextFactory(GCRCContext dataContext)
        {
            _dataContext = dataContext;
        }

        public GCRCContext Get()
        {
            return _dataContext;
        }

        public void Dispose()
        { 
            if (_dataContext != null)
                _dataContext.Dispose();
        }
    }
}
