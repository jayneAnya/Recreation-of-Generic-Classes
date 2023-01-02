
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    public class MyQueue<T>
    {
        public ListNode<T> front, back;
        public int size { get; set; }
        public ListNode<T> Value { get; set; }
      public void IntQueue()
        {
            front = back = null;
            size = 0;
            Value = Value;
        }


        public object EnQueue(T value)
        {
            var node = new ListNode<T>();

            if (front == null)
            {
                front = back = node;
              
            }
            else
            {
                back.Next = node;
                back = node;
            }
            return size++;

        }

        public void Dequeue()
        {
       
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            ListNode<T>? current = front;
            front = front.Next;
            size--;

            if(front == null)
            {
                back = null;
            }
            Console.WriteLine($"{current.Value}");
        }
        public int Count()
        {
            return size;
        }

    }
}
