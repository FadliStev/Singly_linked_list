﻿using System;
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

                if (START == null || nim <= START.noMhs)/*Node ditambahkan sebagai node pertama*/
                {
                    if((START != null)&&(nim == START.noMhs))
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

                while((current != null)&&(nim >= current.noMhs))
                {
                    if (nim == current)
                }
            }
        }
        
        static void Main(string[] args)
        {
        }
    }
}
