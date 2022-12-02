using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameReviewApp.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(25), MinLength(3)]
        public string Name { get; set; }
        [Required]
        public IList<Review> Reviews { get; set; } = new List<Review>();
        
        public IFormFile Picture { get; set; }
        [Required]
        public int ToPlayBoardId { get; set; }
        [Required]
        [ForeignKey(nameof(ToPlayBoardId))]
        public ToPlayBoard ToPlayBoard { get; set; }
        [Required]
        public int DoneBoardId { get; set; }
        [Required]
        [ForeignKey(nameof(ToPlayBoardId))]
        public DoneBoard DoneBoard { get; set; }




        
    }
}
