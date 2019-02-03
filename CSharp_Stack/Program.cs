using System;
using System.Collections;

namespace CSharp_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Start {nameof(CSharp_Stack)}");

            WorkWithStack_1();

            WorkWithStack_2();

            WorkWithStack_3();

            WorkWithStack_4();

            Console.WriteLine($"Complete {nameof(CSharp_Stack)}");
            Console.ReadKey();
        }

        private static void WorkWithStack_4()
        {
            //To remove all objects from a collection, we use the Clear method.
            //If we want to count the number of elements, we use the Count property:
            Stack stackCollection4 = new Stack();
            stackCollection4.Push(320);
            stackCollection4.Push("Test");
            stackCollection4.Push(10.50);

            stackCollection4.Clear();
            Console.WriteLine($"stackCollection4 Count: {stackCollection4.Count}");

            Console.ReadKey();
        }

        private static void WorkWithStack_3()
        {
            //Peek returns an object ready to exit the collection, but it doesn’t remove it:
            Stack stackCollection3 = new Stack();
            stackCollection3.Push(320);
            stackCollection3.Push("Test");
            stackCollection3.Push(10.50);

            var number = Convert.ToDouble(stackCollection3.Peek());
            Console.WriteLine($"Element returned from a collection is: {number}");

            foreach (var item in stackCollection3)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void WorkWithStack_2()
        {
            //Pop removes the element which was included last in a collection and returns it:
            Stack stackCollection2 = new Stack();
            stackCollection2.Push(320);
            stackCollection2.Push("Test");
            stackCollection2.Push(10.50);

            var number = Convert.ToDouble(stackCollection2.Pop());
            Console.WriteLine($"Element remover from a collection is: {number}");

            foreach (var item in stackCollection2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void WorkWithStack_1()
        {
            //The Push method inserts an object at the top of the collection:
            Stack stackCollection1 = new Stack();
            stackCollection1.Push(320);
            stackCollection1.Push("Test");
            stackCollection1.Push(10.50);

            foreach (var item in stackCollection1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
