using Imovel.Application.InputModels;
using Imovel.Application.Services.Interfaces;
using Imovel.Application.ViewModels;
using Imovel.Core.Entities;
using Imovel.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ImovelDbContext _dbContext;
        public UserService(ImovelDbContext dbContext)
        {
            _dbContext = dbContext; 
        }
        public int Create(CreateUserInputModel inputModel)
        {
            var user = new User(inputModel.NomeCompleto, inputModel.Email, inputModel.DataNascimento, inputModel.Idade, inputModel.RG, inputModel.CPF);

            _dbContext.Users.Add(user);

            _dbContext.SaveChanges();

            return user.Id;
        }

        public UserViewModel GetUser(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
            {
                return null;
            }

            return new UserViewModel(user.NomeCompleto, user.Email);
        }
    }
}
