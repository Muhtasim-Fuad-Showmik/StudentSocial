using System.Collections.Generic;
using System.Threading.Tasks;
using StudentSocial.API.Models;

namespace StudentSocial.API.Data
{
    public interface IStudentRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<User> GetUserByUsername(string username);
    }
}