using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF02.Models
{
    public class Employee
    {
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }    

        public decimal Salary { get; set; }

        public DateOnly DOB { get; set; }

        [NotMapped]
        public int? Age { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Department? ManagedDepartment { get; set; }

        public Address Address { get; set; }
    }
}
