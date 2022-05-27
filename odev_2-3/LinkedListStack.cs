using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_3
{
    public class LinkedListStack 
    {
        public object[] kelimeler;
            LinkedListNode top;

            public LinkedListStack()
            {
                this.top = null;
            }


        public LinkedListNode GetNode(object data)
        {
            LinkedListNode node = new LinkedListNode(data.GetHashCode());
            return node;
        }
        public void Push(object data)
        {
            LinkedListNode newNode = GetNode(data);
            if (top == null)
            {
                top = newNode;
                return;
            }
            newNode.next = top;
            top = newNode;

        }
        public object Peek()
        {
            if (top != null)
            {
                return top.data;
            }
            return -1;
        }
        public object Pop()
        {
            object peek = -1;
            if (top != null)
            {
                peek = top.data;
                top = top.next;
            }
            return peek;
        }

        public Boolean isEmpty()
        {
            return top == null ? true : false;
        }


    }
}
