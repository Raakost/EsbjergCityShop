﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Gateway.Models;

namespace Gateway.ServiceGateways
{
    public class OrderServiceGateway : IServiceGateway<Order>
    {
        private void ServiceGateway(HttpClient client)
        {
            client.BaseAddress = new Uri("http://localhost:6681/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public Order Create(Order t)
        {
            using (var client = new HttpClient())
            {
                ServiceGateway(client);
                HttpResponseMessage responseMessage = client.PostAsJsonAsync("api/orders", t).Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    return responseMessage.Content.ReadAsAsync<Order>().Result;
                }
                return null;
            }
        }

        public List<Order> GetAll()
        {
            using (var client = new HttpClient())
            {
                ServiceGateway(client);
                HttpResponseMessage responseMessage = client.GetAsync("api/orders").Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    return responseMessage.Content.ReadAsAsync<List<Order>>().Result;
                }
            }
            return null;
        }

        public Order Get(int id)
        {
            using (var client = new HttpClient())
            {
                ServiceGateway(client);
                HttpResponseMessage responseMessage = client.GetAsync($"api/orders/{id}").Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    return responseMessage.Content.ReadAsAsync<Order>().Result;
                }
                return null;
            }
        }

        public Order Update(Order t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order t)
        {
            using (var client = new HttpClient())
            {
                ServiceGateway(client);
                HttpResponseMessage responseMessage = client.DeleteAsync($"api/orders/{t.Id}").Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    return responseMessage.Content.ReadAsAsync<Order>().Result != null;
                }
                return false;
            }
        }
    }
}
