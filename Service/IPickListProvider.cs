using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSP.Models.CORE;

namespace USSP.Service
{
    public interface IPickListProvider
    {
        IEnumerable<PickList> GetPickLists();
    }
}
