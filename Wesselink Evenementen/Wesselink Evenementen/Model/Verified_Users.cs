using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wesselink_Evenementen.Model
{
    public class Verified_Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }

        public int Barkeeper { get; set; }

        public int Receptionist { get; set; }

        public int Waiter { get; set; }

        public int Host { get; set; }
    }
}
