using System;
using System.Collections;

namespace Sess1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListDemo();
            HashtableDemo();
        }

        private static void HashtableDemo()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "abc");
            hashtable.Add(2, "pqr");
            hashtable.Add(3, "xyz");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine("{0} : {1}",item.Key,item.Value);
            }
        }

        private static void ArrayListDemo()
        {
            ArrayList arrayList = new ArrayList(5);
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.AddRange(new int[] { 4, 5, 6 });
            arrayList.Add("Hi");
            arrayList.Remove("Hi");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
