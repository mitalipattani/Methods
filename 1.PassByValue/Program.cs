using System;

namespace _1.PassByValue
{
    //program for exchanging the values for two variable
    // input : a =10 , b=5;
    // ouput : a =5 , b=10;
    class Program
    {
        //Method declaration here
        //Method will always have a name, return datatype and arguments (optional)
        //Methods means separate block for code

        public void  swap(int x, int y)
        {
            int temp = 0;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Inside the swap Method a = {0} " +
                " b= {1}", x, y);
            
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("Before method call values are" +
                "a ={0} & b ={1}", a, b);
            Program p = new Program();
            p.swap(a, b); //pass the value not reference 
            // passing a copy of variables
            Console.WriteLine("After method call values are" +
                "a ={0} & b ={1}", a, b);
            Console.Read();
        }
    }
}
