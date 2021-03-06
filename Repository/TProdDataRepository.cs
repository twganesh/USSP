﻿using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using USSP.Repository;

namespace Repository
{
    public class TProdDataRepository : RepositoryBase<TProdData>, ITProdDataRepository
    {
        public TProdDataRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}