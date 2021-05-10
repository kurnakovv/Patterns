using Builder.Builder;
using Builder.Builder.Abstract;
using Builder.Director;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Manager();
            IComputerBuilder builder = new CheapComputer();
            director.ComputerBuilder = builder;

            #region Cheap computer
            Console.WriteLine("Cheap computer without DVD ROM:");
            director.SellComputerWithoutDVD_ROM();
            Console.WriteLine(builder.GetComputer());

            Console.WriteLine("Cheap computer with full components:");
            director.SellFullComputer();
            Console.WriteLine(builder.GetComputer());
            #endregion

            #region Exprensive Computer
            builder = new ExprensiveComputer();
            Console.WriteLine("Exprensive computer without DVD ROM:");
            director.SellComputerWithoutDVD_ROM();
            Console.WriteLine(builder.GetComputer());

            Console.WriteLine("Exprensive computer with full components:");
            director.SellFullComputer();
            Console.WriteLine(builder.GetComputer());
            #endregion

            #region Assembly
            Console.WriteLine("Assembly:");
            builder.SetCPU();
            builder.SetMotherboard();
            Console.WriteLine(builder.GetComputer());
            #endregion

            Console.ReadLine();
        }
    }
}
