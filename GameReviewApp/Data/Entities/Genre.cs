using System.ComponentModel.DataAnnotations;

namespace GameReviewApp.Data.Entities
{
    public class Genre
    {
        [Key]
        [Required]
        public int Id { get; init; }
        [Required]
        public string Name { get; set; }

        public IList<Game> Games { get; set; } = new List<Game>();

    }
}
