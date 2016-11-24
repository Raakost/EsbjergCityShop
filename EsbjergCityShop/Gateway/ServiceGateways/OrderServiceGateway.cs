using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gateway.Models;

namespace Gateway.ServiceGateways
{
   public class OrderServiceGateway : IServiceGateway<Order>
    {
        public Order Create(Order t)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order t)
        {
            throw new NotImplementedException();
        }
    }
}
