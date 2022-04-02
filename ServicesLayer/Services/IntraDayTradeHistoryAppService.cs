using Batu.Exam.SmartpulseInternship.DataAccesLayer;
using Batu.Exam.SmartpulseInternship.Entities.Entity;
using System.Collections.Generic;

namespace Batu.Exam.SmartpulseInternship.ServicesLayer.Services
{
    public class IntraDayTradeHistoryAppService
    {
        private readonly DALRepository m_dALRepository;
        public IntraDayTradeHistoryAppService(DALRepository dALRepository)
        {
            m_dALRepository = dALRepository;

        }



        public IEnumerable<IntraDayTradeHistoryInfo> GetDataApiServiceLayer()
        {
            return m_dALRepository.GetDataDAL();


        }
    }
}
