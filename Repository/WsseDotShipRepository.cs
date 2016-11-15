
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Repository
{
    public class WsseDotShipRepository : RepositoryBase<WsseDotShip>, IWsseDotShipRepository
    {
        public WsseDotShipRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}