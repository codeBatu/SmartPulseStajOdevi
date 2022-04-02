using Batu.Exam.SmartpulseInternship.Entities.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Batu.Exam.SmartpulseInternship.RepositoryLayer.Factory
{
    public class ApiServices
    {
        public static async Task<List<IntraDayTradeHistoryInfo>> IntraDayTradeHistoryListFromJson()
        {
            try
            {
                var response = await new HttpClient().GetAsync(GlobalValue.Url);
                var body = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());
               return body.Body.IntraDayTradeHistoryList;
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
    }
}
