using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coonf.Domain.Model
{
    public class Conference
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int PapersLimit { get; set; }
        public DateTime Date { get; set; }
        public string? Place { get; set; }
        public double AverageGrade { get; set; }
        public int ConferenceStatusId { get; set; }       
        public virtual ConferenceStatus? ConferenceStatus { get; set; }
    }
}
