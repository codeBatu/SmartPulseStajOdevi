using Batu.Exam.SmartpulseInternship.Entities.Entity;
using System.Collections.Generic;
using System.Linq;
using static RepositortyLayer.Factory.ApiServices;
using static RepositortyLayer.Util.DateTimeConvertString;
namespace RepositortyLayer.Respository
{
    public class IntraDayTradeHistoryRepository : IIntraDayTradeHistory
    {
        private readonly IIntraDayTradeHistory m_intraDayTradeHistory;
        public IntraDayTradeHistoryRepository(IIntraDayTradeHistory intraDayTradeHistory)
        {
            m_intraDayTradeHistory = intraDayTradeHistory;
        }
        public IntraDayTradeHistoryRepository()
        {

        }

        public IEnumerable<IntraDayTradeHistoryInfo> GetDataApi()
        {
            return IntraDayTradeHistoryListFromJson()
                .Result
                .Where(mi => mi.Conract.Contains("PH"))
                .OrderBy(mi => mi.Conract)
                .GroupBy(mi => mi.Conract)
                .Select(mi => new IntraDayTradeHistoryInfo
                {
                    Conract = StringParser(mi.Key),
                    TotalTransactionAmount = mi.Sum(prd => prd.Price * prd.Quantity / 10),
                    TotalTransactionQuantity = mi.Sum(prd => prd.Quantity / 10),
                    WeighAveragePrice = mi.Average(prd => prd.Price / prd.Quantity)
                }
                );
        }
    }



}
