using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Description { get; set; }

        public Student(int id, string name, float description)
        {
            Id = id;
            Name = name;
            Description= description;
        }
    }


    public class StudentHashtable
    {
        private Hashtable table;

        public StudentHashtable()
        {
            table = new Hashtable();

            Student student1 = new Student(1, "Uesli", 10);
            Student student2 = new Student(2, "Bruno", 11);

            // Add the Student objects to the Hashtable
            table.Add(student1.Id, student1);
            table.Add(student2.Id, student2);

            // Log the entire collection to the console
            foreach (DictionaryEntry entry in table)
            {
                Student student = (Student)entry.Value;
                Console.WriteLine(student);
            }
        }
    }
}
    

    
    

