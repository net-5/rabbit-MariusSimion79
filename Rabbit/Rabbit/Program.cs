using System;

namespace RabbitHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit1 = new Rabbit(EyesColour.blue, FurColour.white, Gender.male, 2016);


            Console.WriteLine("************************************************************************************");
            Console.WriteLine(rabbit1.RabbitInfo());
            Console.WriteLine(rabbit1.Move());
            Console.WriteLine(rabbit1.Sleep());
            Console.WriteLine(rabbit1.Eat());
            Console.WriteLine("************************************************************************************");








        }

    }
}
