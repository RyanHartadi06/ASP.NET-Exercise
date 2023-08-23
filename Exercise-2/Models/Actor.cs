using System.ComponentModel.DataAnnotations;

namespace Exercise_2.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? Fullname { get; set;}
        public string? Bio { get; set;}
    
        //RELATIONSHIP
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
