using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KudryashovLab2
{
    public class SingleLinkedList
    {
        private Node first;
        private Node last;
        public SingleLinkedList()
        {
            first = null;
        }
        public void Create(string[] arr)
        {
            if (arr.Length == 0)
            {
                first = null;
            }
            else
            {
                Node p = new Node(arr[0], null);
                first = p; last = first;
                for (int i = 1; i < arr.Length; i++)
                {
                    Node q = new Node(arr[i], null);
                    last.Link = q;
                    last = q;
                }
            }
        }
        public void Print(ListBox listbox)
        {
            if (first != null)
            {
                Node p = first;
                while (p != null)
                {
                    listbox.Items.Add(p.Info);
                    p = p.Link;
                }
            }
        }
        public static bool Check(SingleLinkedList L)
        {
            bool result = false;
            if (L.first != null)
            { result = true; }
            return result;
        }
        public void Handle(string seeking)
        {
            Node p = first; Node prev = null; int count = 0;
            if (first.Info.Contains(seeking))
            { prev = first; first = p.Link; count++; }
            while (p.Link != null)
            {
                if (p.Info.Contains(seeking))
                {
                    if (p.Link == null)
                    { p = null; }
                    else
                    { prev.Link = p.Link; }
                    count++;
                }
                prev = p;
                p = p.Link;
            }
            if (count == 0)
            { MessageBox.Show("Нет элементов с заданными символами"); }
        }
/*        public void Handle1(string seeking)
        {
            Node p = first; Node temp;
            if (first.Info.Contains(seeking))
            { first = first.Link; }
            while (p.Link != null)
            {
                if (p.Link.Info.Contains(seeking))
                {
                    if (p.Link.Link == null)
                    { p.Link = null; }
                    else
                    { p.Link = p.Link.Link; }
                }
                p = p.Link;
            }
        }*/
        public void InsertFirst(string data)
        {
            Node p = new Node(data);
            p.Link = first;
            first = p;
        }
        public void InsertCurrent(string data, int index)
        {
            if (first != null)
            {
                Node p = new Node(data);
                int i = 0;
                if (index == 1)
                {
                    p.Link = first;
                    first = p;
                }
                else
                {
                    Node q = first;
                    while (q != null && i < (index - 2))
                    {
                        q = q.Link;
                        i++;
                    }
                    p.Link = q.Link;
                    q.Link = p;
                }
            }
        }
        public void InsertLast(string data)
        {
            if (first != null)
            {
                last = first;
                while (last.Link != null)
                    last = last.Link;
                Node p = new Node(data);
                last.Link = p;
            }
        }
        public void DeleteFirst()
        {
            if (first != null)
            { first = first.Link; }
        }
        public void DeleteCurrent(int index)
        {
            if (first != null)
            {
                Node p = first;
                int i = 0;
                if (index == 1)
                { first = first.Link; }
                else
                {
                    while (p != null && i < (index - 2))
                    {
                        p = p.Link;
                        i++;
                    }
                    p.Link = p.Link.Link;
                }
            }
        }
        public void DeleteLast()
        {
            if (first != null)
            {
                if (first.Link == null)
                    first = null;
                else
                {
                    last = first;
                    while (last.Link.Link != null)
                        last = last.Link;
                    last.Link = null;
                }
            }
        }
        public void Destroy()
        { first = null; }
    }
}
