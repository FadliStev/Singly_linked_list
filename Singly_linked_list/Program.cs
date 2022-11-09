using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_linked_list
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

            if (START == null || nim <= START.noMhs)/*Node ditambahkan sebagai node pertama*/
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diijinkan\n");
                    return;
                }
                nodeBaru.next = START;
                START = nodeBaru;
                return;
            }/*Menemukan lokasi node baru didalam list*/

            node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (nim >= current.noMhs))
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diijinkan\n");
                    return;
                }
                previous = current;
                current = current.next;
            }/*Node baru akan ditempatkan diantara previous dan current*/

            nodeBaru.next = current;
            previous.next = nodeBaru;
        }
        /*Method untuk menghapus node tertentu di dalam list*/
        public bool delNode(int nim)
        {
            node previous, current;
            previous = current = null;
            /*check apakah node yang dimasukkan ada di dalam list atau tidak*/
            if (Search(nim, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }

        /*Method untuk menge-check apakah node yang dimasukkan ada di dalam list*/

        public bool Search(int nim, ref node previous, ref node current)
        {
            previous = START;
            current = START;

            while ((current != null) && (nim != current.noMhs))
            {
                previous = current;
                current = current.next;
            }

            if (current == null)
                return (false);
            else
                return (true);
        }
        /*Method untuk Traverse/mengunjungi dan membaca isi list*/

        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nList Kosong. \n");
            else
            {
                Console.WriteLine("\nData di dalam list adalah : \n");
                node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.noMhs + " " + currentNode.nama + "\n");
                Console.WriteLine();
            }
        }

        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            List obj = new List();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1.Menambah Data ke dalam List");
                    Console.WriteLine("2.Menghapus Data dari dalam List");
                    Console.WriteLine("3.Melihat semia data di dalam list");
                    Console.WriteLine("4.Mencari sebuah data di dalam list");
                    Console.WriteLine("5.Exit");
                    Console.Write("Masukkan pilhan anda (1-5): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.addNode();
                            }
                            break;
                        case '2':
                            {
                                if (obj.listEmpty())
                                {
                                    Console.WriteLine("\nList Kosong");
                                    break;
                                }
                                Console.Write("\nMasukkan nomor mahasiswa yang akan dihapus: ");
                                int nim = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (obj.delNode(nim) == false)
                                    Console.WriteLine("\nData Tidak ditemukan.");
                                else
                                    Console.WriteLine("Data dengan nomor mahasiswa  " + nim + "dihapus");
                            }
                            break;
                        case '3':
                            {
                                obj.traverse();
                            }
                            break ;
                        case '4':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList kosong !");
                                    break ;
                                }
                                node previous, current;
                                previous = current = null;
                                Console.Write("\nMasukkan nomor mahasiswa yang akan dicari: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.Search(num, ref previous, ref current) == false)
                                    Console.WriteLine("\nData tidak ditemukan.");
                                else
                                {
                                    Console.WriteLine("\nData ketemu");
                                    Console.WriteLine("\nNomor mahasiswa :"+ current.noMhs);
                                    Console.WriteLine("\nNama"+ current.nama);
                                }
                            }
                            break;
                        case '5':
                            {
                                return;
                            }
                        default:
                            {
                                Console.WriteLine("\nPilihan tidak valid");
                                break;
                            }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("\nCheck nilai yang anda masukkan.");
                }
            }
        }
    }
}
