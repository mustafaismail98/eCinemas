using System.ComponentModel.DataAnnotations;

namespace eCinemas.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
    }
}
