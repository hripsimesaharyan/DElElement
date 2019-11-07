using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delelementfromarray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            int desierdinex=0;

            Console.WriteLine("Enter array of items : ");
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr.GetValue(i)}, ");
            }
            Console.WriteLine();
            Console.Write("Enter position to delete item : ");
            desierdinex = int.Parse(Console.ReadLine());
            
            Deldesiredelement(arr,desierdinex);
            
        void Deldesiredelement(int[] array, int index)
            {
                for (int i= index - 1; i < array.Length -1; i++)
                {
                   array[i] = array[i + 1];
                }
                    
                Array.Resize(ref array, array.Length - 1);

                for (int i = 0; i < array.Length; i++)
                    Console.Write($"{array.GetValue(i)}, ");

                }
            Console.ReadLine();
        }
    }
}
