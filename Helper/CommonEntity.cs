using System.ComponentModel.DataAnnotations;

namespace Movie_Review_Portal.Helper
{
    public class CommonEntity
    {
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
