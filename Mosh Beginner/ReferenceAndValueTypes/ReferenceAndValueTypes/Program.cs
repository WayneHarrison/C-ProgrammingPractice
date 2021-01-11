using System;

namespace ReferenceAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}",a ,b)); //Integer is a value type, so when you copy a value type it is stored in the new variable without changing the original.

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1; //array is a reference type, changes to array 2 will be reflected in array 1 as the variables point to the same object in memory.
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]:{1}", array1[0], array2[0]));
        }
    }
}
