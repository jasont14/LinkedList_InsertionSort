using System;
using LinkedListInsertionSort.Test;

namespace LinkedListInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTest addTest = new AddTest();

            addTest.charList.print();
            addTest.charList.InsertionSort();
            addTest.charList.print();            

            Console.WriteLine();
            addTest.stringList.print();
            addTest.stringList.InsertionSort();
            addTest.stringList.print();

            Console.WriteLine();
            addTest.intList.print();
            addTest.intList.InsertionSort();
            addTest.intList.print();

            Console.ReadKey();
        }
    }
}
