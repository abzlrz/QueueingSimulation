using System;

namespace FruitStore
{
    public class Cashier
    {
        private double CashRegister = 0;
        private int TotalCustomers = 0;
        public double CalculateTotalSales(Customer customer)
        {
            CashRegister += customer.TotalOrderPrice;
            return CashRegister;
        }

        public int CountCustomers()
        {
            TotalCustomers++;
            return TotalCustomers;
        }
    }
}
