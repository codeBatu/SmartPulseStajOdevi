using System;

namespace Batu.Exam.SmartpulseInternship.Entities.Entity
{
    public class StatisticInfo
    {
        public DateTime Date { get; set; }
        public double PriceWeightedAverage { get; set; }
        public double PriceMin { get; set; }
        public double PriceMax { get; set; }
        public int QuantityMin { get; set; }
        public int QuantityMax { get; set; }
        public int QuantitySum { get; set; }
    }
}
