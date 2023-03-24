using PokemonReviewApp.Data;
using PokemonReviewApp.Interface;
using PokemonReviewApp.Model;

namespace PokemonReviewApp.Repository
{
    public class CategoryRepository : ICategoryRepository


    {
        private DataContext _context;
        public CategoryRepository(DataContext context) {
            _context = context;
        }
        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        public bool CreateCategory(Category category)
        {
            //change tracker
            //adding updating modifying  connected and disconnected
            //EntityState.Added = 
            //
            _context.Add(category);
            return Save();
        }

        public bool DeleteCategory(Category category)
        {
            _context.Remove(category);
            return Save();
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }

       

        public bool UpdateCategory(Category category)
        {
            _context.Update(category);
            return Save();
        } 
        
        public bool Save()
        {
            return _context.SaveChanges() > 0;

        }
    }
}
