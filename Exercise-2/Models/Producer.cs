using System.ComponentModel.DataAnnotations;

namespace Exercise_2.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? Fullname { get; set; }
        public string? Bio { get; set; }
        //RELATIONSHIP
        public List<Movie>? Movies { get; set; }
    }
}
