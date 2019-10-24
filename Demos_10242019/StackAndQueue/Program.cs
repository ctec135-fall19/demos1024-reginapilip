using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region stacks
            Console.WriteLine("* STACK *");
            // stacks
            // declaration
            // empty stack:
            Stack<Student> stackOfStudents = new Stack<Student>();

            // initialization
            // push objects onto the stack
            // creating a new student object within the Push method:
            Console.WriteLine("Push");
            stackOfStudents.Push(new Student("Bill"));
            stackOfStudents.Push(new Student("Jill"));
            stackOfStudents.Push(new Student("Jack"));

            // usually use Pop and Push methods but...
            // traversal
            foreach(Student s in stackOfStudents)
            {
                // calls property from Student Class for name
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(stackOfStudents.Count);
            Console.WriteLine();

            Console.WriteLine("Pop");
            // pops
            // create a variable that holds the size of the object
            int size = stackOfStudents.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(stackOfStudents.Pop().Name);
            }
            Console.WriteLine(stackOfStudents.Count);
            Console.WriteLine();
            #endregion

            Console.WriteLine("* QUEUES *");
            Console.WriteLine("Notice the order in comparison to the stack\n");
            #region queue
            // queue
            // declaration
            Queue<Student> studentQueue = new Queue<Student>();

            Console.WriteLine("Enqueue");
            // initialization
            // put items in queue
            studentQueue.Enqueue(new Student("Bill"));
            studentQueue.Enqueue(new Student("Jill"));
            studentQueue.Enqueue(new Student("Jack"));

            // traversal
            foreach(Student s in studentQueue)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();

            Console.WriteLine("Dequeue");
            // removing from queue
            // using size variable as defined above
            size = studentQueue.Count;
            for (int i=0; i<size; i++)
            {
                Console.WriteLine(studentQueue.Dequeue().Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();
            #endregion
        }
    }
}
