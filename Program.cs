using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOdev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////// Question 1

            int n;
            Console.WriteLine("Bir sayı girin:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} , tane pozitif sayı giriniz:", n);

            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine("{0} çift sayı", item);
                }
            }


            ///////////////////////// Question 2


            Console.WriteLine("Bir pozitif sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bir pozitif sayı girin: ");
            int m = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("{0} adet ozitif sayı girin: ", n);
            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("****************");

            foreach (int num in nums)
            {
                if (num == m || num % m == 0)
                {
                    Console.WriteLine("{0}", num);
                }
            }


            ///////////////////////// Question 3


            Console.WriteLine("Bir sayı girin:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} adet kelime girin.", n);
            string[] array = new string[n];

            for(int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine();
            }

            foreach(string s in array.Reverse())
            {
                Console.WriteLine(s);
            }


            ///////////////////////// Question 4



            Console.WriteLine("Bir cümle yazın.");
            string sentence = Console.ReadLine();

            char[] chars = sentence.ToCharArray();  //1.yöntem

            int charS = sentence.Length;  //2.yöntem

            Console.WriteLine("Cümledeki harf sayısı : {0} , {1}", chars.Length, charS);

            string[] sentenceSplit = sentence.Split(' ');

            Console.WriteLine("Cümledeki kelime sayısı {0}", sentenceSplit.Length);



            Console.ReadLine();
        }
    }
}
