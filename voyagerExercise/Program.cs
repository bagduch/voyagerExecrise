using System;
using voyagerExercise.Seed;
using voyagerExercise.Services;

namespace voyagerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var terminal = new PointOfSaleTerminal();
            terminal.ScanProduct("CCCCCCCC");
            decimal result = (decimal)terminal.CaculateTotal();

            Console.Write(result);

        }
    }
}
