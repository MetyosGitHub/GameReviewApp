using System.ComponentModel.DataAnnotations;

namespace GameReviewApp.Data.Entities
{
    public class Game
    {
        [Key]
        [Required]
        public int Id { get; init; }
        [Required]
        [MaxLength(30), MinLength(2)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int YearOfCreation { get; init; }
        [Required]
        public IList<Review> Reviews { get; set; }
        [Required]
        public IFormFile Picture { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        public int PublisherId { get; set; }




    }
}
