namespace DotNetRecipesApp.Services.Interfaces
{
    public interface IUsersService
    {
        public IQueryable<Entities.AppUser> QueryUsers();
    }
}
