using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddSpot_API.Models
{
    public class Survey
    {
        public long Id { get; set; }
        public User UserID { get; set; }
        //public Questions QuestionID { get; set; }
        public Dictionary<long, bool> Question { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public PersonType IdPersonType { get; set; }

    }
}
