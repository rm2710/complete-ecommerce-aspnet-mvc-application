using System.ComponentModel.DataAnnotations;


namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required]

        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        [Required]
        [MaxLength(50, ErrorMessage = "Full Name cannot exceed 50 characters")]
        public string FullName { get; set; }

        [MaxLength(500, ErrorMessage = "Actor biography cannot exceed 500 characters")]
        [Display(Name = "Biography")]
        
        public string Bio { get; set; }

        //Relationships

        public List<Actor_Movie> Actors_Movie { get; set; }
    }
}
