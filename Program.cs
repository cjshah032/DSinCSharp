using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleList s = new SingleList();
            s.InsertFront("Hi");
            s.InsertBack("his is ");
            s.InsertBack("a singly linked ");
            s.InsertBack("list ");
            s.ReadAll();
        }
    }

    class SNode
    {
        public string Name;
        public SNode next;
        public SNode (string data)
        {
            Name = data;
            next = null;
        }
    }

    class DNode
    {
        public string Name;
        public DNode next;
        public DNode prev;
        public DNode (string data)
        {
            Name = data;
            next = null;
            prev = null;
        }
    }

    class SingleList
    {
        SNode head;

        public SingleList()
        {
            SNode head = null;
        }

        public SNode GetLastNode ()
        {
            SNode curr = head;
            while (curr.next != null)
                curr = curr.next;
            return curr;
        }

        public void InsertFront(string data)
        {
            SNode newnode = new SNode(data);
            newnode.next = head;
            head = newnode;
        }

        public void InsertBack(string data)
        {
            SNode newnode = new SNode(data);
            if (head == null)
                head = newnode;
            else
            {
                SNode last = GetLastNode();
                last.next = newnode;
            }
        }

        public void ReadAll()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            SNode current = head;
            while(current.next != null)
            {
                Console.Write($"{current.Name} -> ");
            }
            Console.WriteLine("null");
        }
    }
}
