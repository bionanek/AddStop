using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddSpot_API.Models
{
    public class Questions
    {
        public long ID { get; set; }
        public string Content { get; set; }
        public bool Answer { get; set; }
    }
}
