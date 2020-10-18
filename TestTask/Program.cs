using System;
using System.Collections.Generic;
using Statistics;
namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> list = MovingAverage.getMovingAverage(5);
            foreach(float item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
