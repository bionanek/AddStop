using System;
using Microsoft.EntityFrameworkCore;
namespace AddSpot_API.Models
{
    public class AdvertisementContext : DbContext
    {
        public AdvertisementContext(DbContextOptions<AdvertisementContext> options)
                : base(options)
        {
        }
        public DbSet<Advertisement> Adverts { get; set; }
    }
}
