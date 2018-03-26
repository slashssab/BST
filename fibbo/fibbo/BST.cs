using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BinaryTree
    {
        private Node root;
        private int count;

        public BinaryTree()
        {
            root = null;
            count = 0;
        }
        public bool isEmpty()
        {
            return root == null;
        }

        public void insert(int d)
        {
            if (isEmpty())
            {
                root = new Node(d);
            }
            else
            {
                root.insertData(ref root, d);
            }

            count++;
        }

        public bool search(int s)
        {
            return root.search(root, s);
        }

        public bool isLeaf()
        {
            if (!isEmpty())
                return root.isLeaf(ref root);

            return true;
        }

        public void display()
        {
            if (!isEmpty())
                root.display(root);
        }

        public int Count()
        {
            return count;
        }
    }

    class Node
    {
        private int number;
        public Node rightLeaf;
        public Node leftLeaf;

        public Node(int value)
        {
            number = value;
            rightLeaf = null;
            leftLeaf = null;
        }

        public bool isLeaf(ref Node node)
        {
            return (node.rightLeaf == null && node.leftLeaf == null);

        }

        public void insertData(ref Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);

            }
            else if (node.number < data)
            {
                insertData(ref node.rightLeaf, data);
            }

            else if (node.number > data)
            {
                insertData(ref node.leftLeaf, data);
            }
        }

        public bool search(Node node, int s)
        {
            if (node == null)
                return false;

            if (node.number == s)
            {
                return true;
            }
            else if (node.number < s)
            {
                return search(node.rightLeaf, s);
            }
            else if (node.number > s)
            {
                return search(node.leftLeaf, s);
            }

            return false;
        }

        public void display(Node n)
        {
            if (n == null)
                return;

            display(n.leftLeaf);
            Console.Write(" " + n.number);
            display(n.rightLeaf);
        }
    }
    class wykonywujacy
    {
        public static void program()
        {
            BinaryTree b = new BinaryTree();
            int a = 0;
            while (a != 9)
            {
                Console.Clear();
                Console.WriteLine("Witaj, którą czynność chcesz wykonać:");
                Console.WriteLine("1.Wprowadź wartosć do drzewa");
                Console.WriteLine("2.przeszukaj drzewo");
                Console.WriteLine("3.Wyświetl drzewo");
                Console.WriteLine("9.Powrót do menu głównego");


                if (!Int32.TryParse(Console.ReadLine(), out a))
                {
                    continue;
                }

                if (a == 1)
                {
                    Console.WriteLine("Jaką wartosć chcesz wprowadzić?");
                    int q = Int32.Parse(Console.ReadLine());
                    b.insert(q);
                }
                if (a == 2)
                {
                    Console.WriteLine("Jaką wartosć chcesz znaleść?");
                    int q = Int32.Parse(Console.ReadLine());
                    b.search(q); 
                }
                if (a == 3)
                {
                    Console.WriteLine("To są wartosci w drzewie:");
                    b.display();
                }
                Console.ReadKey();
            }
        }
    }
}
