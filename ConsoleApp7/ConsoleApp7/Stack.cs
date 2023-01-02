using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class StackT <T>
    {
       ListNode<T> top;
       ListNode<T> newNode;
       int count = 0;

       public void Stack() 
        { 
            top = null;
        }

        public bool IsEmpty()
        {
            if(top == null)
            {
                return true;
            }
            return false;
        }

        public void PushT(T item)
        {
            newNode= new(item);
            if(top == null)
            {
                newNode.Next = null;
            }
            else
            {
                newNode.Next = top;
            }
            top= newNode;
            count++;
        }

        public void PopT()
        {
            if(top == null)
            {
                Console.WriteLine("Stack Underflow. Already deleted last item");
            }
            else
            {
                Console.WriteLine($"{top.Value}");
                count--;
            }
            top = top.Next;
        }

        public int SizeQue()
        {
            return count;   

        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow.");
            }
            Console.WriteLine($"{top.Value}");
        }


    }
}
