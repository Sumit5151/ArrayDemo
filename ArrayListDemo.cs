using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayDemo
{
    internal class ArrayListDemo
    {

        public void ArrayListTest()
        {
            int[] num = new int[10];
            num[0] = 10;
            num[1] = 20;

            ArrayList arrarylist = new ArrayList();

            Console.WriteLine(arrarylist.Capacity);

            arrarylist.Add(10);

            Console.WriteLine(arrarylist.Capacity);

            arrarylist.Add(20);
            arrarylist.Add("Amit");
            arrarylist.Add("Amit@gmail.com");


            Console.WriteLine(arrarylist.Capacity);

            arrarylist.Add("200000");

            Console.WriteLine(arrarylist.Capacity);
            arrarylist.Add("200000");


            Console.WriteLine( arrarylist[3]);

             
            int result = Convert.ToInt32(arrarylist[0]) + Convert.ToInt32(arrarylist[1]);


            Console.WriteLine(result);




            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(10);
            //arrayList.Add(20);
            //arrayList.Add(30);
            //arrayList.Add(40);

            //arrayList.Insert(2, 25);
           
            //arrayList.RemoveAt(2);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

        }


        public void HastTableTest()
        {
            Hashtable hashtable = new Hashtable();

            //Console.WriteLine("Name".GetHashCode());
            //Console.WriteLine("Email".GetHashCode());


            hashtable.Add("Name","sumit");
            hashtable.Add("Email","Sumit@gmail.com");
            hashtable.Add("RollNo",51);
            hashtable.Add("Age",21);
            hashtable.Add("Address","Pune");
            hashtable.Add("PanCard","fjljvvljvldj");
            hashtable.Add("AdharCard","11212121212121");




            //foreach (var key in hashtable.Keys)
            //{
            //    Console.WriteLine(key);
            //}


            //foreach (var value in hashtable.Values)
            //{
            //    Console.WriteLine(value);
            //}


            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine(key +" "+hashtable[key]);
            }

            //Console.WriteLine(hashtable["PanCard"]);
        }


        public void ListDemo()
        { 
            
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add(40);




            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            numbers.Insert(2, 25);
            numbers.RemoveAt(3);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            List<string>  Names = new List<string>();
        }
    }
}
