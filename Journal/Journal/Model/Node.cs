using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    public class Node
    {
        Node prev;
        Node next;
        Entry entry;
        public Node()
        {
            this.next = null;
            this.prev = null;
            this.entry = null;
        }
        public Node(Node prev, Entry entry, Node next)
        {
            this.prev = prev;
            this.next = next;
            this.entry = entry;
        }

        public Entry GetEntry()
        {
            return entry;
        }

        public Node GetNext()
        {
            if (next == null)
            {
                return null;
            }
            return next;
        }
        public Node GetPrev()
        {
            if (prev == null)
            {
                return null;
            }
            return prev;
        }
        public void SetEntry(Entry entry)
        {
            this.entry = entry;
        }

        public void SetNext(Node next)
        {
            this.next = next;
        }
        public void SetPrev(Node prev)
        {
            this.prev = prev;
        }
    }
}
