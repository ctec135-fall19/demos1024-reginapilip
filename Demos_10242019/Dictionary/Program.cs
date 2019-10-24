using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* DICTIONARY*\n");
            // declaration
            // < key type, value type>
            Dictionary<string, Student> studentDictionary =
                new Dictionary<string, Student>();

            // initialization
            // two ways to do this:
                                // key      // creating a new object within method
            studentDictionary.Add("Bill", new Student("Bill1"));
                            // use key as index     // student object is value
            studentDictionary["Jill"] = new Student("Jill2");
            studentDictionary["Jack"] = new Student("Jack3");

            // traversal
            // must traverse key and/or value in separate loops
            Console.WriteLine("The first set of output is the keys\n" +
                                "the second, are the values");
            foreach(string key in studentDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            foreach(Student s in studentDictionary.Values)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
        }
    }
}
