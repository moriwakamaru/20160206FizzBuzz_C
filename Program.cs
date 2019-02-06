using System;

namespace _20190206FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数を入力してください");
            int number = int.Parse(Console.ReadLine());

            for(int i=1;i<=number;i++)
            {
                if(i%5<=0&&i%3<=0)
                {
                    Console.Write("FizzBuzz");

                }else if(i%3<=0)
                {
                    Console.Write("Fizz");
                }
                else if (i % 5 <= 0)
                {
                    Console.Write("Buzz");
                }else
                {
                    Console.Write(i);
                }
                Console.Write(",");
            }
                
        }
    }
}
