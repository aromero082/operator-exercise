using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me a number");
            int a = 18;
            Console.WriteLine(--a);
            //Outpus 17

            Console.WriteLine("give me a number");
            int b = 4;
            Console.WriteLine(b--);
            //Outpus 4

            
            int quotient = a/b;
            Console.WriteLine(a=6/2);
            //If the initial value stored in a is 6. Then (a/=2)=3.

            
            int remainder = a % b;
            Console.WriteLine(a %= b);
            //If the initial value stored in a is 6. Then (a%=2)=0.

            if (a == 17 && b == 4) ;
            Console.WriteLine("17 / 4 is 4 remainder 1");
            
           

        } 
     
    }
}
 