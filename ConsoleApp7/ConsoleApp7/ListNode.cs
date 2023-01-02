using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp7
{
    public class ListNode<T> 
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }
        public int value { get; internal set; }

        public ListNode(T value)
        {
            Value = value;
            Next = Next;
        }

        public ListNode()
        {
        }
    }
}
