using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameReviewApp.Data.Entities
{
    public class DoneBoard
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public IList<Game> Games { get; set; } = new List<Game>();
        [Required]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [Required]
        public string UserId { get; init; }
    }
}
