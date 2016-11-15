using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SLB.USSP.Repository;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Service
{

    public class PickListProvider : IPickListProvider
    {

        private IUnitOfWork _unitOfWork;
        private RepositoryBase<PickList> _pickListRepository;

        public PickListProvider(IUnitOfWork unitofWork, RepositoryBase<PickList> pickListRepository)
        {
            _unitOfWork = unitofWork;
            _pickListRepository = pickListRepository;
        }

        public IEnumerable<PickList> GetPickLists()
        {
           return _pickListRepository.DataSet.AsEnumerable();
        }

        //public void Dispose()
        //{
        //    _unitOfWork.Dispose();
        //}


    }
}
