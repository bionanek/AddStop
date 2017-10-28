using System;
using System.ComponentModel.DataAnnotations;
using AddSpot_API.Enums;

namespace AddSpot_API.Models
{
    public class Advertisement
    {
        public long Id { get; set; }
        public User OwnerId { get; set; }
        public User MateId { get; set; }
        public decimal DestLat { get; set; }
        public decimal DestLong { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TripDate { get; set; }

        [Range(18, int.MaxValue)]
        public int RequiredAge { get; set; }
        public Sex RequiredSex { get; set; }

        public bool OwnerAccepted { get; set; }
        public bool MateAccepted { get; set; }

        public AdvertState State { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }
    }
}
