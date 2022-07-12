using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; } 
        public string Logo { get; set; }

        [Required]
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }


        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationshsips

        public List<Movie> Movies { get; set; }
        
    }
}
