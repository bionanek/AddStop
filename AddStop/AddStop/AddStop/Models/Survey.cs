using System;
using System.Collections.Generic;
using System.Collections;
namespace AddStop.Models
{
    public class Survey
    {
        public long Id { get; set; }
        public User UserID { get; set; }
        //public Questions QuestionID { get; set; }
        public List<Questions> Questions { get; set; }
        public DateTime Date { get; set; }

        public PersonType IdPersonType { get; set; }

    }
}
