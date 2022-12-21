using FilmLibrary;

namespace FilmAPI.managers
{
    public class MovieManager
    {
        // statisklist af film

        private readonly static List<Movie> _movies = new List<Movie>()
        {
            new Movie(1, "Dune", 155, "USA"),
            new Movie(2, "the fifth element", 126, "USA"),
            new Movie(3, "Martys", 99, "France")


        };

        private static int nextId = 4;


        public List<Movie> GetAll()
        {
            return new List<Movie>(_movies);
        }

        public Movie GetById(int Id)
        {
            Movie? mov = _movies.Find(m => m.Id == Id);
            if (mov == null)
            {
                throw new KeyNotFoundException();
            }
            return mov;
        }

        public Movie PostMovie(Movie mov)
        {
            mov.Id = nextId++;
            nextId++;

            _movies.Add(mov);
            return mov;
        }
    }
}
