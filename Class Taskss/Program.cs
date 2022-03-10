using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Rashid";
            String surname = "Mammadov";
            String group = "AP204";
            int point = 95;
            Boolean isGraduated = true;
            if (point < 0 || point > 100)
            {
                Console.WriteLine("Zehmet olmasa bali 1-100 Araliginda secinnn...");
            }
            else
            {
                Student man = new Student(name, surname, group, point, isGraduated);
                man.Fullname();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                man.Graduate(point);
                man.tryExam();
            }
        }
    }
    class Student
    {
        public String name;
        public String surname;
        public String group;
        public int point;
        public Boolean isGraduated;


        public Student(String name, String surname, String group, int point, Boolean isGraduated)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.point = point;
            this.isGraduated = isGraduated;

        }
        public void Fullname()
        {
            Console.WriteLine($"Name: {name}\nSurname: {surname}\nGroup: {group}\nPoint: {point}");
        }
        public void Graduate(int point)
        {
            if (point < 51)
            {
                isGraduated = false;

            }
            else
            {
                isGraduated = true;
            }
            if (isGraduated == false) Console.WriteLine("Graduated: Student Did Not Graduate!...");
            else Console.WriteLine("Graduated: Student Is Graduated!...");
        }
        public void tryExam()
        {
            if (isGraduated == true)
            {
                if (point > 80)
                {
                    Console.WriteLine("Bal artirmaq ucun tekrar imtahanda istirak ede BiLER....");
                }
                else
                {
                    Console.WriteLine("Bal artirmaq ucun tekrar imtahanda istirak ede BILMEZ....");
                }
            }
        }
    }
}