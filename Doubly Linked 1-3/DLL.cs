using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Doubly_Linked_1_3
{
    public class DLL
    {
        public DLLNode prev;
        public DLLNode next;
        public DLLNode head;
        public DLLNode tail;

        public DLL() { head = null; tail = null; }

        public void print() //Print function
        {
            DLLNode tmp = head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.num);
                tmp = tmp.next;
            }
        }

        public void printMiddle() //Print middle node function
        {
            DLLNode slow = head;
            DLLNode fast = head;
            if (head != null)
            {
                while (fast != null && fast.next != null)
                {
                    fast = fast.next.next;
                    slow = slow.next;
                }
                Console.WriteLine("The middle node is: " + slow.num);
            }
        }

        public void addToTail(DLLNode p) //Add to tail function
        {
            if (tail == null)
            {
                tail = p;
                head = p;
                return;
            }

            tail.next = p;
            p.prev = tail;
            tail = p;
            return;
        }

        public static bool IsPrime(int n) //Method to check prime numbers
        {
            int i;
            if (!(n <= 1))
            {
                for (i = 2; i <= Math.Sqrt(n); i++)
                {
                    if ((n % i) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public void PrintPrimes(DLLNode p) //Method to print primes
        {
            DLLNode temp = p;
            int count = 0;
            Console.WriteLine("The prime numbers are: ");
            while (temp != null)
            {
                if (IsPrime(temp.num))
                {
                    count += 1;
                    Console.Write(temp.num + " ");
                    if (count == 5)
                    {
                        Console.Write("\r\n");
                        
                    }
                }
                temp = temp.next;
            }
        }
    }
}