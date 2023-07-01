using eCinemas.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCinemas.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
