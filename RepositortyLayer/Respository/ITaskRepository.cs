using System.Collections.Generic;

namespace RepositortyLayer.Respository
{
    public interface ITaskRepository<T>
    {

        IEnumerable<T> GetDataApi();
    }
}
