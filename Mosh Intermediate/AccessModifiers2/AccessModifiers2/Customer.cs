using System;

namespace AccessModifiers2
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
                Console.WriteLine("Level 1");
            else
                Console.WriteLine("level2");
        }
    

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}