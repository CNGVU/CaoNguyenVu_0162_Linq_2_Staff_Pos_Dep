using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoNguyenVu_0162_Staff_Department
{
    class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }

        public Position(int id, string  name , string description )
        {
            this.ID = id;
            this.Name = name;
            this.Decription = description;
        }
        public static List<Position> getAll()
        {
            List<Position> listPosition = new List<Position>
            {
                new Position(1,"Giam doc","asdf"),
                new Position(2,"Tro ly","asdf"),
                new Position(3,"Nhan vien","asdf"),
                new Position(4,"Truong phong","asdf"),

            };
            return listPosition;
        }
    }
}
