using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Application.InputModels
{
    public class CreateUserInputModel
    {
        public string NomeCompleto { get; set; }
        public string Email { get;  set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get;  set; }

        public string Idade { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

    }
}
