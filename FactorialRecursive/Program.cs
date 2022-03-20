using System;

namespace FactorialRecursive
{
    class Program
    {
        static int fastnum = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Numnber");
            int UserNum = Int32.Parse(Console.ReadLine());

            int fact= FactorialRecursive(UserNum);
            Console.WriteLine("Factorial of  {0}  is  {1}", UserNum, fact);


        }

        public static int FactorialRecursive(int num )
        {
           

            if(num>0)
            {
                fastnum = num * FactorialRecursive(num - 1);

            }
           
            return fastnum;


        }
    }
}
