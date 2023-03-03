using DotNetRecipesApp.Data;
using DotNetRecipesApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotNetRecipesApp.Services
{
    public class UsersService : IUsersService
    {
        private readonly DataContext _context;

        public UsersService(DataContext context)
        {
            _context = context;
        }
        public IQueryable<Entities.AppUser> QueryUsers()
        {
            return _context.AppUsers.AsQueryable();
        }
    }
}
