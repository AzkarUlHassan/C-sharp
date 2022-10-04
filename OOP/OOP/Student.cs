using System;
namespace OOP
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void ShowDetails(Student ali)
        {

        Console.WriteLine("The name of Student is \nThe age of student is {1}\nThe ID of student is {2}",ali.Name,ali.Age,ali.Id);


            

        }

    }
}

