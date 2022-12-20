using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStructure
{
    internal class Node
    {
        public int id;

        public int x;
        public Node next;
        public Node(int id)
        {
            this.id = id;
        }
    }

    public class LinkedList
    {
        internal Node head;
        internal void Add(int id)
        {
            Node node = new Node(id);
            node.id= id;
            node.next = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                //Node temp = head;
                while (head.next != null)
                {
                    head = head.next;
                }
                head.next = node;
            }
            Console.WriteLine("{0} is inserted int linked list", node.id);

        }
        
        internal void display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.id + " ");
                temp = temp.next;
            }
            Console.WriteLine(" ");
        }
        
        //Size of function
        internal int size()
        {
            int count = 1;
            Node temp = head;
           while( temp.next != null)
            {
                temp = temp.next;
                count++;
             }
            Console.WriteLine("_________");
                Console.WriteLine("Size of linked list :"+count);
            return count;
        }

        //Searching of a Word Function

        public void searchData()
        {
            Node temp = head;
            int count = 0;
            Console.WriteLine("enter a number to search :");
            int s=Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            while(temp.next!= null)
            {
                count++;
                if (temp.id == s)
                {
                    Console.WriteLine("number is found at " + count);
                    flag++;
                    break;
                }temp = temp.next;
            }
            if (flag == 1)
            {
                removeData(count);
            }
            else
            {
                Add(s);
                Console.WriteLine("After Adding a list");
                display();
            }
        }

        //removeWord from a linked list

        void removeData(int count)
        {
            Node temp = head;
            if (count == 1)
            {
                head=head.next;
                Console.WriteLine("After Deleting list is :");
                display();
            }
            else
            {
                for(int i = 0; i < count - 1; i++)
                {
                    temp = temp.next;
                }
                temp.next = temp.next.next;
                Console.WriteLine("After Deleting list is :");
                display();
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
          LinkedList linkedlist = new LinkedList();
            linkedlist.Add(17);
            linkedlist.Add(26);
            linkedlist.Add(31);
            linkedlist.Add(54);
            linkedlist.Add(77);
            linkedlist.Add(93);
            linkedlist.display();
            linkedlist.size();
            linkedlist.searchData();
            //linkedlist.removeData();
           //// linkedlist.SearchItem(26,1);
        }
    }
}
