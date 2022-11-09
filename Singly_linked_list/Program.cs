using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_linked_list
{
    class Program
    {
        class node
        {
            public int noMhs;
            public string nama;
            public node next;
        }

        class List
        {
            node START;

            public List()
            {
                START = null;
            }

            public void addNode()/*Method menambah sebuah node kedalam list*/
            {
                int nim;
                string nm;
                Console.Write("\nMasukkan nomer Mahasiswa: ");
                nim = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nMasukkan nama Mahasiswa: ");
                nm = Console.ReadLine();
                node nodeBaru = new node();  
                nodeBaru.noMhs = nim;
                nodeBaru.nama = nm;
            }
        }
        
        static void Main(string[] args)
        {
        }
    }
}
