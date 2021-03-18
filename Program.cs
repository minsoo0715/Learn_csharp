using System;

namespace learn_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //출력함수 Console.WriteLine(string? value)

            string name = "홍길동"; //var으로 타입 추론 가능
            string message = $"My name is {name}"; // 보간 문자열

            string input = Console.ReadLine(); //입력 받음 
            Console.WriteLine($"input is {input}"); //보간 문자열은 일반 string 형과 동일하게 WriteLine 가능

           Console.WriteLine(string.Format("My name is {0}", name)); //String.format("str", ...) 형식이고 {n}은 n-1번째 매개 변수를 뜻함..
        /*
        Ex) 
        var A = 1;
        var B = 2;
        var C = 3;
        String.format("{0} + {1} = {2}", A, B, C); 
        output : "1 + 2 = 3"
        */
            //반복문 동일
            for(int i = 0; i<10; i++) {
                Console.WriteLine(i);
            }
        }
    }
}
