using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KudryashovLab4._5
{
    public class Node
    {
        private int info;
        private Node link;
        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public Node Link
        {
            get { return link; }
            set { link = value; }
        }
        public Node() { }
        public Node(int info)
        {
            Info = info;
        }
        public Node(int info, Node link)
        {
            Info = info;
            Link = link;
        }
    }
    public class RecursiveList
    {
        private Node first;
        public Node First
        {
            get { return first; }
            set { first = value; }
        }
        public RecursiveList()
        {
            first = null;
        }
        public Node CreateRecursive(int nodeCount)
        {
            Node first;
            if (nodeCount == 0)
            { first = null; }
            else
            {
                Console.Write("Введите значение поля: ");
                int data = int.Parse(Console.ReadLine());
                first = new Node(data);
                first.Link = CreateRecursive(nodeCount - 1);
            }
            return first;
        }
        public void PrintFront(Node first)
        {
            if (first != null)
            {
                Console.WriteLine(first.Info);
                PrintFront(first.Link);
            }
        }
        public void PrintBack(Node first)
        {
            if (first != null)
            {
                PrintBack(first.Link);
                Console.WriteLine(first.Info);
            }
        }
        public int Count(Node first)
        {
            int count;
            if (first == null)
            {
                count = 0;
            }
            else
            {
                count = Count(first.Link) + 1;
            }
            return count;
        }
        static void Main(string[] args)
        {
            RecursiveList L = new RecursiveList();
            L.First = L.CreateRecursive(5);
            Console.WriteLine(L.Count(L.First));
        }
    }
}
