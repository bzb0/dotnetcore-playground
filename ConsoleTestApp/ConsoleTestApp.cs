using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using MyExtensions;

namespace Playground
{
    public delegate int MathPower(int i);
    public delegate int Sum(int a, int b);

    class ConsoleTestApp
    {

        [DllImport("libc.so.6")]
        public static extern int getpid();

        [DllImport("libc.so.6")]
        public static extern int random();

        [DllImport("libc.so.6")]
        public static extern int kill(int pid, int signal);

        public static int MathPowerImpl(int i)
        {
            return i * i;
        }

        public static int addOne(int x)
        {
            return x + 1;
        }

        static void Main(string[] args)
        {
            // Defining a sum delegate
            Sum sumDelegate = (a, b) => a + b;
            Console.WriteLine("The sum is: " + sumDelegate(5, 10));

            // Instantiating delegate and invoking it
            MathPower myDelegate = new MathPower(MathPowerImpl);
            Console.WriteLine("MathPower(Delegate) result is: " + myDelegate(5));

            // Calculating the list sum with the Sum function
            var list = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine("The list sum is: " + list.Sum());

            // Calculating the list sum with an accumulator function 
            var aggregatedSum = new List<int> { 1, 2, 3, 4, 5 }.Aggregate((x, y) => x + y);
            Console.WriteLine("The aggregated sum is: " + aggregatedSum);

            // Creating a list, in which every element is increased by one and aggregating the list as string
            List<int> addoneResult = new List<int> { 1, 2, 3, 4, 5 }.Select(addOne).ToList();
            string listToString = addoneResult.Select(x => x.ToString()).Aggregate((x, y) => x + ", " + y);
            Console.WriteLine("The list aggregated as string: " + listToString);

            // Creating a list, in which every element is bigger than 2
            var newList = new List<int> { 1, 2, 3, 4, 5 }.Where(x => x > 2);

            // Calling an extension method
            ExtensionClass test = new ExtensionClass();
            Console.WriteLine("ToUpper (extension method): " + test.toUpperWithExtensions("small"));

            // Calling the native function getpid (Linux)
            int pid = getpid();
            Console.WriteLine("The process id of the current process is: " + pid);

            // Calling native function random (Linux)
            int rnd = random();
            Console.WriteLine("Random generated number: " + rnd);
        }
    }
}
