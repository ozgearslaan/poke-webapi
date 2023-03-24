namespace PokemonReviewApp.Model
{
    public class Pokemon
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        //her biri bir kolon


        public ICollection<Review> Reviews { get; set; }

        //one to many

        public ICollection<PokemonOwner> PokemonOwners { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
