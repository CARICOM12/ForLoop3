using System;

namespace ForLoop3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int count = 0;
            for(int x = -80; x >= -100; x = x - 2) // вывод программы с "шагом" два (x =-2) alternative to x = x - 2
            {
                Console.WriteLine("This is negative number: " + x);
                count++;
            }

            Console.WriteLine(count);
            /*бесконечный цикл минусовый
             * 
             * 
             * Operator Meaning
             < Less than
             <= Less than or equal to
             > Greater than
             >= Greater than or equal to
             = = Equal to
             != Not equal  
             Сделать что бы работало 
             */


            for (int i = 0; i <= 100; Console.WriteLine(" Current i = {0}", i++)) 
           {
               Console.WriteLine("This is the number: " + i);
           }
        }
    }
}
