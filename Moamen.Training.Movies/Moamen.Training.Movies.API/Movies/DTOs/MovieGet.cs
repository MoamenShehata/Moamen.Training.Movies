namespace Moamen.Training.Movies.API.Movies.DTOs
{
    public class MovieGet
    {
        public int Year { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Rating { get; set; }
        public TimeSpan Length { get; set; }
        //public ICollection<MovieMembers> MovieMembers { get; set; }
        //public ICollection<MovieGenres> MovieGenres { get; set; }
        //public ICollection<Media> Medias { get; set; }
        //public ICollection<MovieUsers> MovieUsers { get; set; }
    }
}
