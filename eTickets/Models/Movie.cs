using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTickets.Data.Enums;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }


        [Required]
        
        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Movie Photo")]
        public string ImageUrl { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }


        [Required]
        [Display(Name = "Category")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }

        //cinema

        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }


        //producer

        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
