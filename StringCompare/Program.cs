using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompare
{
    class Program


    {
        //simple bubble sort of char array
        static char[] BubbleSort(char[] mas) {
            char temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
         }

        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        static void Main(string[] args)
        {
            //reading string params
            Console.WriteLine("type first word:");
            String str1src = Console.ReadLine();
            Console.WriteLine("type second word:");
            String str2src = Console.ReadLine();
            //convert string to char array, sort and convert sorted array back to string
            String str1 = new string(BubbleSort(str1src.ToCharArray())); ;
            String str2 = new string(BubbleSort(str2src.ToCharArray())); ;
 
            //comparing
            if (str1.Contains(str2) && str2.Contains(str1))
            {
                Console.WriteLine("word '{0}' == word '{1}'", str1src, str2src);
            } else if (str1.Contains(str2))
            {
                Console.WriteLine("word '{0}' > word '{1}'", str1src, str2src);
            } else if (str2.Contains(str1))
            {
                Console.WriteLine("word '{0}' < word '{1}'", str1src, str2src);
            } else
            {
                Console.WriteLine("word '{0}' != word '{1}'", str1src, str2src);
            }
                Console.ReadLine(); 
        }
    }
}
