using System;

namespace learn_cs {

    class condition {
        public static void play() {

              bool condition = true;

              if(condition) {
                  Console.WriteLine($"This Value set as true");
              }else if(condition) {
                  Console.WriteLine($"This Value set as false");
              }else {
                  Console.WriteLine($"IDK about this Value");
              }
              int num = 3;
              switch (num) {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                     Console.WriteLine("Two");
                     break;
                default:
                     Console.WriteLine("IDK");
                     break;
              }
            

        }

    }
    
}