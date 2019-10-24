using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // to create a list, need to create a node first and then create
            // a list
            // create a new LinkedList Node of type String and (via method) display its
            // properties
            // created a node with value of orange
            LinkedListNode<string> lln = new LinkedListNode<string>("orange");
            Console.WriteLine("display properties");
            DisplayProperties(lln);
            Console.WriteLine();
            // if you run code now, there is no list so your output would be:
            /* 
             not linked; null; null
            */

            // create linked list
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast(lln);
            Console.WriteLine("after adding node to list");
            DisplayProperties(lln);

            // more adding to linked list
            // add creates node for me
            ll.AddFirst("red");
            ll.AddLast("yellow");
            Console.WriteLine("\nafter other nodes added");
            DisplayProperties(lln);

            // traversal
            Console.WriteLine("Traversal:");
            // create new variable and set it to being the first node in the list
            LinkedListNode<string> node = ll.First;
            while(node != null)
            {
                Console.WriteLine("     {0}", node.Value);
                // this tells the loop to continue to point at the next node
                // use previous for reverse traversal
                // make sure initial value (var above) starts at the end of the list
                // ll.Last?
                node = node.Next;
            }
            Console.WriteLine();
        }

        // method that prints out properties of the node: List, Previous, Next 
        // are the four properties
        public static void DisplayProperties(LinkedListNode<string> lln)
        {
            if(lln.List == null)
                Console.WriteLine("     Node is not linked");
            else
                Console.WriteLine("     Node belongs to a linked list with {0} elements", lln.List.Count);

            if(lln.Previous == null)
                Console.WriteLine("     Previous node is null");
            else
                Console.WriteLine("     Value of previous node: {0}", lln.Previous.Value);

            if(lln.Next ==  null)
                Console.WriteLine("     Next node is null");
            else
                Console.WriteLine("     Value of next node: {0}", lln.Next.Value);
        }
    }
}
