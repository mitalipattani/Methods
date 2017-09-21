using System;

namespace _3.OptionalParameters
{
    class Program
    {
        //optional parameters
        //if you dnt pass the parameters in function call 
        //it take the optional paramatere value
        public  void PrintNumber(int start=0, int end =20)
        {
            for(int i= start; i<=end;i++)
            {
                Console.Write("{0}  ", i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.PrintNumber();
            p.PrintNumber(5, 10);
            p.PrintNumber(15);
            p.PrintNumber(end: 40, start: 35);
            Console.Read();
        }
    }
}
