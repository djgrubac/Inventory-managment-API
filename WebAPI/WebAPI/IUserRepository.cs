using System;
using WebAPI.Models;

namespace WebAPI
{
	public interface IUserRepository
	{
        Task<IEnumerable<Users>> GetUsersAsync();
        Task<Users> GetUserByIdAsync(int id);
        Task<Users> GetUserByUsernameAndPasswordAsync(string username, string password);
        Task AddUserAsync(Users user);
        Task DeleteUserAsync(int id);
    }
}

