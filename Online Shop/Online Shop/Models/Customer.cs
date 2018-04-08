using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [MinLength(2), MaxLength(30)]
        public string FirstName { get; set; }
        [MinLength(2), MaxLength(30)]
        public string LastName { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [Range(3, 110)]
        public int Age { get; set; }
        [EmailAddress]
        public string EmailAdress { get; set; }
        public string Adress { get; set; }
        public int PostCode { get; set; }

    }
}
