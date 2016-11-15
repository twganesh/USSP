using System.Collections.Generic;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Service
{
    public interface IPickListProvider
    {
        IEnumerable<PickList> GetPickLists();
    }
}
