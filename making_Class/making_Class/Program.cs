using System;
namespace making_Class
{
    public class Program
    {
        static void Main()
        {
            Student Ali = new Student();
            Ali.Name = "Ali Raza";
            Ali.Age = 29;
            Ali.Id = 0934;
           
            Ali.Show(Ali);
            Console.WriteLine("____________________________________\n");
            Student Aneel=new Student();
            Aneel.Name = "Aneel Ahmed";
            Aneel.Age = 29;
            Aneel.Id = 9798137;
            Aneel.Show(Aneel);
                Console.WriteLine("____________________________________\n");
            Student Bell =new Student();
            Bell.Name = "Bell George";
            Bell.Age = 29;
            Bell.Id = 9687879;
            Bell.Show(Bell);
            Console.WriteLine("____________________________________\n");
            Student Center =new Student();
            Center.Name = "Center Ahmed ";
            Center.Age = 29;
            Center.Id = 85674343;
            Center.Show(Center);
            Console.WriteLine("____________________________________\n");





            Console.ReadLine();
        }
    }
}
