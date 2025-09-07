using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay01.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
