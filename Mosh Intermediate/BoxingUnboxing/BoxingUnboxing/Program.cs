using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //There will be performance penalties for adding value types to the array list below. It is best to use a generic list of the same type if possible.
            var list = new ArrayList();
            list.Add(1);
            list.Add("Wayne");
            list.Add(DateTime.Today);

            var number = (int) list[1];

            var anotherList = new List<int>();
            anotherList.Add(2);
            var names = new List<string>();

        }
    }
}
