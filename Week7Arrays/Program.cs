using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = { "võileib juustuga", "jogurt", "banaan", "peekon", "muna", };

            food[1] = "piim";
            food[3] = "viinerid";

            
            Console.WriteLine("Menüüs:");
           
            
            for(int i = 0; i < food.Length; i++)
            {


                Console.WriteLine(food[i]);
            }
            Console.WriteLine("vali toit (sisesta number 1 - 5:");
            int userChoice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Oled valinud {food[userChoice]} ");



        }
    }
}
