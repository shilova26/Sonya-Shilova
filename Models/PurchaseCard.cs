using System;

namespace Coffeehouse.Models
{
    public class PurchaseCard
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public int CardId { get; set; }
        public DateTime Date { get; set; }
    }
}