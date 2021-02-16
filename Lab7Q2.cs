using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBook7
{
    class Lab7Q2
    {
        ArrayList al = new ArrayList();
        public static void ALAdd()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Enter the Element to add");
            string add1 = Console.ReadLine();
            al.Add(add1);
        }
        public static void ALSearch()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Enter the Element to search");
            string search = Console.ReadLine();
            for (int i = 0; i < al.Count; i++)
            {
                if (al.Equals(search))
                {
                    Console.WriteLine(search);
                }
            }
        }
        public static void ALRem()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Enter the Element to delete");
            string rem = Console.ReadLine();
            al.Remove(rem);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add Product" +
                "2.Delete" +
                "3.Search" +
                "4.Save");
            string c = Console.ReadLine();
            /*switch(c)
            {
                //case 1:
                    ALAdd();
               // case 2:
                    ALRem();
                //case 3:
                    ALSearch();
                //default:
                    //Console.WriteLine('Enter the valid Option');
            }*/
        ALAdd();
        ALRem();
        ALSearch();
    }
    }
}
