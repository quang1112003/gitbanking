using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemModels
{
    public class ApplicationUser : IdentityUser
    {
        [Required, DisplayName("Name")]
        public string Name { get; set; }
        public Gender? Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }

        public string? State { get; set; }
        public string?   Country { get; set; }

        [DataType(DataType.PostalCode)]
        public string? PostalCode { get; set; }
    }

    public enum Gender
    {
        MALE,
        FEMALE,
        OTHER
    }
}
