using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coonf.Domain.Model
{
    public class UserRole
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<User>? users { get; set; }
    }
}
