
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Repository
{
    public class WsseTMSProductsRepository : RepositoryBase<WsseTMSProducts>, IWsseTMSProductsRepository
    {
        public WsseTMSProductsRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}