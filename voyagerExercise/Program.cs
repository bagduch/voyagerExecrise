using System;
using voyagerExercise.Seed;
using voyagerExercise.Services;

namespace voyagerExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //init Terminal 
            var terminal = new PointOfSaleTerminal();

            //add product code if Code not exit will print product not found, accept string or char
            terminal.ScanProduct("CCCCCCC");

            //cacualte the result
            decimal result = (decimal)terminal.CaculateTotal();

            //write result to console
            Console.Write("${0:N2}", result);

        }
    }
}
