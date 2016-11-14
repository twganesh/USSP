using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using USSP.Repository;

namespace Repository
{
    public class WsseShipRepository: RepositoryBase<WsseShip>, IWsseShipRepository
    {
        public WsseShipRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}