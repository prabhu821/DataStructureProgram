using DataStructureProgram.UnOrderedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram
{
    internal class ListStack<T> where T : IComparable
    {
        public Node<T> top;
        public ListStack()
        {
            this.top = null;
        }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }

        public bool Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return true;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
            return false;
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("Value Popped is {0}", this.top.data);
            this.top = this.top.next;
        }

        public void Display()
        {
            Node<T> temp = this.top;
            Console.WriteLine("\nStack is as:");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

