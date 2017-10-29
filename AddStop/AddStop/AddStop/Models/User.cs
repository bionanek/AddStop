using System;
using System.Collections.Generic;
using System.Text;

namespace AddStop.Models
{
    public class User
    {
        public long Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Rating { get; set; }
    }
}
