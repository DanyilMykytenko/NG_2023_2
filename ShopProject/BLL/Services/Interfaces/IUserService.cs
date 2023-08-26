using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task AddUserAsync(UserModel user);
        Task UpdateUserAsync(UserModel user, int id);
        Task DeleteUserAsync(int id);
        IQueryable GetAllUsers();
        Task<UserModel> GetUserById(int id);
        IQueryable GetUserByOrderId(int id);
        IQueryable GetUserByLogin(string login);
    }
}
