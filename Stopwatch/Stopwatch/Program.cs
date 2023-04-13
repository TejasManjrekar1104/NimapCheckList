using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //create stopwatch to check time taken by program to excute.
            Stopwatch stopwatch = new Stopwatch();

            //to start the stopwatch
            stopwatch.Start();

            for(long i = 0; i<=1000000; i++)
            {
                Console.Write(i+" ");
            }

            //to stop the stopwatch
            stopwatch.Stop();

            Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
        }
    }
}
