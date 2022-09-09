using Imovel.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Core.Entities
{
    public class Project: BaseEntity
    {
        public Project(  string titulo, string descricao, decimal custoTotal, decimal quartos, decimal banheiros, string cEP, string estado, string cidade, string bairro, string areaTotal, string areaConstruida, string vagasGaragem, int idCliente, int idCorretor)
        {
            
            Titulo = titulo;
            Descricao = descricao;
            CustoTotal = custoTotal;
            Quartos = quartos;
            Banheiros = banheiros;
            CEP = cEP;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            AreaTotal = areaTotal;
            AreaConstruida = areaConstruida;
            VagasGaragem = vagasGaragem;
            IdCliente = idCliente;
            IdCorretor = idCorretor;

            Status = ImovelStatusEnum.VendaSolicitada;
            CreatedAt = DateTime.Now;
            Comments = new List<ProjectComment>();
        }

       
        public string Titulo { get; private set; }

        public string Descricao { get; private set; }

        public User Cliente { get; private set; }
        public int IdCliente { get; private set; }
        public User Corretor { get; private set; }
        public int IdCorretor { get; private set; }

        public decimal CustoTotal { get; private set; }

        public decimal Quartos { get; private set; }

        public decimal Banheiros { get; private set; }

        public string CEP { get; private set; }

        public string Estado { get; private set; }

        public string Cidade { get; private set; }

        public string Bairro { get; private set; }

        public string AreaTotal { get; private set; }

        public string AreaConstruida { get; private set; }

        public string VagasGaragem { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }

        public ImovelStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }
       

        public void Cancel()
        {
            if (Status == ImovelStatusEnum.VendaSolicitada || Status == ImovelStatusEnum.VendaSolicitada)
            {
                Status = ImovelStatusEnum.VendaCancelada;
            }
        }

        public void Update(string titulo, string descricao, decimal custoTotal)
        {
            Titulo = titulo;
            Descricao = descricao;
            CustoTotal = custoTotal;
        }
    }
}
