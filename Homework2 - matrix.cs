using System;

namespace ConsoleApp1
{
    class Program
    {

                static void Main(string[] args)
        {


            // ----------This is matrix string : --------------
           
            string[][] matrix1 = new string[3][]
            {
                new string[]{"main", "up", "sub"},
                new string[]{"down", "center" , "up"},
                new string[]{"sub" , "down" , "main"}
            };

                   // use foreach loop :
            Console.WriteLine("This is a matirx of string: ");
            foreach (string[] Row in matrix1)
            {
                foreach (string Col in Row)
                {
                    Console.Write(Col + " " );
                }
                Console.WriteLine();
            }


            /*
             * This is a jagged array:
                main up sub
                down center up
                sub down main
            */

            Console.ReadKey();

        }
    }
}