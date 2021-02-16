using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LabBook8
{
    class Lab8Q1
    {
        Hashtable ht = new Hashtable();
        public static void HashAdd()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Enter the Element to add");
            string add1 = Console.ReadLine();
            string add2 = Console.ReadLine();
            ht.Add(add1, add2);
        }
        public static void HashSearch()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Enter the Element to search");
            string search = Console.ReadLine();
            ht.ContainsKey(search);
        }
        public static void Hashdis()
        {
            Hashtable ht = new Hashtable();
            ICollection key = ht.Keys;
            foreach (var k in key)
            {
                Console.WriteLine(k + ":" + ht[k]);
            }
        }
        public static void HashCount()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Total number of elements present"+ ht.Count);
        }
        public static void HashRem()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Enter the Element to delete");
            string rem = Console.ReadLine();
            ht.Remove(rem);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add Record in Hashtable" +
                "2.Search record" +
                "3.Display All Records" +
                "4.To display Total count of Records at any point" +
                "5.Remove any particular record");
            string c = Console.ReadLine();
            HashAdd();
            HashSearch();
            HashCount();
            Hashdis();
            HashRem();
        }
    }
}
