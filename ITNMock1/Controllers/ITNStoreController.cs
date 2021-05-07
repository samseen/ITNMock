using ITNMock1.Models;
using ITNMock1.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITNMock1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ITNStoreController : ControllerBase
    {

        private readonly IITNStoreRepository _iITNStoreRepository;

        public ITNStoreController(IITNStoreRepository iITNStoreRepository)
        {
            this._iITNStoreRepository = iITNStoreRepository;
        }

        public async Task<IEnumerable<ITNStore>> GetIITNStores()
        {
            return await _iITNStoreRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ITNStore>> GetIITNStores(int id)
        {
            return await _iITNStoreRepository.Get(id);
        }
    }
}
