using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCep
{
    internal class Address
    {
        public String Cep { get; set; }
        public String Uf { get; set; }
        public String Localidade { get; set; }
        public String Bairro { get; set; }
        public String Logradouro { get; set; }
        public Boolean Verification = false;

        public override string ToString()
        {
            return $"CEP: {Cep}\nUF: {Uf}\nCidade: {Localidade}\nBairro: {Bairro}\nEndereco: {Logradouro}\n";
        }
    }
}
