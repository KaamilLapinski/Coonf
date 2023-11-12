using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coonf.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddres { get; set; }
        public string? PhoneNumber { get; set; }
        public int UserRoleId { get; set; }
        public virtual UserRole? Role { get; set; }
    }
}
