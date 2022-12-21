namespace FilmLibrary
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public int LengthInMinutes 
        {
            get ; 
            set;
        }
        public string CountryOfOrigin { get; set; }

        // constructor
        public Movie()
        {

        }

        public Movie(int id, string movieName, int lengthInMinutes, string countryOfOrigin)
        {
            Id = id;
            MovieName = movieName;
            LengthInMinutes = lengthInMinutes;
            CountryOfOrigin = countryOfOrigin;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id} {MovieName} Length in minutes: {LengthInMinutes} From: {CountryOfOrigin}";
        }
    }
}