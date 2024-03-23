using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_Staff_Department
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Nhap noi dung tim kiem: ");
            string text = Console.ReadLine();
            Console.WriteLine("Nhap do tuoi tim kiem");
            Console.WriteLine("Tu: ");
            string strFrom = Console.ReadLine();
            int? ageFrom_ = string.IsNullOrEmpty(strFrom) ? (int?)null : Convert.ToInt32(strFrom);
            string strTo = "";
            int? ageTo_ = null;
            if (!strFrom.Equals(""))
            {
                Console.WriteLine("Den: ");
                strTo = Console.ReadLine();
                ageTo_ = string.IsNullOrEmpty(strTo) ? (int?)null : Convert.ToInt32(strTo);
            }

            Console.WriteLine("Nhap ten vi tri: ");
            string namePos = Console.ReadLine();
            Console.WriteLine("Nhap ten phong ban: ");
            string nameDep = Console.ReadLine();
            search(text, ageFrom_, ageTo_, namePos, nameDep);


        }

        public static void search(string text, int? fromAge, int? toAge, string namePostion, string nameDepartment)
        {

            text = text.ToLower();
            var listResult = from staff in Staff.getAll()
                             join position in Position.getAll() on staff.IdDepartment equals position.ID
                             join department in Department.getAll() on staff.IdDepartment equals department.Id
                             where (staff.Name.ToLower().Contains(text) || staff.Decription.ToLower().Contains(text) || 
                             position.Name.ToLower().Contains(text) || position.Decription.ToLower().Contains(text) || 
                             department.Name.ToLower().Contains(text) || department.Decription.ToLower().Contains(text))
                             && ((fromAge != null ? (staff.Age > fromAge && staff.Age < toAge) : staff.Age > 0))
                             && position.Name.ToLower().Contains(namePostion) && department.Name.ToLower().Contains(nameDepartment)
                             select new
                             {
                                 idStaff = staff.Id,
                                 nameStaff = staff.Name,
                                 ageStaff = staff.Age,
                                 sexStaff = staff.Sex,
                                 salaryStaff = staff.Salary,
                                 namePosition = position.Name,
                                 nameDepartment = department.Name

                             };
            foreach (var item in listResult)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();


        }
    }
}
