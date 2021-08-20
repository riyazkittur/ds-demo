using System;
using System.Collections;
using System.Text;

namespace StackAndQueue
{
   public class QueueExample
    {
        public void Demo()
        {
            Console.WriteLine("FIFO --> First In First Out");

            Queue queueDemo = new Queue();
            queueDemo.Enqueue(1);
            queueDemo.Enqueue("Hello");
            queueDemo.Enqueue('a');
            queueDemo.Enqueue("Ind");
            queueDemo.Enqueue("Eng");
            queueDemo.Enqueue("Aus");
            Console.WriteLine($"capacity is {queueDemo.Count}");
            Console.WriteLine($"Peek first : {queueDemo.Peek()}");

            Console.WriteLine($"capacity after peek {queueDemo.Count}");
            Console.WriteLine($"dequeue first : {queueDemo.Dequeue()}");
            Console.WriteLine($"count after dequeue  :{queueDemo.Count}");

            var enumerate = queueDemo.GetEnumerator();
            while (enumerate.MoveNext())
            {
                Console.WriteLine(enumerate.Current);
            }
            

            queueDemo.Clear();
            Console.WriteLine($"count after clear :{queueDemo.Count}");
        }

    }
}
