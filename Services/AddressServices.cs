using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCep.Services
{
    internal class AddressServices
    {
        public AddressServices()
        {
        }

        public async Task<Address> Integracao(String Cep)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://viacep.com.br/ws/{Cep}/json/");

            var jsonString = await response.Content.ReadAsStringAsync();

            Address jsonObject = JsonConvert.DeserializeObject<Address>(jsonString);

            if (jsonObject != null)
                return jsonObject;
            else
                return new Address { Verification = true };
        }
    }
}
