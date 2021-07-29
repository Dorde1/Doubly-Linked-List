using System;
using System.Collections.Generic;
using System.Text;

namespace Doubly_Linked_1_3
{
    public class DLLNode
    {
        public int num;
        public DLLNode prev;
        public DLLNode next;

        public DLLNode(int num)
        {
            next = null;
            prev = null;
            this.num = num;
        }
    }
}