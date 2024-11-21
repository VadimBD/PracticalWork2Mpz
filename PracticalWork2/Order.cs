using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatuses Status { get; set; }
        public OrderTypes Type { get; set; }
        public List<MenuItem> Items { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentMethods PaymentMethod { get; set; }

        public Order(int orderId, DateTime orderDate, OrderStatuses status, OrderTypes type, decimal totalAmount, PaymentMethods paymentMethod)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            Status = status;
            Type = type;
            Items = new List<MenuItem>();
            TotalAmount = totalAmount;
            PaymentMethod = paymentMethod;
        }
        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in Items)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
        }

        public void ViewTotalPrice()
        {
            Console.WriteLine($"TotalPrice{CalculateTotalPrice()}");
        }

        internal enum OrderTypes
        {
            DineIn,
            Takeout,
            Delivery

        }
        internal enum OrderStatuses
        {
            New,
            InProgress,
            Delivered,
            Completed,
            Cancelled
        }
        internal enum PaymentMethods
        {
            cash,
            card,
            online
        }

    }
}