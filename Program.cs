using ConsultaCep.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCep
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Informe o Cep: ");
            String cep = Console.ReadLine();

            AddressServices addressServices = new AddressServices();

            Address address = await addressServices.Integracao(cep);

            if (!address.Verification)
            {
                Console.WriteLine(address);
            }

            Console.ReadKey();
        }
    }
}
