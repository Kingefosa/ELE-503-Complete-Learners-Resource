using EngineeringStudents;
using System;

namespace EngineeringStudents
{
    class Student
    {
        // Properties
        public string Name { get; set; }
        public int ID { get; set; }
        public double GPA { get; set; }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("GPA: " + GPA);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Student object
            Student engStudent = new Student();

            // Assign values
            engStudent.Name = "Emily Clark";
            engStudent.ID = 2021001;
            engStudent.GPA = 3.8;

            // Display information
            engStudent.DisplayInfo();
        }
    }
}


//Student Information:
//Name: Emily Clark
//ID: 2021001
//GPA: 3.8
