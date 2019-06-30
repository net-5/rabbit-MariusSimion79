using System;

namespace RabbitHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit1 = new Rabbit(EyesColour.Blue, FurColour.White, Gender.Male, new DateTime(2013, 7, 23));


            Console.WriteLine("************************************************************************************");
            Console.WriteLine(rabbit1.RabbitInfo());
            Console.WriteLine(rabbit1.Move());
            Console.WriteLine(rabbit1.Sleep());
            Console.WriteLine(rabbit1.Eat());
            Console.WriteLine("************************************************************************************");

            //rabbit1.Age = 3;
            //rabbit1.Fur = FurColour.Black;      // consider ca nu se vopseste :)
            //rabbit1.Gender = Gender.Female;       // nici aici nu se schimba nimic


        }

    }
}
