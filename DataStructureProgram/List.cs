using DataStructureProgram.UnOrderedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram
{
    internal class List<T> where T : IComparable
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into list", node.data);
        }

        public void Delete(T data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            if (head.data.Equals(data))
            {
                head = head.next;
                return;
            }
            Node<T> prev = head;
            Node<T> temp = head.next;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    prev.next = temp.next;
                    temp = null;
                    return;
                }
                prev = temp;
                temp = temp.next;
            }
        }

        public void DisplayList()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write("List elements are :" + temp.data + "\n");
                temp = temp.next;
            }
        }

        public void Search(T value)
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    Console.WriteLine("{0} is found in the list", temp.data);
                    Delete(value);
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("{0} is not found in the list", value);
                Add(value);
            }
        }
    }
}