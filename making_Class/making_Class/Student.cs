using System;
namespace making_Class
{
    internal class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Show(Student Student)
        {
            Console.WriteLine("The Name is {0}\nThe Age is {1}\nThe Id is {2},", Student.Name, Student.Age, Student.Id);
        }
    }
}
