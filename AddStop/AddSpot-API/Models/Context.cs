using System;
using Microsoft.EntityFrameworkCore;
namespace AddSpot_API.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
                : base(options)
        {

        }

        public DbSet<Advertisement> Adverts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
    }
}
