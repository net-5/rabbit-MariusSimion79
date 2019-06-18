using System;

namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit1 = new Rabbit();
            Console.Write("Please enter the eyes colour: ");
            rabbit1.Eyes = Console.ReadLine();
            Console.Write("Please enter the fur colour: ");
            rabbit1.Fur = Console.ReadLine();
            Console.Write("Please enter the rabbit gender: ");
            rabbit1.Gender = Console.ReadLine();
            Console.Write("Please enter the rabbit birthdate: ");
            rabbit1.BirthDate = int.Parse(Console.ReadLine());
            Console.WriteLine("************************************************************************************");
            Console.WriteLine(rabbit1.ShowInfo());
            Console.WriteLine(rabbit1.DisplayAge());
            Console.WriteLine(rabbit1.Move());
            Console.WriteLine(rabbit1.Sleep());
            Console.WriteLine(rabbit1.Eat());
            Console.WriteLine("************************************************************************************");

        }
    }
}
