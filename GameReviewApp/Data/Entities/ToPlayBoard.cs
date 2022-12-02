using System.ComponentModel.DataAnnotations;

namespace GameReviewApp.Data.Entities
{
    public class ToPlayBoard
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public IList<Game> Games { get; set; } = new List<Game>();
    }
}
