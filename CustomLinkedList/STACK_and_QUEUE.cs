using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class stack<T> : Options
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public override void print(int count)
        {
            if (Tail is null)
            {
                Console.WriteLine("\n\nThis queue is empty");
                return;
            }
            var temp = Tail;

            Console.Write("\n\nMy stack is currently: ");
            for (int i = 0; i < count; i++)
            {
                if (Tail == null) { break; }
                Console.Write($"[{Tail.Value}]  ");
                Tail = Tail.NextNode;
            }

            Tail = temp;
        }

        public void push(T item)
        {
            if (Tail is null)
            {
                Tail = Head = new ListNode<T>(item);
            }
            else
            {
                var temp = Head;
                var newNode = new ListNode<T>(item, temp);
                Head.NextNode = newNode;
                Head = newNode;
            }
        }

        public T pop()
        {
            if (Tail is null) { return default(T); }
            else
            {
                T popVal = Head.Value;
                Head = Head.PreviousNode;
                return popVal;
            }

        }

        public T peek()
        {
            return Head.Value;
        }
    }


    abstract public class Options
    {
        public abstract void print(int count);
    }


    public class queue<T> : Options
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public override void print(int count)
        {
            if(Tail is null)
            {
                Console.WriteLine("\n\nThis queue is empty");
                return;
            }
            var temp = Tail;

            Console.Write("\n\nMy queue is currently: ");
            for (int i = 0; i < count; i++)
            {
                if (Tail == null) { break; }
                Console.Write($"[{Tail.Value}]  ");
                Tail = Tail.NextNode;
            }

            Tail = temp;
        }

        public void enqueue(T item)
        {
            if (Tail is null)
            {
                Tail = Head = new ListNode<T>(item);
            }
            else
            {
                var temp = Head;
                var newNode = new ListNode<T>(item, temp);
                Head.NextNode = newNode;
                Head = newNode;
            }
        }

        public T dequeue()
        {
            if (Tail is null) { return default(T); }
            else
            {
                T popVal = Tail.Value;
                Tail = Tail.NextNode;
                return popVal;
            }

        }

        public bool contains(dynamic item, int count)
        {
            bool condition = false;
            var temp = Tail;
            for (int i = 0; i < count; i++)
            {
                if (Tail.Value == item)
                {
                    condition = true;
                    break;
                }

                else { Tail = Tail.NextNode; }
            }
            Tail = temp;
            return condition;
        }

        public void clear()
        {
            Head = Tail = null;
        }
    }
}