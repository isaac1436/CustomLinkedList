
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class CustomLinkedList<T>
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public ListNode<T> CurrNode { get; set; }

        public void AddItem(T item)
        {
            if (Head is null)
            {
                Head = Tail = new ListNode<T>(item);
            }
            else
            {
                var temp = Tail;
                var newNode = new ListNode<T>(item, temp);
                Tail.NextNode = newNode;
                Tail = newNode;
            }
        }

        public void AddNode(ListNode<T> node)
        {
            if (Head is null)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.NextNode = node;
                Tail = node;
            }

        }

        public T AddFirst(int count)
        {
            dynamic sum = 0;
            var temp = Head;
            for (int i = 0; i < count; i++)
            {
                sum += Head.Value;
                Head = Head.NextNode;

            }
            Head = temp;
            return sum;
        }

        public T AddLast(int count)
        {
            dynamic sum = 0;
            var temp = Tail;
            for (int i = 0; i < count; i++)
            {
                sum += Tail.Value;
                Tail = Tail.PreviousNode;
            }
            Tail = temp;
            return sum;
        }

        public int find(dynamic node)
        {
            int indexof = -1;
            var temp = Head;

            for (int i = 0; ; i++)
            {
                if (Head.Value == node)
                {
                    indexof = i;
                    break;
                }

                else if (Head.Value == null)
                {
                    break;
                }

                Head = Head.NextNode;
            }
            Head = temp;
            return indexof;
        }

        public void remove(dynamic node, int totalCount)
        {
            var temp = Head;

            for (int i = 0; ; i++)
            {
                if (Head.Value == node)
                {
                    for (int j = i; j < totalCount-1; j++)
                    {
                        Head.Value = Head.NextNode.Value;

                        Head = Head.NextNode;
                    }
                    break;
                }

                else
                {
                    Head = Head.NextNode;
                }
            }

            Head = temp;

        }


        public void clear()
        {
            Head = Tail = null;
        }

    }
}

