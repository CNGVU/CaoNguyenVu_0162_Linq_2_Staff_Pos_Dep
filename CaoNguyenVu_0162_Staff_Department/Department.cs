using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_Staff_Department
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMemb { get; set; }
        public string Decription { get; set; }
        public Department ( int id, string name, int totalMemb, string description)
        {
            this.Id = id;
            this.Name = name;
            this.TotalMemb = totalMemb;
            this.Decription = description;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} ", Id, Name, TotalMemb);
        }
        public static List<Department> getAll()
        {
            List<Department> listDepartment = new List<Department>
            {
                new Department(1,"Phong giam doc", 21,"asdf"),
                new Department(2,"Phong marketing", 20,"asdf"),
                new Department(3,"Phong ke toan", 22,"asdf"),

            };
            return listDepartment;
        }
    }
}
