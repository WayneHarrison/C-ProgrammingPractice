using System;

namespace TypeCoversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int ii = 1;
            byte bb = (byte) ii;
            Console.WriteLine(bb);
            string num = "1234";
            int i = Convert.ToInt32(num);
            Console.WriteLine(i);
            //Try catch block for converting int to byte.
            try
            {
                byte b = Convert.ToByte(num); //Fails because num is too large for byte. Conversion doesn't work.
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine("Number too big to be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
