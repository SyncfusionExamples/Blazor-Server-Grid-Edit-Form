using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Editing.Data
{
    public class OrderService
    {
        public static List<Order> Data = new List<Order>();
        public List<Order> GetOrderDetails()
        {
            if (Data.Count == 0)
            {
                Data = Enumerable.Range(1, 75).Select(x => new Order()
                {
                    OrderID = 1000 + x,
                    CustomerID = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })[new Random().Next(5)],
                    Freight = 2.1 * x,
                    OrderDate = DateTime.Now.AddDays(-x),
                }).ToList();
            }
            return Data;
        }
    }
}
