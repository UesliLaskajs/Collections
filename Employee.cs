using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }


        public  Employee(int id,string name,string title)
        {
            Id=id;
            Name=name;
            Title=title;
        }

    }
}
