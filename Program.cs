using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enjoy this automatic calculator.");
            var x = 5;
            var y = 7;
            var answer = Add(x, y);
            var a = 5.0m;
            var b = 7.0m;
            var decimalAnswer = Add(a, b);
            var thirdAnswer = Add(0, 0, true);
            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);


        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isCheck)
        {
            var sum = a + b;
            
            if(isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        
    }
}
