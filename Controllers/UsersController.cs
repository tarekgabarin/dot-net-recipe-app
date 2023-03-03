using DotNetRecipesApp.Data;
using DotNetRecipesApp.Services;
using DotNetRecipesApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetRecipesApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // /api/users
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entities.AppUser>>> GetUsers()
        {
            return await _usersService.QueryUsers().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Entities.AppUser>> GetUser(int id)
        {

            var selected_user = await _usersService.QueryUsers().FirstOrDefaultAsync(users => users.Id == id);
                
            if (selected_user != null){
               return selected_user;
            } else {
                return NotFound();
            }

        }

    }
}
