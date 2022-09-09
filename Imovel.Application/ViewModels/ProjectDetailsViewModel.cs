using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string titulo, string descricao, decimal custoTotal, DateTime? startedAt, DateTime? finishedAt, string clienteNomeCompleto, string corretorNomeCompleto)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            CustoTotal = custoTotal;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
            ClienteNomeCompleto = clienteNomeCompleto;
            CorretorNomeCompleto=corretorNomeCompleto;
        }

        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public decimal CustoTotal { get; set; }
        public DateTime? StartedAt { get;  set; }
        public DateTime? FinishedAt { get;  set; }

        public string CorretorNomeCompleto { get; set; }

        public string ClienteNomeCompleto { get; set; }
    }
}
