using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_part2
{
    public class Student
    {
        int Roll_Number;
        string Name;
        string Class;
        int Semester;
        //string Branch;
        int[] Marks = new int[5];


        public Student()
        {
            Console.WriteLine("Enter Name of the Student: \n");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter RollNo.: \n");
            this.Roll_Number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Class: \n");
            this.Class = Console.ReadLine();
            Console.WriteLine("Enter Semester: \n");
            this.Semester = Char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks Of Each Subject n");

            for (int i = 0; i < 5; i++)
            {
                this.Marks[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public void Display()
        {
            Console.WriteLine("Name of Student : " + Name);
            Console.WriteLine("Roll Number : " + Roll_Number);
            Console.WriteLine("Class : " + Class);
            Console.WriteLine("Semester : " + Semester);
            Console.Write("Result : ");
            Boolean t = false;
            int total = 0;
            int average;

            for (int i = 0; i < 5; i++)
            {
                total += Marks[i];

                if (Marks[i] < 50)
                {
                    t = true;
                }
            }

            average = total / 5;

            if (t)
            {
                Console.WriteLine("Student has Failed");
            }
            else if (average > 45 && average < 60)
            {
                Console.WriteLine(" Student has Fail");
            }
            else
            {
                Console.WriteLine("Student has Passed");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Display();

            Console.ReadLine();


        }
    }
}