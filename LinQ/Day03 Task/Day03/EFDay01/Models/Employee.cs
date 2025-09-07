using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EFDay01.Models
{
    internal class Employee
    {
        public int Id { get; set; } // Primary key+Identity(1,1) - not allow null
        public string Name { get; set; } //nvarchar(max) - allow null
        public decimal Salary { get; set; } //not allow null(Required) - decimal(18,2) 
        public int? Age { get; set; } //allow null 
    }
}
