using Microsoft.EntityFrameworkCore;
using AnimalFriend.Core.Dtos;


namespace AnimalFriend.DAL
{
    public class Context : DbContext
    {
        public DbSet<ShelterDto> Shelters { get; set; }

        public DbSet<AnimalDto> Animals { get; set; }

        public DbSet<UserDto> Users { get; set; }

        public DbSet<UserRoleDto> UserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
