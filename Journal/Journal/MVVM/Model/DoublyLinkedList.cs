using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    public class DoublyLinkedList
    {
        Node head, tail;
        int size;

        public DoublyLinkedList()
        {
            this.head = new Node();
            this.tail = new Node();
            this.size = 0;

            head.SetNext(tail);
            tail.SetPrev(head);

            Entry noEntry = new Entry();
            head.SetEntry(noEntry);
            tail.SetEntry(noEntry);
        }

        public Node GetHead()
        {
            return head;
        }
        public Node GetTail()
        {
            return tail;
        }
        public int GetSize()
        {
            return size;
        }

        public bool Insert(Entry entry)
        {
            if (head != null && tail != null)
            {
                Node node = new Node(tail.GetPrev(), entry, tail);
                tail.GetPrev().SetNext(node);
                tail.SetPrev(node);
                size++;

                return true;
            }
            return false;
        }

        public Node Find(int id)
        {
            Node currentnode = head;
            for (int i = 0; i < size; i++)
            {
                currentnode = currentnode.GetNext();
                if (id == currentnode.GetEntry().GetEntryNum())
                {
                    return currentnode;
                }
            }

            return null;
        }

        public bool Remove(Node node)
        {
            if (node != head || node != tail)
            {
                node.GetPrev().SetNext(node.GetNext());
                node.GetNext().SetPrev(node.GetPrev());
                node = null;
                size--;
                return true;
            }
            return false;
        }

        public bool ChangeOrder(Node node, Node newprevnode)
        {

            if (node != newprevnode && node != null)
            {
                node.GetPrev().SetNext(node.GetNext());
                node.GetNext().SetPrev(node.GetPrev());

                node.SetPrev(newprevnode);
                node.SetNext(newprevnode.GetNext());

                newprevnode.GetNext().SetPrev(node);
                newprevnode.SetNext(node);

                return true;
            }

            return false;
        }

        public void PrintDLL()
        {
            Node currentnode = head.GetNext();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(currentnode.GetEntry());
                currentnode = currentnode.GetNext();
            }
        }
    }
}
