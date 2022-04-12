using Csproject.Entities;
using System;

namespace Csproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("What are your orders? ");
            Console.Write("[Y/N] - Are you cheater?  ");
            char choice = char.Parse(Console.ReadLine());
            if(choice == 'Y' || choice == 'y' )
            {
                Console.WriteLine("You reprogram the module and become the second person to beat the no-win scenario. How original of you.");
            }
            else if(choice == 'N' || choice == 'n')
            {
               Choicetwo Choiceum = new Choicetwo(); 
            }
            else
            {
                Console.WriteLine("Não seja burro capitão! Responda corretamente!");            
                Program c3 = new Program();
            }            
        }
    }    
}