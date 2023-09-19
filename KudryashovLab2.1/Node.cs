using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KudryashovLab2
{
    public class Node
    {
        private string info;
        private Node link;
        public string Info
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
        public Node(string info)
        {
            Info = info;
        }
        public Node(string info, Node link)
        {
            Info = info;
            Link = link;
        }
    }
}
