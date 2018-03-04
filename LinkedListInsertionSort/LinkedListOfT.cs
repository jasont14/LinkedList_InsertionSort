using System;

namespace LinkedListInsertionSort
{
    public class LinkedList<T>
    {
        class Node
        {
            public T value;
            public Node next;
        }

        Node head;
        Node tail;

        public LinkedList()
        {
        }

        public void add(T value)
        {
            Node n = new Node();
            n.value = value;

            if (head == null)
            {
                head = n;
            }
            else if (tail == null)
            {
                tail = n;
                head.next = tail;
            }
            else
            {
                tail.next = n;
                tail = n;
            }            
        }

        public void InsertionSort()
        {
            Node priorToEval = head;

            //Since first list item is trivally sorted start eval at start.next
            Node eval = priorToEval.next;

            while (eval != null)
            {
                Node priorToCurr = null;
                Node curr = head;

                //compare eval node to sorted portion of list and find insertion point, if any.
                while (TestOrder(eval.value, curr.value) > 0 && curr != null)
                {
                    priorToCurr = curr;
                    curr = curr.next;
                }

                //if it returns to itself next.
                if (eval == curr)
                {
                    priorToEval = priorToEval.next;
                }
                else
                {
                    //Remove link current location
                    priorToEval.next = eval.next;                   

                    //Insert link after
                    eval.next = curr;

                    //Insert link before
                    //before may not exist if at head.  Check.
                    if (priorToCurr != null)
                    {
                        priorToCurr.next = eval;
                    }
                    else
                    {
                        head = eval;
                    }
                }

                //check for tail
                if (priorToEval.next == null)
                {
                    tail = priorToEval;
                }

                eval = priorToEval.next;
            }
        }

        private int TestOrder(T item1, T item2)
        {
            int result = 99;

            //Cast as IComparables to use CompareTo for generics. Allows reuse code for all types.
            IComparable i1 = (IComparable)item1;
            IComparable i2 = (IComparable)item2;

            if (i1.CompareTo(i2) < 0)
            {
                result = -1;                //Preceeds
            }

            else if (i1.CompareTo(i2) == 0)
            {
                result = 0;                 //Equal
            }

            else if (i1.CompareTo(i2) > 0)
            {
                result = 1;                 //follows
            }

            return result;
        }

        public void print()
        {
            Node temp = head;
            Console.WriteLine();
            while(temp != null)
            {
                Console.Write(temp.value.ToString() + "\t");
                temp = temp.next;
            }
        }
    }
}
