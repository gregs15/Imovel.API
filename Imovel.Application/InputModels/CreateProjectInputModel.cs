using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Application.InputModels
{
    public class CreateProjectInputModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public decimal CustoTotal { get; set; }

        public int IdCliente { get; set; }

        public int IdCorretor { get; set; }

        public decimal Quartos { get;  set; }

        public decimal Banheiros { get;  set; }

        public string CEP { get;  set; }

        public string Estado { get;  set; }

        public string Cidade { get;  set; }

        public string Bairro { get;  set; }

        public string AreaTotal { get;  set; }

        public string AreaConstruida { get;  set; }

        public string VagasGaragem { get;  set; }

    }
}
