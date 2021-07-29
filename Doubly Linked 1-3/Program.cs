using System;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace Doubly_Linked_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] File1 = System.IO.File.ReadAllLines(@"C:\Users\djole\Desktop\1.txt"); //Reads the file
                string[] File2 = System.IO.File.ReadAllLines(@"C:\Users\djole\Desktop\2.txt");
                string[] File3 = System.IO.File.ReadAllLines(@"C:\Users\djole\Desktop\3.txt");

                int[] arr1 = new int[File1.Length];
                int[] arr2 = new int[File2.Length];
                int[] arr3 = new int[File3.Length];

                int[] list1 = Array.ConvertAll(File1, int.Parse); //Convert
                int[] list2 = Array.ConvertAll(File2, int.Parse);
                int[] list3 = Array.ConvertAll(File3, int.Parse);

                DLL a = new DLL();
                DLL b = new DLL();
                DLL c = new DLL();

                if (arr1.Length > 0)
                {
                    for (int i = 0; i < list1.Length; i++)
                    {
                        DLLNode p = new DLLNode(list1[i]);
                        a.addToTail(p);
                    }

                    Console.WriteLine("Content of the first text file is: ");
                    a.print();
                    a.printMiddle();
                    a.PrintPrimes(a.head);
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("The first file is empty, error! ");
                }

                if (arr2.Length > 0)
                {
                    for (int i = 0; i < list2.Length; i++)
                    {
                        DLLNode p = new DLLNode(list2[i]);
                        b.addToTail(p);
                    }

                    Console.WriteLine("Content of the second text file is: ");
                    b.print();
                    b.printMiddle();
                    b.PrintPrimes(b.head);
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("The second file is empty, error! ");
                }

                if (arr3.Length > 0)
                {
                    for (int i = 0; i < list3.Length; i++)
                    {
                        DLLNode p = new DLLNode(list3[i]);
                        c.addToTail(p);
                    }

                    Console.WriteLine("Content of the third text file is: ");
                    c.print();
                    c.printMiddle();
                    c.PrintPrimes(c.head);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The third file is empty, error! ");
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion fail, error!!! ");
                Console.ReadLine();
            }
        }
    }
}