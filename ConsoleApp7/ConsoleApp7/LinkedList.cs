using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp7
{
    public class SingleLinkedList<T>
    {
        public ListNode<T> Head { get; set; }

        public int Count { get; set; }


        public int AddToEnd(T value)
        {
            if (Head == null)
            {
                Head = new ListNode<T>(value);
                Count++;
            }

            else
            {
                var current = Head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new ListNode<T>(value);
                Count++;
            }
            return Count;
        }

        public bool RemoveItem(T value)
        {
            var current = Head;
            ListNode<T> previous = null;

            while (current != null)
            {
                if (current.Next.Equals(value))
                {
                    if (previous == null)
                    {
                        Head = Head.Next;
                        Count--;
                        return true;
                    }
                    previous.Next = current.Next;
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;

            }
            return false;
        }

        public bool Check(T value)
        {
            var current = Head;
            ListNode<T> previous = null;
            while (current != null)
            {
                if (current.Next.Equals(value))
                {
                    if (previous == null)
                    {
                        Head = Head.Next;

                        return true;
                    }
                    previous.Next = current.Next;
                    return true;
                }
                previous = current;
                current = current.Next;

            }
            return false;
        }

        public object IndexPos(T value)
        {
            var count = 1;
            ListNode<T> current = Head;

            while (current != null && !current.Next.Equals(value))
            {
               current= current.Next;
                count++;
            }
            if(current == null)
            {
                return -1;
            }
            return count;

        }


    }
}
    




