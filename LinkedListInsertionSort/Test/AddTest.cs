using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsertionSort.Test
{
    class AddTest
    {
        public LinkedList<int> intList;
        public LinkedList<string> stringList;
        public LinkedList<char> charList;

        public AddTest()
        {
            intList = new LinkedList<int>();
            foreach(int i in BuildIntList())
            {
                intList.add(i);
            }

            stringList = new LinkedList<string>();
            foreach(string s in BuildStringList())
            {
                stringList.add(s);
            }

            charList = new LinkedList<char>();
            foreach(char c in BuildCharList())
            {
                charList.add(c);
            }
        }

        public int[] BuildIntList()
        {
            LinkedList<int> intList = new LinkedList<int>();
            int[] ints = { 5, 4, 3, 2, 1, 10, 9, 8, 7, 6 };
            return ints;
        }

        public string[] BuildStringList()
        {
            LinkedList<string> stringList = new LinkedList<string>();
            string[] strings = { "DVD", "Song", "Album", "Reader", "Movie", "Book" };
            return strings;
        }
        
        public char[] BuildCharList()
        {
            LinkedList<char> charList = new LinkedList<char>();
            char[] chars = { 'z', 'y', 'Y', 'Z', 'c', 'd', 'b', 'a' };
            return chars;
        }
        

    }
}
