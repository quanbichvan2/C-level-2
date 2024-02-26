using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_PS28709_QuanBichVan_SD18322.Models
{
    public class SinhVien
    {
        public string NameClass { get; set; }
        public string NameStudent { get; set; }
        public int StID { get; set; }
        public float Mark { get; set; }
        public string Email { get; set; }
        public int IdClass { get; set; }

        public SinhVien()
        {

        }
        public SinhVien(string nameclass)
        {
            this.NameClass = nameclass;
        }
        public SinhVien(string namestudent, float mark, string email, int idclass)
        {
            this.NameStudent = namestudent;
            this.Mark = mark;
            this.Email = email;
            this.Mark = mark;
            this.IdClass = idclass;
        }
    }
}
