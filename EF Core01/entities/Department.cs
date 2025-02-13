using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core01.entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DateOfCreation { get; set; }
    }
}
