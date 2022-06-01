using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int answer;
            int remainder;

            a = 17;
            b = 4;


          answer = a / b;
            remainder = a % b;
            Console.WriteLine($"{a} / {b} is {answer} remainder {remainder}");


            
            {
                Console.WriteLine("What is the radius of your circle?");

                var radius = double.Parse(Console.ReadLine());

                var area = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");


            }





        }
    }
}

