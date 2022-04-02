using System;

namespace Batu.Exam.SmartpulseInternship.Entities.Entity
{
    public class IntraDayTradeHistoryInfo
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Conract { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal WeighAveragePrice { get; set; }
        public decimal TotalTransactionAmount { get; set; }
        public decimal TotalTransactionQuantity { get; set; }

    }
}
