using CORE.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ShippingPaperProvider : IShippingPaperProvider
    {
        private readonly IWsseUserRepository _wsseUserRepository;

        public ShippingPaperProvider(IWsseUserRepository wsseUserRepository)
        {
            _wsseUserRepository = wsseUserRepository;
        }

        public List<WsseUser> GetAllUsers()
        {
            var users = _wsseUserRepository.DataSet.ToList();

            return users;
        }
    }
}
