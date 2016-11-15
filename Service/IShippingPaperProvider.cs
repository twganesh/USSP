using SLB.USSP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLB.USSP.Service
{
    public interface IShippingPaperProvider
    {
        List<WsseUser> GetAllUsers();
    }
}
