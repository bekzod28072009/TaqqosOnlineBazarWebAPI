using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taqqos.Domain.Commons;
using Taqqos.Domain.Entitys.Users;

namespace Taqqos.Domain.Entitys.Collectors
{
    public class Collector : Auditable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int DateOfBirth { get; set; }

        public HomeAddress HomeAddress { get; set; }
    }
}
