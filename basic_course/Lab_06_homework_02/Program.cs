using System;
using System.Collections.Generic;

namespace Lab_06_homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderManagementSystem orderManagementSystem = new OrderManagementSystem();

            orderManagementSystem.PlaceOrder(1, "Adidas");
            orderManagementSystem.PlaceOrder(2, "Nike");
            orderManagementSystem.PlaceOrder(3, "Puma");
            orderManagementSystem.PlaceOrder(4, "Reebok");

            orderManagementSystem.DisplayOrders();
            Console.WriteLine($"Total orders: {orderManagementSystem.TotalOrders()}");

            Console.WriteLine();

            orderManagementSystem.CancelOrder(3);
            orderManagementSystem.DisplayOrders();
            Console.WriteLine($"Total orders: {orderManagementSystem.TotalOrders()}");
        }
    }

    public class Order
    {
        private int OrderID { get; set; }
        private string CustomerName { get; set; }

        public Order(int orderId, string customerName)
        {
            OrderID = orderId;
            CustomerName = customerName;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Order order = (Order)obj;
            return OrderID == order.OrderID;
        }

        public override int GetHashCode()
        {
            return OrderID.GetHashCode();
        }

        public override string ToString()
        {
            return $"Order ID: {OrderID}, Customer: {CustomerName}";
        }
    }

    public class OrderManagementSystem
    {
        private HashSet<Order> orders = new HashSet<Order>();

        public void PlaceOrder(int orderId, string customerName)
        {
            Order nextOrder = new Order(orderId, customerName);
            orders.Add(nextOrder);
        }

        public void CancelOrder(int orderId)
        {
            Order orderToCancel = new Order(orderId, null);
            orders.Remove(orderToCancel);
        }

        public void DisplayOrders()
        {
            foreach (Order order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public int TotalOrders()
        {
            return orders.Count;
        }
    }
}