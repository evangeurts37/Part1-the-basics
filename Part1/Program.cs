using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            String FirstName = "Evan";
            string FavMovie = "The Matrix";


            Console.WriteLine("EEEEE        GGG     ");
            Console.WriteLine("E           G   G  ");
            Console.WriteLine("E           G ");
            Console.WriteLine("EEE         G GGGG  ");
            Console.WriteLine("E           G   G  ");
            Console.WriteLine("E           G   G   ");
            Console.WriteLine("EEEEE        GGG");



            Console.WriteLine($"hello my name is {FirstName.ToLower()} and my favourite movie is {FavMovie.ToLower()}.");
            FavMovie = FavMovie.ToUpper();
            Console.WriteLine(FavMovie);
            Console.WriteLine(FavMovie.Contains("THE"));
            FavMovie = FavMovie.Replace("A", "@").Replace("E", "3");
            Console.WriteLine(FavMovie);



            Console.ReadLine();
        }
    }
}
