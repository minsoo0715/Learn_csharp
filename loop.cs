using System;

namespace learn_cs {
    class loop {
        public static void play() {

            //반복문 동일

            int counter = 0;
            while(counter < 10) {
                Console.WriteLine($"Hello World The Counter is {counter++}");
            }
            
            counter = 0;
            do {
                Console.WriteLine($"Hello World This Counter is {counter++}");
            }while(counter<10);

            for(int i = 0; i<10; i++) {
                Console.WriteLine(i);
            }



            
        }
    }
}