using Batu.Exam.SmartpulseInternship.Entities.Entity;
using System.Collections.Generic;

namespace Batu.Exam.SmartpulseInternship.RepositoryLayer.Factory
{
    public class Body
    {
        public List<IntraDayTradeHistoryInfo> IntraDayTradeHistoryList { get; set; }
        public List<StatisticInfo> Statistics { get; set; }
    }
}
