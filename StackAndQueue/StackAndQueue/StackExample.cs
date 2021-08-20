using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
   public class StackExample
    {
        public void Demo()
        {
            Console.WriteLine("LIFO --> Last In First Out");
            //Non Generic Stacks
            Stack stackObject = new Stack();
            Console.WriteLine($"Initial Capacity is {stackObject.Count}");

            stackObject.Push("First");
            stackObject.Push("Second");
            Console.WriteLine($"Capacity now {stackObject.Count}");
            Console.WriteLine($"Peek element :{stackObject.Peek()}");
            Console.WriteLine($"Capacity after Peek {stackObject.Count}");
            Console.WriteLine($"Pop element:{stackObject.Pop()}");
            Console.WriteLine($"Capacity after Pop {stackObject.Count}");
            Console.WriteLine($"Pop element:{stackObject.Pop()}");
            //Console.WriteLine($"Pop empty stack:{stackObject.Pop()}"); results in exception. Use GetEnumerator

            Stack stack = new Stack(3);
            Console.WriteLine($"Initial Capacity is {stack.Count}");

            stack.Push("First");
            stack.Push("Second");
            stack.Push(1);
            stack.Push("First");
            stack.Push("Second");
            stack.Push(1);
            Console.WriteLine($"Enumerator in Stack");
            IEnumerator enumerator = stack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            //check if stack contains the elemnt
            Console.WriteLine($"Search for First {stack.Contains("First")}");
            List<string> listData = new List<string>() { "a", "b" };
            stack.Push(listData);
            List<string> popData = (List<string>)stack.Pop();
            Console.WriteLine($"Capacity now {stack.Count}");

            //Generic Stack
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine($"Capacity of int stack {intStack.Count}");
            intStack.Clear();
            Console.WriteLine($"Capacity of int stack after Clear() {intStack.Count}");
        }
    }
}
