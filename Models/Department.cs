using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF02.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        public Employee? Manager { get; set; }//Nav Prop -> One 

    }
}
