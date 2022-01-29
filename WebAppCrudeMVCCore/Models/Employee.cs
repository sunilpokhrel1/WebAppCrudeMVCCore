using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCrudeMVCCore.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column("nvarchar(250)")]
        [Required]
        [DisplayName("Full Name")]
        public String FullName { get; set; }

        [Column("varchar(10)")]
        public String EmpCode { get; set; }

        [Column("varchar(100)")]
        public String Position { get; set; }

        [Column("varchar(100)")]
        [DisplayName("Office Location")]
        public String OfficeLocation { get; set; }


    }
}
