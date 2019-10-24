using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region arrays
            // arrays
            // declaration
            // no memory associated with this bc no object was created;
            // new takes care of that
            //int[] a1;
            // 5 is size; it's fixed
            int[] a1 = new int[5];

            // EX. 1: initialization by traversal
            // always use Length for size (not 5)
            for(int i=0; i<a1.Length; i++)
            {
                // need index = i
                a1[i] = i * 10 + 1;
                // implicit: no parens - order of ops (mult. first then add)
                // explicit: add parens to ensure correct order of ops
            }

            // EX. 2 another example of initialization/declaration
            // no new keyword needed; compiler understands it's a new obj
            int[] a2 = { 1, 2, 3, 4, 5 };

            // traversal
            // this is traversing through a1 from above
            foreach(int element in a1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            #endregion

            #region lists
            // lists
            // declaration
            // using library functionality (intellisense)
            // primitive array doesn't require calling of a constructor; 
            // the rest do
            List<int> l = new List<int>();

            // initialization
            // via methods
            // this creates a list of 1,2,3
            l.Add(1);
            l.Add(2);
            l.Add(3);

            // element access
            // this replaces 2 from list above with 22
            // if you use this with an out of bounds index, you will get an error
            // need to use insert/add methods for this
            l[1] = 22;

            // some other methods
            // index goes into the parens (index, item)
            // intellisense hints at this
            // moves indexes and inserts new item
            l.Insert(2, 99);
            // removes index 1 and shifts everything appropriately
            l.Remove(1);
            l.Sort();

            // traversal
            // bc index operator available 
            // can use for loop or
            for(int i=0; i<l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.WriteLine();

            foreach(int element in l)
            {
                Console.WriteLine(element);
            }
            #endregion
        }
    }
}
