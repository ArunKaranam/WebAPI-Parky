using ParkyWeb.Repository.IRepository;
using ParkyWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyWebMVC.Repository.IRepository
{
    public interface IAccountRepository:IRepository<User>
    {
        Task<User> LoginAsync(string url, User objToCreate);
        Task<bool> RegisterAsync(string url, User objToCreate);

    }
}
