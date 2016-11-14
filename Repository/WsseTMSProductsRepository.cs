using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using USSP.Repository;

namespace Repository
{
    public class WsseTMSProductsRepository : RepositoryBase<WsseTMSProducts>, IWsseTMSProductsRepository
    {
        public WsseTMSProductsRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}