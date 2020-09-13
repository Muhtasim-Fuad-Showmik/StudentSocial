using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentSocial.API.Models;

namespace StudentSocial.API.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            var user = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Username == username);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.Include(p => p.Photos).ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}