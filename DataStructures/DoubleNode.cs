using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode Previous { get; set; }

        public DoubleNode()
        {
            Next = null;
            Previous = null;
        }

        public DoubleNode(int value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }

        public void AttachBefore(DoubleNode nextnode)
        {
            if (nextnode == null)
            { throw new NullReferenceException(); }
            else
            {
                DoubleNode previousnode = nextnode.Previous;
                Next = nextnode;
                Previous = previousnode;
                nextnode.Previous = this;
                previousnode.Next = this;
            }
        }

        public void Detach()
        {
            Previous.Next = Next;
            Next.Previous = Previous;
        }
    }
}
