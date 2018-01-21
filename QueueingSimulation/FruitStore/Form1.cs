using System;
using System.Drawing;
using System.Windows.Forms;

namespace FruitStore
{
    public partial class Form1 : Form
    {
        Cashier cashier = new Cashier();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            var cust = new Customer();

            this.panelQueue.Controls.Add(cust);
            int totalCustomer = panelQueue.Controls.Count;

            if (totalCustomer == 10)
                btnEnqueue.Enabled = false;
            else
                EnableButtons();
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            var ctrl = panelQueue.Controls;
            var customerOnService = ctrl[0] as Customer;

            double sales = cashier.CalculateTotalSales(customerOnService);
            int totalCustomers = cashier.CountCustomers();

            this.lbl_total.Text = sales + " PHP";
            this.lbl_totalcustomers.Text = totalCustomers.ToString();
            this.panelQueue.Controls.RemoveAt(0);
            
            int totalCustomersOnQueue = panelQueue.Controls.Count;

            if (totalCustomersOnQueue == 0)
                btnDequeue.Enabled = false;
            else
                EnableButtons();
        }

        private void EnableButtons()
        {
            btnDequeue.Enabled = true;
            btnEnqueue.Enabled = true;
        }

        private void btn_little_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Average Queue Size: \t {10}\nAverage Number of Customer");
        }
    }
}
