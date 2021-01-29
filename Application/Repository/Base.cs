using Application.Repository.Interface;
using Models;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class Base : IBase
    {

        private readonly ApplicationDbContext _context;

        public Base(ApplicationDbContext context)
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

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }


        public async Task<bool> SaveAllAsync()
        {
            if (await _context.SaveChangesAsync() > 0)
                return true;
            return false;
        }

        public User GetUser(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
                return user;
            else
                throw new Exception("Пользователь не найден.");
        }

    }
}
