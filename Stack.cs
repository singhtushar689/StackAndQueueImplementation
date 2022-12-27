using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            Console.WriteLine("Peek" + stack.Peek());
            Console.WriteLine("__________________________");

            stack.Pop();
            foreach(int elements in stack)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("Peek" + stack.Peek());
            Console.WriteLine("___________________________");
            stack.Pop();
            foreach(int elements in stack)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine(stack.Count);
            Console.WriteLine("Peek" + stack.Peek());
            Console.WriteLine("_____________________________");
            stack.Pop();         
            Console.WriteLine(stack.Count + " elements in Stack");
   
        }
    }
}
