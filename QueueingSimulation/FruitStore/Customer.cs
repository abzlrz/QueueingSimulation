using System;
using System.Drawing;
using System.Windows.Forms;

namespace FruitStore
{
    public partial class Customer : UserControl
    {
        private Generator gen;

        private string[] s = {
            "Rose", "Vanessa", "Sophia", "Marie", "Gladys", "Jane", "Linda",
            "Paul", "John", "Ryan", "Leo", "Rey", "Steve", "Lawrence"
        };

        private string[] q = { "Apple", "Orange", "Banana", "Mango", "Papaya", "Lemon", "Melon" };

        public double TotalOrderPrice = 0;

        public Customer()
        {
            this.gen = new Generator();
            InitializeComponent();

            var rand = new Random();

            string name = gen.GenerateName(s);
            string cart = gen.GenerateOrders(q);
            double total = CalculateTotalPrice(cart);
            
            this.label1.Text = name;
            this.label2.Text = cart;
            this.label3.Text = " =\t" + total + "PHP";
            this.BackColor = Color.FromArgb(rand.Next(100, 255), 
                rand.Next(100, 255), 
                rand.Next(100, 255));
            this.TotalOrderPrice = CalculateTotalPrice(cart);
        }

        private double CalculateTotalPrice(string orders)
        {
            string[] arr_orders = orders.Split(new char[] { ',', ' ' });
            double price = 0;

            foreach (string order in arr_orders)
            {
                if (order.Equals("Apple"))
                    price += 25;
                else if (order.Equals("Orange"))
                    price += 30;
                else if (order.Equals("Banana"))
                    price += 20;
                else if (order.Equals("Mango"))
                    price += 45;
                else if (order.Equals("Papaya"))
                    price += 50;
                else if (order.Equals("Lemon"))
                    price += 27;
                else if (order.Equals("Melon"))
                    price += 75;
            }

            return price;
        }
    }
}
