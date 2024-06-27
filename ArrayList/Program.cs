﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System.Collection namespace

            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            // İçerisindeki verilere erişim
            //Console.WriteLine(liste[1]);
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            // AddRange -> Birden fazla elemanı toplu halde ekleme
            Console.WriteLine("******************* Add Range **************");
            //string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            List<int> sayilar = new List<int>() { 1,8,3,7,9,92,5};
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Sort -> Sıralama
            Console.WriteLine("********* Sort **********");
            liste.Sort(); // Listeyi sıralar. int değerler arar.
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // BinarySearch -> Önce sıralanıp sonra kullanılması gerekir.
            Console.WriteLine("********* Binary Search **********");
            Console.WriteLine( liste.BinarySearch(9));

            // Reverse
            Console.WriteLine("********* Reverse **********");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);

            }

            // Clear
            Console.WriteLine("********* Clear **********");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);

            }
        }
    }
}
