using System;
namespace OOP
{
    internal class Program
    {
        static void Main()
        {

            Student ali=new Student();

            ali.Name = "Ali Gull";
            ali.Age = 13;
            ali.Id = 123;

            ali.ShowDetails(ali);

            Student azkar=new Student();
            Console.WriteLine("________________________ \n");
            azkar.Name = "Azkar Ul Hassan";
            azkar.Age = 19;
            azkar.Id = 1234;
            azkar.ShowDetails(azkar);


            //Code  ended here ........
            Console.ReadLine();
        }
    }
}
