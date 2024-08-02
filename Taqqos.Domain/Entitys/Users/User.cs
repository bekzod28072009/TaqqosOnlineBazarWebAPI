using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Taqqos.Domain.Commons;
using Taqqos.Domain.Enums;

namespace Taqqos.Domain.Entitys.Users
{
    public class User : Auditable
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(50)]
        public string Username { get; set; }
        [Required, MaxLength(5)]
        public string Password { get; set; } 
        public string Email { get; set; }

        public long? AddressId { get; set; }
        public HomeAddress? Address { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public DateTime? DateOfBirth { get; set; }
        public long Orsers { get; set; }

    }
}
