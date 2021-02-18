using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int result;
            int nb1;
            Console.WriteLine("choisissez un nombre");
            result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("voulez vous additionner ce nombre ?");
            
            string answer = Console.ReadLine();

            while (answer!="non")
            {
                
                Console.WriteLine("choisissez un nombre à additionner ?");

                nb1 = Convert.ToInt32(Console.ReadLine());
                result =  nb1 + result;
                Console.WriteLine(result);

                Console.WriteLine("continuer?");
                answer = Console.ReadLine();
                


            }

            Console.WriteLine("comme vous voulez");
          
        }
    }
}
