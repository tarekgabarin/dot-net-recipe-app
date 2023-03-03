namespace DotNetRecipesApp.Entities
{
    public class Recipe
    {
        public string Name { get; set; }
        public string CookingInstructions { get; set; }
        public int Id { get; set; }
        public List<Tag> Tags { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public int UserRatings { get; set; }
        
    }
}
