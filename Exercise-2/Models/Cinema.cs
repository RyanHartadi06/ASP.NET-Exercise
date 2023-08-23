using System.ComponentModel.DataAnnotations;

namespace Exercise_2.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string? CinemaLogo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        //RELATIONSHIP
        public List<Movie>? Movies { get; set; }
        
    }
}
