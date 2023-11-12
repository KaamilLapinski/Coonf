using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coonf.Domain.Model
{
    public class Paper
    {
        public int Id { get; set; }
        public string? Title { get; set; }      
        public string? Description { get; set; }
        public int Reviewer { get; set; } 
        public int PaperStatusId { get; set; }
        public virtual PaperStatus? PaperStatus { get; set;  }      
    }
}
