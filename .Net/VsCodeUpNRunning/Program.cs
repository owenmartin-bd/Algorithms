using System;

namespace VsCodeUpNRunning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(GCD(15, 35));
        }

        public static int GCD(int a, int b){
            while(b !=0) {
                int remainder = a % b;

                a = b;
                b = remainder;
            }
            return a;
        }
    }
}
