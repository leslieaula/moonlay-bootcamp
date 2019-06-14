using LearnCSharp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myCommand = new MyCommand();

            //Parallel.For(0, 100, i => myCommand.FindCalculation(i).Wait());
            //Task.WaitAll();

            //myCommand.ConsoleCommand1(1);
            //myCommand.FindCalculation(2).Wait();


            //Console.ReadKey();
            //Task.WaitAll();
            ////Parallel.For(0, 100, i => myCommand.ConsoleCommand1(i));
            //Console.ReadKey();
        }
    }

    //public class MyCommand
    //{
    //    public void ConsoleCommand(int i)
    //    {
    //        Console.WriteLine(i);
    //    }

    //    public Task ConsoleCommand1(int i)
    //    {
    //        return Task.Run(() => { Console.WriteLine(i); });
    //    }

    //    public Task<int> CalculateData(int i)
    //    {
    //        i *= 2;
    //        return Task.FromResult(i);
    //    }

    //    public async Task FindCalculation(int i)
    //    {
    //        var calculation = await CalculateData(i);
    //        System.Threading.Thread.Sleep(10000);
    //        Console.WriteLine(i);
    //        Console.ReadKey();
    //        Console.WriteLine("Hai");
    //        Console.ReadKey();
    //    }
    //}


    public class Circle : IArea, IKeliling
    {
        public Circle(double ruas)
        {
            Ruas = ruas;
        }

        public double Ruas { get; private set; }

        public double GetArea()
        {
            return Math.PI * Ruas * Ruas;
        }

        public double GetKeliling()
        {
            return 2 * Math.PI * Ruas;
        }
    }

    public interface IArea
    {
        double GetArea();
    }

    public interface IKeliling
    {
        double GetKeliling();
    }
}
