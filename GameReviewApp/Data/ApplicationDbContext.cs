using GameReviewApp.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameReviewApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }
        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ToPlayBoard> ToPlayBoards { get; set; }
        public DbSet<DoneBoard> DoneBoards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            

            



            base.OnModelCreating(builder);

           
        }
    }
}