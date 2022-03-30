using System;
using System.Collections;
using System.Collections.Generic;

namespace _2.Udemy_Collection_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);   
            arrayList.Add(3);   
            arrayList.Add(4);   
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add(7);
            arrayList.Add(8);
            arrayList.Add(9);
            arrayList.Add(10);
            arrayList.Add(11);
            arrayList.Add(12);
            arrayList.Add(13);
            arrayList.Add(14);
            arrayList.Add(15);
            arrayList.Add(16);
            arrayList.Add(17);

            Console.WriteLine("\n\nCount: "+arrayList.Count);
            Console.WriteLine("\nCapacity: "+arrayList.Capacity);



            //Hastable-- dictionary tanımlamasının dizi hali
            //LİFO LAST in first output 
            Hashtable hashtable = new Hashtable();

            hashtable.Add(1, 1);
            hashtable.Add(2, 2);
            hashtable.Add(3, 3);
            hashtable.Add(4, 4);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("\n\n");


            // list ve dictionary ler generi yani düzenli yapılardı 
            //unboxing işlemine gerek duymazlar
            //tiplerinin belirtilmesi zorunludur
            List<int> ts = new List<int>();


            ts.Add(1);
            ts.Add(2);
            ts.Add(3);
            //ts.Add("kalem"); // integerdan farklı değer atılamaz bu da un boxing yapılmasına gerek yok demektir. 
            //çümkü tek tip arasından veri tür ayıklamaya gerek yoktur.

            foreach (var item in ts)
            {
                Console.WriteLine(item);
            }

            ts.RemoveRange(1, 2);
            Console.WriteLine("\n\n");

            foreach (var item in ts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
            Dictionary<int, int> map = new Dictionary<int, int>();  
            map.Add(1, 1);
            map.Add(2, 2);
            map.Add(3, 3);

            foreach (var item in map)
            {
                Console.WriteLine(item.Value.ToString());
            }



        }
    }
}
