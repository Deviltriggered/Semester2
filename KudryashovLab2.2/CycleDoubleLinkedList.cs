using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KudryashovLab2._2
{
    public class CycleDoubleLinkedList
    {
        private DoubleNode head;
        public CycleDoubleLinkedList()
        {
            head = new DoubleNode();
            head.Next = head;
            head.Prev = head;
        }
        public void Create(string[] dates)
        {
            DoubleNode p;
            for (int i = 0; i < dates.Length; i++)
            {
                p = new(dates[i]);
                p.Next = head;
                p.Prev = head.Prev;
                head.Prev.Next = p;
                head.Prev = p;
            }
        }
        public void InsertFirst(string data)
        {
            DoubleNode p = head.Next;
            if (p != null)
            {
                DoubleNode q = new(data);
                q.Next = p;
                q.Prev = p.Prev;
                p.Prev.Next = q;
                p.Prev = q;
            }
        }
        public void InsertLast(string data)
        {
            DoubleNode p = head.Prev;
            if (p != null)
            {
                DoubleNode q = new(data);
                q.Next = p.Next;
                q.Prev = p;
                p.Next.Prev = q;
                p.Next = q;
            }
        }
        public void InsertCurrent(string data, int index)
        {
            DoubleNode p = head.Next;
            int count = 2;
            DoubleNode q = new(data);
            while ((p.Next != head) && (count != index))
            {
                p = p.Next;
                count++;
            }
            q.Next = p.Next;
            q.Prev = p;
            p.Next.Prev = q;
            p.Next = q;
        }
        public void DeleteFirst(CycleDoubleLinkedList L)
        {
            if (Check(L))
            {
                DoubleNode p = head.Next;
                if (p != null && p != head)
                {
                    p.Prev.Next = p.Next;
                    p.Next.Prev = p.Prev;
                }
            }
            else
            { MessageBox.Show("Список пуст, операция невозможна"); }
        }
        public void DeleteLast(CycleDoubleLinkedList L)
        {
            if (Check(L))
            {
                if (head != null)
                {
                    DoubleNode p = head.Prev;
                    p.Prev.Next = p.Next;
                    p.Next.Prev = p.Prev;
                }
            }
            else
            { MessageBox.Show("Список пуст, операция невозможна"); }
        }
        public void DeleteCurrent(CycleDoubleLinkedList L, int index)
        {
            if (Check(L))
            {
                DoubleNode p = head.Next;
                int count = 2;
                while ((p != head) && (count != index))
                {
                    p = p.Next;
                    count++;
                }
                if (p != head)
                {
                    p.Next = p.Next.Next;
                    p.Prev = p.Prev.Next;
                }
            }
            else
            { MessageBox.Show("Список пуст, операция невозможна"); }
        }
        public void Destroy(CycleDoubleLinkedList L)
        {
            if (Check(L))
            {
                head = null;
            }
            else
            { MessageBox.Show("Список пуст, операция невозможна"); }
        }
        public void Handle(CycleDoubleLinkedList L, string seeking)
        {
            if (Check(L))
            {
                DoubleNode p = head.Next;
                int count = 0;
                while (p != head)
                {
                    if (p.Info.Contains(seeking))
                    {
                        DoubleNode temp = p.Next;
                        p.Prev.Next = p.Next;
                        p.Next.Prev = p.Prev;
                        p = temp;
                        count++;
                    }
                    p = p.Next;
                }
                if (count == 0)
                { MessageBox.Show("Нет элементов с заданными символами"); }
            }
            else
            { MessageBox.Show("Список пуст, операция невозможна"); }
        }
        public void Print(ListBox listbox)
        {
            listbox.Items.Clear();
            if (head != null)
            {
                DoubleNode p = head.Next;
                while (p != head)
                {
                    listbox.Items.Add(p.Info);
                    p = p.Next;
                }
            }
        }
        public static bool Check(CycleDoubleLinkedList L)
        {
            bool result = false;
            if (L.head != L.head.Next)
            { result = true; }
            return result;
        }
    }
}
