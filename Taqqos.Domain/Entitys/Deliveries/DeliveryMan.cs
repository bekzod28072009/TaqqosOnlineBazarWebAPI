using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taqqos.Domain.Commons;
using Taqqos.Domain.Entitys.Users;

namespace Taqqos.Domain.Entitys.Deliveries
{
    public class DeliveryMan : Auditable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Licence { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public int Phone { get; set; }

        public HomeAddress Address { get; set; }

        public Car InfoCar { get; set; }
    }
}
