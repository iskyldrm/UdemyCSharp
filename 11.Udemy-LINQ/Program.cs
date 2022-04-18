using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _11.Udemy_LINQ
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<Part> parts = new List<Part>();

            // Add parts to the list.
            parts.Add(new Part() { PartName = "crank arm", PartId = 1334 });
            parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

            // Write out the parts in the list. This will call the overridden ToString method
            // in the Part class.
            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                //Console.WriteLine(aPart);
            }


            var query = from x in parts
                        group x by x.PartId into g
                        select g;

            foreach (var part in query)
            {
                Console.WriteLine(part.Key);
            }


        }
    }
}
