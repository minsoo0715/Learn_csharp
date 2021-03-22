using System;
using System.Linq;

namespace learn_cs
{
    class lambda
    {
        public static void play_Lambda() {
            int[] numbers = { 2, 3, 4, 5 };

        var maximumSquare = numbers.Max(x => x * x); // int[].Max()는 최댓값을 출력함
        Console.WriteLine(maximumSquare);

        var maximumValue = numbers.Max();
        Console.WriteLine(maximumValue);
        // Output:
        // 25            
            
        }
    }
}   
    

