using System;
using System.Collections.Generic;
using System.Text;
using AddSpot.Enums;

namespace AddStop.Models
{
    public class Advertisement
    {
        public long Id { get; set; }
        public User OwnerId { get; set; }
        public User MateId { get; set; }
        public decimal DestLat { get; set; }
        public decimal DestLong { get; set; }       
        public decimal AddedFromLat { get; set; }
        public decimal AddedFromLong { get; set; }
        public DateTime TripDate { get; set; }
        public int RequiredAge { get; set; }
        public Sex RequiredSex { get; set; }
        public bool OwnerAccepted { get; set; }
        public bool MateAccepted { get; set; }

        public AdvertState State { get; set; }

        public DateTime DateAdded { get; set; }

        public string Place { get; set; }
        public string When { get; set; }
        public int NumberOfPeople { get; set; }
        public string Content { get; set; }
        public string src { get; set; }

    }
}
