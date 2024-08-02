using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taqqos.Domain.Commons;

namespace Taqqos.Domain.Entitys.Users
{
    public class HomeAddress : Auditable
    {
        public string Country { get; set; }

        public string Region { get; set; }

        [MaxLength(50)]
        public string District { get; set; }
        [MaxLength(100)]
        public string AddressLine { get; set; }
    }
}
