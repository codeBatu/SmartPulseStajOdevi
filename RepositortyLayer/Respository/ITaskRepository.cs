using System.Collections.Generic;

namespace Batu.Exam.SmartpulseInternship.RepositoryLayer.Respository
{
    public interface ITaskRepository<T>
    {

        IEnumerable<T> GetDataApi();
    }
}
