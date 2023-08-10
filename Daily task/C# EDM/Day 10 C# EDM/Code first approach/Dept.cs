using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Models
{
    internal class Dept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Deptno { get; set; }

        [Required]
        public string? Deptname { get; set;}

        public ICollection<Emp> Emps { get; set; }


    }
}
