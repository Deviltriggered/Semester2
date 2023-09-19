using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KudryashovLab2._2
{
    public class DoubleNode
    {
        private string info;
        private DoubleNode next;
        private DoubleNode prev;
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public DoubleNode Next
        {
            get { return next; }
            set { next = value; }
        }
        public DoubleNode Prev
        {
            get { return prev; }
            set { prev = value; }
        }
        public DoubleNode() { }
        public DoubleNode(string info)
        { Info = info; }
        public DoubleNode(string info, DoubleNode next, DoubleNode prev)
        { Info = info; Next = next; Prev = prev; }
    }
}
