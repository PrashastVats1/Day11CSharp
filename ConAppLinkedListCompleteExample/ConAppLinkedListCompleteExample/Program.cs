using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppLinkedListCompleteExample
{
    internal class Program
    {
        public static void PrintLinkedList(LinkedList<string> list)
        {
            Console.WriteLine("Linked list contains {0} elements \nElements are as follows!!", list.Count);
            var enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var element = enumerator.Current;
                Console.WriteLine(element);
            }
            {
                
            }
        }
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("RAM");
            linkedList.AddLast("ROM");
            linkedList.AddLast("CD");
            linkedList.AddLast("Printer");
            PrintLinkedList(linkedList);
            linkedList.RemoveFirst();
            Console.WriteLine("After removing first item");
            PrintLinkedList(linkedList);
            linkedList.AddFirst("Keyboard");
            Console.WriteLine("After adding item keyboard at first");
            PrintLinkedList(linkedList);
            Console.WriteLine("Enter hardware");
            string hdName = Console.ReadLine();
            if(linkedList.Contains(hdName))
            {
                Console.WriteLine("Hardware Found");
            }
            else
            {
                Console.WriteLine("Hardware not found");
            }
            Console.ReadKey();
        }
    }
}
