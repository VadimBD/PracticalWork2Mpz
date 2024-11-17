using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class Report
    {
        public DateTime ReportDate { get; set; }
        public decimal TotalSales { get; set; }
        public Dictionary<string, int> Items { get; set; }
        public decimal AverageCheck { get; set; }

        public Report(DateTime reportDate)
        {
            ReportDate = reportDate;
            Items = new Dictionary<string, int>();
        }

        public void AddItemToReport(string itemName, int quantitySold)
        {
            if (Items.ContainsKey(itemName))
            {
                Items[itemName] += quantitySold;
            }
            else
            {
                Items[itemName] = quantitySold;
            }
        }
    }
}
