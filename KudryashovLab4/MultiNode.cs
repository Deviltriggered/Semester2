using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KudryashovLab4
{
    public class MultiNode
    {
        private string surname;
        private double mark;
        private MultiNode snext;
        private MultiNode sprev;
        private MultiNode mnext;
        private MultiNode mprev;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public double Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public MultiNode Snext
        {
            get { return snext; }
            set { snext = value; }
        }
        public MultiNode Sprev
        {
            get { return sprev; }
            set { sprev = value; }
        }
        public MultiNode Mnext
        {
            get { return mnext; }
            set { mnext = value; }
        }
        public MultiNode Mprev
        {
            get { return mprev; }
            set { mprev = value; }
        }
        public MultiNode() { }
        public MultiNode(string surname, double mark)
        { Surname = surname; Mark = mark; }
    }
    public class MultiLinkedList
    {
        private MultiNode head;
        public MultiLinkedList()
        {
            head = new MultiNode();
            head.Snext = head;
            head.Sprev = head;
            head.Mnext = head;
            head.Mprev = head;
        }
        public void CreateMulti(string[] surnames, double[] marks)
        {
            if (head != null)
            {
                MultiNode p; MultiNode newnode;
                for (int i = 0; i < surnames.Length; i++)
                {
                    newnode = new MultiNode(surnames[i], marks[i]);
                    p = head.Snext;
                    while ((p != head) && (String.Compare(newnode.Surname, p.Surname, true)) > 0) p = p.Snext;
                    {
                        newnode.Snext = p;
                        newnode.Sprev = p.Sprev;
                        p.Sprev.Snext = newnode;
                        p.Sprev = newnode;
                    }
                    p = head.Mnext;
                    while ((p != head) && (newnode.Mark < p.Mark)) p = p.Mnext;
                    {
                        newnode.Mnext = p;
                        newnode.Mprev = p.Mprev;
                        p.Mprev.Mnext = newnode;
                        p.Mprev = newnode;
                    }
                }
            }
        }
        public void DeleteMulti(MultiNode p)
        {
            if (p != null && p != head)
            {
                p.Snext.Sprev = p.Sprev;
                p.Sprev.Snext = p.Snext;
                p.Mnext.Mprev = p.Mprev;
                p.Mprev.Mnext = p.Mnext;
            }
        }
        public void PrintSurname()
        {
            if (head != null)
            {
                MultiNode p = head.Snext;
                while (p != head)
                {
                    Console.WriteLine(p.Surname + " " + p.Mark);
                    p = p.Snext;
                }
            }
        }
        public void PrintMark()
        {
            if (head != null)
            {
                MultiNode p = head.Mnext;
                while (p != head)
                {
                    Console.WriteLine(p.Surname + " " + p.Mark);
                    p = p.Mnext;
                }
            }
        }
        static void Main(string[] args)
        {
            MultiLinkedList M = new MultiLinkedList();
            M.CreateMulti(new string[] { "Андреев", "Борисов", "Яковлев" }, new double[] { 4.6, 5.0, 4.2 });
            M.PrintSurname();
            M.PrintMark();
        }
    }
}
