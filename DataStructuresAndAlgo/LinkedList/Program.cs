using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int data;
        public Node right;
        public Node(int data, Node right=null)
        {
            this.data = data;
            this.right = right;
        }
    }

    class Program
    {
        static Random random;
        static void InitRandom(int seed)
        {
            random = new Random(seed);
        }
        static void PrintLinkedList(Node listHead)
        {
            Node node = listHead;
            while( node != null) //why not node.right != null, because this will stop printing just before last node
            {
                Console.Write(node.data + " ");
                node = node.right;
            }
            Console.WriteLine();
        }
        static int RandomInteger(int min=1, int max=100)
        {
            return random.Next(min, max);
        }
        static int GetLength(Node node)
        {
            int length = 0;
            while(node != null)
            {
                length++;
                node = node.right;
            }
            return length;
        }

        static Node AddNodesAtBeginning(Node head, int numbers)
        {
            Node oldHead = head;
            //make a new linked List
            Node newHead = new Node(RandomInteger());
            Node temp = newHead;
            int i = 1;
            while (i < numbers)
            {
                temp.right = new Node(RandomInteger());
                temp = temp.right;
                i++;
            }
            temp.right = oldHead;
            return newHead;

        }
        static Node AddNodesAtEnd(Node head, int numbers)
        {
            int i = 0;
            Node node = head;
            while(node.right != null)
            {
                node = node.right;
            }
            //at this point we are at the last node
            while (i < numbers)
            {
                node.right = new Node(RandomInteger());
                node = node.right;
                i++;
            }
            return head;
        }
        static Node AddNodesInMiddle(Node head, int position, int numbers)
        {
            //if the position exists add node there
            //else return the same head without any change

            //Note: position can be start end or middle , i.e. anywhere
            int length = GetLength(head);
            
            
            if (position <= 0)
            {
                head = AddNodesAtBeginning(head, numbers);
            }
            else if (position >=length)
            {
                head = AddNodesAtEnd(head, numbers);
            }
            else
            {
                int i = 0;
                Node temp = head;

                while (i < position)
                {
                    temp = temp.right;
                    i++;
                }
                //Console.WriteLine("Currently at position {0}, and value = {1}", position, temp.data);
                temp.right=AddNodesAtBeginning(temp.right, numbers); //this return new head
            }

            return head;
        }
        private static Node UpdateANodeInMiddle(Node head, int updatedVal, int position)
        {
            int length = GetLength(head);
            if (position <= 0)
            {
                head = UpdateANodeFromFront(head, updatedVal);

            }
            else if (position >= length)
            {
                head = UpdateANodeAtTheEnd(head, updatedVal);
            }
            else
            {
                int i = 0;
                Node temp = head;
                while (i < position)
                {
                    temp = temp.right;
                    i++;
                }
                //Console.WriteLine("Node to be update: {0}", temp.data);
                temp.data = updatedVal;
            }
            return head;
        }

        private static Node UpdateANodeAtTheEnd(Node head, int updatedVal)
        {
            Node temp = head;
            while (temp.right != null)
            {
                temp = temp.right;
            }
            //Console.WriteLine("Node to be updated: {0}", temp.data);
            temp.data = updatedVal;
            return head;
        }

        private static Node UpdateANodeFromFront(Node head, int data)
        {
            head.data = data;
            return head;
        }

        private static Node DeleteAnyNode(Node head, int position)
        {
            int length = GetLength(head);
            if (position <= 0)
            {
                head = DeleteANodeFromFront(head);
            }
            else if (position >= length)
            {
                DeleteANodeAtEnd(head);
            }
            else
            {
                Node temp = head;
                int i = 0;
                while (i < position - 1)
                {
                    temp = temp.right;
                    i++;
                }
                //Console.WriteLine("Node to be deleted: {0}", temp.data);
                temp.right = temp.right.right;
            }
            return head;
        }

        private static Node DeleteANodeFromFront(Node head)
        {

            return head.right;
        }

        private static void DeleteANodeAtEnd(Node head)
        {
            Node temp = head;
            while (temp.right.right != null)
            {
                temp = temp.right;
            }
            temp.right = null;

        }

        private static Node ReverseList(Node head)
        {
            Node previous = head, current = head.right, next = null;
            previous.right = null;
            while (current != null)
            {
                next = current.right;
                current.right = previous;
                previous = current;
                current = next;
            }
            return previous;
        }


        static void Main(string[] args)
        {
            int num = 5, pos=5, deletePos=14, updatedVal=23, updatePos=3;
            InitRandom(11);
            Console.WriteLine("Linked List Practice: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
            
            Console.WriteLine();
            Node head = new Node(10);
            head.right = new Node(20);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));

            //Add nodes at end
            Console.WriteLine();
            Console.WriteLine("Add {0} nodes at the end.", num);
            //Add 5 random values at the end of the linked list
            head=AddNodesAtEnd(head, num);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));

            //insert nodes anywhere
            Console.WriteLine();
            Console.WriteLine("Add {0} nodes at position {1}(zero-indexed). ", num, pos);
            head=AddNodesInMiddle(head, pos, num);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));

            //insert at beginning
            Console.WriteLine();
            Console.WriteLine("Add {0} nodes at the beginning.", num);
            head = AddNodesAtBeginning(head, num);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));


            //delete node at the end
            Console.WriteLine();
            Console.WriteLine("Delete a node at the end");
            DeleteANodeAtEnd(head);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));

            //delete node in any place
            Console.WriteLine();
            Console.WriteLine("Delete a node at position: {0}(zero-indexed). ", deletePos);
            DeleteAnyNode(head, deletePos);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));

            //delete node from front
            Console.WriteLine();
            Console.WriteLine("Delete a node from the front");
            head=DeleteANodeFromFront(head);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));

            //update at head
            Console.WriteLine();
            Console.WriteLine("Update a node from the front");
            head = UpdateANodeFromFront(head, updatedVal);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));

            //update at tail
            Console.WriteLine();
            Console.WriteLine("Update a node at the end");
            head = UpdateANodeAtTheEnd(head, updatedVal);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));

            //update at any place in the middle including head or tail
            Console.WriteLine();
            Console.WriteLine("Update a node at position: {0}", updatePos);
            head = UpdateANodeInMiddle(head, updatedVal, updatePos);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));

            //reverse a linked list
            Console.WriteLine();
            Console.WriteLine("Reversing the linked List");
            head = ReverseList(head);
            PrintLinkedList(head);
            Console.WriteLine("Current Length: {0}", GetLength(head));
            Console.ReadKey();

        }

        
    }
}
