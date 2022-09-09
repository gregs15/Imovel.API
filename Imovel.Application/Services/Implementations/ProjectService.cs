using Imovel.Application.InputModels;
using Imovel.Application.Services.Interfaces;
using Imovel.Application.ViewModels;
using Imovel.Core.Entities;
using Imovel.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Application.Services.Implementations
{
    public class ProjectService : IProjectService

    {
        private readonly ImovelDbContext _dbContext;

        public ProjectService(ImovelDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(CreateProjectInputModel inputModel)
        {
            var project = new Project(
                inputModel.Titulo,
                inputModel.Descricao,
                inputModel.CustoTotal,
                inputModel.Banheiros,
                inputModel.Quartos,
                inputModel.CEP,
                inputModel.Estado,
                inputModel.Cidade,
                inputModel.Bairro,
                inputModel.AreaTotal,
                inputModel.AreaConstruida,
                inputModel.VagasGaragem,
                inputModel.IdCorretor,
                inputModel.IdCliente) ;

            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
            
            return project.Id;
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            var comment = new ProjectComment(inputModel.Content, inputModel.IdProject, inputModel.IdUser);

            _dbContext.ProjectComments.Add(comment);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

            project.Cancel();
            _dbContext.SaveChanges();
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            var projects = _dbContext.Projects;

            var projectsViewModel = projects
                .Select(p => new ProjectViewModel(p.Id, p.Titulo, p.CreatedAt))
                .ToList();

            return projectsViewModel;
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            var project = _dbContext.Projects
                .Include(p => p.Corretor)
                .Include(p => p.Cliente)
                .SingleOrDefault(p => p.Id == id);

            if (project == null) return null;

            var projectDetailsViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.Titulo,
                project.Descricao,
                project.CustoTotal,
                project.StartedAt,
                project.FinishedAt,
                project.Cliente.NomeCompleto,
                project.Corretor.NomeCompleto
                ) ;

            return projectDetailsViewModel;
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == inputModel.Id);

            project.Update(inputModel.Titulo, inputModel.Descricao, inputModel.CustoTotal);

            _dbContext.SaveChanges();
        }
    }
}
