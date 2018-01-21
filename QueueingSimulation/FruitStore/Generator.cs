using System;

namespace FruitStore
{
    public class Generator
    {
        private Random random;

        public Generator()
        {
            random = new Random();
        }

        public string GenerateName(string[] names)
        {
            return names[random.Next(names.Length)];
        }
        public string GenerateOrders(string[] orders)
        {
            string o1 = orders[random.Next(7)];
            string o2 = orders[random.Next(7)];
            string o3 = orders[random.Next(7)];
            string o4 = orders[random.Next(7)];

            string str = string.Format("{0}, {1}, {2}, {3}", o1, o2, o3, o4);
            return string.Format("{0}", str);
        }
    }
}
