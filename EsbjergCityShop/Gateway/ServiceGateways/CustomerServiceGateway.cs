using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Gateway.Models;

namespace Gateway.ServiceGateways
{
    public class CustomerServiceGateway : IServiceGateway<Customer>
    {
        private void ServiceGateway(HttpClient client)
        {
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["API_Address"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (HttpContext.Current.Session["token"] != null)
            {
                string token = HttpContext.Current.Session["token"].ToString();
                if (client.DefaultRequestHeaders.Authorization == null)
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                }
            }
        }

        public Customer Create(Customer t)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer t)
        {
            throw new NotImplementedException();
        }

        public Customer GetByEmail(string userName)
        {
            using (var client = new HttpClient())
            {
                ServiceGateway(client);
                HttpResponseMessage responseMessage = client.GetAsync($"api/customers/GetByEmail/{userName}/").Result;
                if (responseMessage.IsSuccessStatusCode)
                {
                    return responseMessage.Content.ReadAsAsync<Customer>().Result;
                }
                return null;
            }
        }
    }
}
