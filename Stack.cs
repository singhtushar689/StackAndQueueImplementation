using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueImplementation
{
    public class Stack
    {
        public void DisplayStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            foreach(int elements in stack)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
