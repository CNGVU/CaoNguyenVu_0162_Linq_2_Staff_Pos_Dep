using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_Staff_Department
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public double Salary { get; set; }

        public int IdPosition { get; set; }
        public int IdDepartment { get; set; }
        public string Decription { get; set; }

        public Staff(int id, string name, int age ,string sex, double salary, int idPosition, int idDepartment, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Salary = salary;
            this.IdPosition = idPosition;
            this.IdDepartment = idDepartment;
            this.Decription = description;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7}", Id, Name, Age, Sex, Salary, IdPosition, IdDepartment, Decription);
        }
        public static List<Staff> getAll()
        {
            List<Staff> listStaff = new List<Staff>
            {
                new Staff(1,"Vu", 21, "Nam", 50000000,1,1,"asdf"),
                new Staff(2,"Yen", 20, "Nu", 44300000,2,1,"asdf"),
                new Staff(3,"Nhu", 22, "Nu", 10000000,3,2,"asdf"),
                new Staff(4,"Thong", 19, "Nam", 2000000,2,3,"asdf"),
                new Staff(5,"Thang", 20, "Nam", 4000000,1,2,"asdf"),
            };
            return listStaff;
        }

    }
}
