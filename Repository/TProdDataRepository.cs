
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Repository
{
    public class TProdDataRepository : RepositoryBase<TProdData>, ITProdDataRepository
    {
        public TProdDataRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}