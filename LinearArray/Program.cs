using System;

namespace LinearSearch
{
    class Program
    {
        private static int[] data = { 5, 2, 20, 12, 54, 78, 51, 24, 12, 8 };
        
        static void Main(string[] args)
        {
            int search;
            Console.Write("Enter the number you want to search for: ");
            search = Convert.ToInt32(Console.ReadLine());
            
            var result = LinearSearch(search);
            
            if(result != -1)
            {
                Console.WriteLine("The integer {0} was found in position {1}.\n", search, result);
            }
            else
                Console.WriteLine("The integer {0} was not found.\n", search);

        }
         
        public static int LinearSearch(int searchKey)
        {
            // loop through array sequentially
            for (int index = 0; index < data.Length; ++index)
                if (data[index] == searchKey)
                    return index; // return index of integer
            return -1; // integer was not found
        }
    }
}
