using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string titulo, DateTime createdAt)
        {
            Id = id;
            Titulo = titulo;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }

        public string Titulo { get; private set; }

        public DateTime CreatedAt { get; private set; }
    }
}
