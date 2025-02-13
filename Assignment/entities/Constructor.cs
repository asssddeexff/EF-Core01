using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.entities
{
    internal class Constructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength =10)]
        public string Name { get; set; }
        public decimal Bouns { get; set; }

            [Column(TypeName ="money")]
           [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Column("ConsAddress", TypeName = "VarChar")]
        public string Address { get; set; }
        public decimal HourRate { get; set; }
       
        public int Dept_ID { get; set; }
    }
}
