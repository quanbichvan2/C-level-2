using System;
using System.Collections.Generic;

namespace ASM_PS28709_QuanBichVan_SD18322.Models
{
    public partial class Student
    {
        public int StId { get; set; }
        public string? Name { get; set; }
        public double? Mark { get; set; }
        public string? Email { get; set; }
        public int? IdClass { get; set; }

        public virtual Class? IdClassNavigation { get; set; }
    }
}
