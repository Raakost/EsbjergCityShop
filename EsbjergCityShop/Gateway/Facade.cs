using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gateway.Models;
using Gateway.ServiceGateways;

namespace Gateway
{
    public class Facade
    {
        private IServiceGateway<Customer> _customerServiceGateway;
        private IServiceGateway<Order> _orderServiceGateway;
        private IServiceGateway<Event> _eventServiceGateway;
        private GiftCardServiceGateway _giftCardServiceGateway;

        public IServiceGateway<Customer> GetCustomerGateway()
        {
            return _customerServiceGateway ?? (_customerServiceGateway = new CustomerServiceGateway());
        }

        public IServiceGateway<Order> GetOrderGateway()
        {
            return _orderServiceGateway ?? (_orderServiceGateway = new OrderServiceGateway());
        }

        public IServiceGateway<Event> GetEventGateway()
        {
            return _eventServiceGateway ?? (_eventServiceGateway = new EventServiceGateway());
        }

        public GiftCardServiceGateway GetGiftCardGateway()
        {
            return _giftCardServiceGateway ?? (_giftCardServiceGateway = new GiftCardServiceGateway());
        }

    }
}
