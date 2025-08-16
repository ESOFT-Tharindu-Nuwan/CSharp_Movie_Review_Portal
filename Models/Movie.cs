using Movie_Review_Portal.Helper;
using System.ComponentModel.DataAnnotations;

namespace Movie_Review_Portal.Models
{
    public class Movie : CommonEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string PosterImage { get; set; }
    }
}
