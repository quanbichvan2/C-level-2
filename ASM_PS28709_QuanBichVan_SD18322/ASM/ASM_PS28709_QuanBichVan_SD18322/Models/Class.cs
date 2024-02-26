using System;
using System.Collections.Generic;

namespace ASM_PS28709_QuanBichVan_SD18322.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public int IdClass { get; set; }
        public string? NameClass { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
