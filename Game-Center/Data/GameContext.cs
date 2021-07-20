using Microsoft.EntityFrameworkCore;
using Game_Center.Models;

namespace Game_Center.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Game> Game { get; set; }
    }
}