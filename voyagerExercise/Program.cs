using System;
using voyagerExercise.Seed;
using voyagerExercise.Services;

namespace voyagerExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //init  singleton
            var terminal = new PointOfSaleTerminal();

            //singleton cart
            //var terminal = PointOfSaleTerminal.Instance();

            //add product code if Code not exit will print product not found, accept string or char
            terminal.ScanProduct("CCCCCCCCCCCC");

            //cacualte the result
            decimal result = (decimal)terminal.CaculateTotal();

            //write result to console
            Console.Write("${0:N2}", result);

        }
    }
}
