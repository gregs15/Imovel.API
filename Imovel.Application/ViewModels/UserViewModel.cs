using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string nomeCompleto, string email)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
        }

        public string NomeCompleto { get; private set; }

        public string Email { get; private set; }
    }
}
