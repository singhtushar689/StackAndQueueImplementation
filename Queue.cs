using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueImplementation
{
    public class Queue
    {
        public void AddQueue()
        {
            Queue<int> queue = new Queue<int> ();
            queue.Enqueue(56);
            queue.Enqueue (30);
            queue.Enqueue(70);
            foreach(int elements in queue)
            {
                Console.WriteLine (elements);
            }

            Console.WriteLine("Peek" + queue.Peek());
            Console.WriteLine(queue.Count() + " Elements in Queue");
        }
    }
}
