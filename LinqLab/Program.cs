using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>
            {
                new Student("Jimmy", 13),
                new Student("Hannah Banana", 21),
                new Student("Justin", 30),
                new Student("Sarah", 53),
                new Student("Hannibal", 15),
                new Student("Phillip", 16),
                new Student("Maria", 63),
                new Student("Abe", 33),
                new Student("Curtis", 10)
            };   

            Console.WriteLine("Nums");
            MinValue(nums);
            Console.WriteLine();
            MaxValue(nums);
            Console.WriteLine();
            MaxValueLessThanX(nums);
            Console.WriteLine();
            FindValuesBetween(nums);
            Console.WriteLine();
            FindValuesBetween2(nums);
            Console.WriteLine();
            CountEvenNumbers(nums);
            Console.WriteLine();
            Console.WriteLine("Students");
            DrinkingAgeStudents(students);
            Console.WriteLine();
            OldestStudent(students);
            Console.WriteLine();
            YoungestStudent(students);
            Console.WriteLine();
            OldestUnder25(students);
            Console.WriteLine();
            Over21andEven(students);
            Console.WriteLine();
            Teenagers(students);
            Console.WriteLine();
            StartsWithVowel(students);
        }

        static void MinValue(int[] nums)
        {
            int min = nums.Min();
            Console.WriteLine(min);
        }

        static void MaxValue(int[] nums)
        {
            int max = nums.Max();
            Console.WriteLine(max);
        }

        static void MaxValueLessThanX(int[] nums)
        {           
            var nums2 = nums.Where(s => s < 10000).Max();
            Console.WriteLine(nums2);

        }

        static void FindValuesBetween(int[] nums)
        {            
            var nums2 = from n in nums
                        where n >= 10 && n <= 100
                        select n;
            foreach (int num in nums2)
            {
                Console.WriteLine(num);
            }          
        }

        static void FindValuesBetween2(int[] nums)
        {
            var nums2 = from n in nums
                        where n > 100000 && n < 999999
                        select n;
            foreach (int num in nums2)
            {
                Console.WriteLine(num);
            }
        }

        static void CountEvenNumbers(int [] nums)
        {
            int evenNumbers = nums.Count(n => n % 2 == 0);
            Console.WriteLine(evenNumbers);
        }

        static void DrinkingAgeStudents(List<Student> students)
        {
            var over21 = from s in students
                         where s.Age >= 21
                         select s;
            foreach (Student student in over21)
            {
                Console.WriteLine(student.Name);
            }
        }

        static void OldestStudent(List<Student> students)
        {
            var oldest = students.OrderByDescending(s => s.Age).ToList();
            Console.WriteLine(oldest[0].Name);
        }

        static void YoungestStudent(List<Student> students)
        {
            List<Student> youngest = (from s in students
                           orderby s.Age
                           select s).ToList();

            Console.WriteLine(youngest[0].Name);
        }

        static void OldestUnder25(List<Student> students)
        {
            //throws an exception            
            //var Ounder25 = students.Where(s => s.Age < 25).Max();
            //Console.WriteLine(Ounder25.Name);

            //this works with the nums above
            //var nums2 = nums.Where(s => s < 10000).Max();
            //Console.WriteLine(nums2);
        }

        static void Over21andEven(List<Student> students)
        {
            var overEven = from s in students
                           where s.Age > 21 && s.Age % 2 == 0
                           select s;
            foreach (Student student in overEven)
            {
                Console.WriteLine(student.Name);
            }
            
        }

        static void Teenagers(List<Student> students)
        {
            var teen = from s in students
                           where s.Age >= 13 && s.Age <=19
                           select s;
            foreach (Student student in teen)
            {
                Console.WriteLine(student.Name);
            }
        }

        static void StartsWithVowel(List<Student> students)
        {
            //I haven't been able to get this to work for me since class began, using Linq isn't going to help me
            //char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
            //foreach (Student student in students)
            //{
            //    if (student.Name.StartsWith = vowel)
            //    {
            //        return student.Name;
            //    }
            //}               
        }
    }
}
