using ITNMock1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITNMock1.Repositories
{
    public interface IITNStoreRepository
    {
        Task<IEnumerable<ITNStore>> Get();

        Task<ITNStore> Get(int id);

        Task<ITNStore> Create(ITNStore iTN);

        Task Update(ITNStore iTN);

        Task Delete(int id);
    }
}
