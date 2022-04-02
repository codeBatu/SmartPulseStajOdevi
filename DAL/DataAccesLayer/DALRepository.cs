
using Batu.Exam.SmartpulseInternship.Entities.Entity;
using Batu.Exam.SmartpulseInternship.RepositoryLayer.Respository;
using System.Collections.Generic;

namespace Batu.Exam.SmartpulseInternship.DataAccesLayer
{
    public class DALRepository
    {
        private readonly IIntraDayTradeHistory m_intraDayTradeHistory;
        public DALRepository(IIntraDayTradeHistory intraDayTradeHistory)
        {
            m_intraDayTradeHistory = intraDayTradeHistory;
        }


        public IEnumerable<IntraDayTradeHistoryInfo> GetDataDAL()
        {
            return m_intraDayTradeHistory.GetDataApi();
        }


    }

}
