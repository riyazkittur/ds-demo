using System;
using System.Collections;
using System.Collections.Generic;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            StackExample stackExample = new StackExample();
            //stackExample.Demo();

            QueueExample queueExample = new QueueExample();
            queueExample.Demo();
            Console.ReadLine();

        }
    }
}
