using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Core.Entities
{
    public class User: BaseEntity
    {
        public User(string nomeCompleto, string email, DateTime dataNascimento, string idade, string rG, string cPF)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            DataNascimento = dataNascimento;
            Idade = idade;
            RG = rG;
            CPF = cPF;
            CadastroAtivo = true;

            Imoveis = new List<Project>();
            OwnedImoveis = new List<Project>();
            Comments = new List<ProjectComment>();
           
        }

        public string NomeCompleto { get; private set; }
        public string Email { get; private  set; }
        public DateTime DataNascimento { get; private set; }
        public string Idade { get; private set; }
        public string RG { get; private set; }
        public string CPF { get; private set; }
        public bool CadastroAtivo { get; private set; }
        public string Senha { get; private set; }

        public List<ProjectComment> Comments { get; private set; }
        public List<Project> OwnedImoveis { get; private set; }
        public List<Project> Imoveis { get; private set; }

        //uso do role pra atribuir o papel, se é cliente ou corretor
        // public string Role { get; private set; }






    }
}
