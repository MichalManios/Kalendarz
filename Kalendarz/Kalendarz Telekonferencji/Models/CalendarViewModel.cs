using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalendarz_Telekonferencji.Models
{
    public class CalendarViewModel
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public int Month { get; set; }
        public string Year { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string TypeOfConference { get; set; }
        public string WhoIsConcern { get; set; }
        public string OtherInformation { get; set; }
        public string Url { get; set; }
    }
}
