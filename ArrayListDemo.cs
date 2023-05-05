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


            Console.WriteLine(arrarylist[3]);


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


            hashtable.Add("Name", "sumit");
            hashtable.Add("Email", "Sumit@gmail.com");
            hashtable.Add("RollNo", 51);
            hashtable.Add("Age", 21);
            hashtable.Add("Address", "Pune");
            hashtable.Add("PanCard", "fjljvvljvldj");
            hashtable.Add("AdharCard", "11212121212121");




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
                Console.WriteLine(key + " " + hashtable[key]);
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


            List<string> Names = new List<string>();
        }



        public void ListDemo1()
        {



            List<Teacher> teachers = new List<Teacher>();

            Teacher teacher1 = new Teacher(1, "Umesh", "Male",2000);
            teachers.Add(teacher1);
            Teacher teacher2 = new Teacher(2, "Amol", "Male",4333);
            teachers.Add(teacher2);
            Teacher teacher3 = new Teacher(3, "Dnyaneshwar", "Male",2233);
            teachers.Add(teacher3);
            Teacher teacher4 = new Teacher(4, "Sumit", "Male",222);
            teachers.Add(teacher4);


            teachers.Add(new Teacher(5, "Amit", "Male",444));

            Teacher teacher6 = new Teacher()
            {
                Id = 6,
                Name = "Kiran",
                Gender = "Female",
                Salary=3232
            };


            var teacher7 = new Teacher()
            {
                Id = 6,
                Name = "Kiran",
                Gender = "Female",
                Salary =43435
            };

            teachers.Add(teacher6);





            Teacher teacher = new Teacher(20, "abc", "Female",3242);
            teachers.Insert(1, teacher);
            teachers.RemoveAt(3);

            foreach (var teach in teachers)
            {
                //Console.WriteLine("Id = "+ teacher.Id + " Name = " + teacher.Name + " Gender = " + teacher.Gender);
                Console.WriteLine($"Id = {teach.Id} Name = { teach.Name} Gender =  { teach.Gender}");

            }


            var maxSalary = teachers.Max(x => x.Salary);
            var minSalary = teachers.Min(x => x.Salary);
            var avgSalary = teachers.Average(x => x.Salary);
            var sumSalary = teachers.Sum(x => x.Salary);



        }


        public void ListDemo2()
        {
            List<int> numbers = new List<int>() { 34, 21, 66, 77, 300, 22, 44, 12 };
            int[] num = new int[] { 34, 21, 66, 77, 300, 22, 44, 12 };

            //int max = num[0];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if(max < num[i])
            //    {
            //        max = num[i];
            //    }
            //}


            var max = numbers.Max();
            var min = numbers.Min();
            var avg = numbers.Average();
            var sum = numbers.Sum();
            var count = numbers.Count();
            var countArray = num.Length;

            Console.WriteLine("Maximum number = " + max);




            Teacher teacher1 = new Teacher();
            Teacher teacher2 = new Teacher();
            Teacher teacher3 = new Teacher();
            Teacher teacher4 = new Teacher();
            Teacher teacher5 = new Teacher();

            List<Teacher> teachers = new List<Teacher>() { teacher1, teacher2, teacher3, teacher4, teacher5 };




        }
    }
}
