using ITNMock1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITNMock1.Repositories
{
    public class ITNRepository : IITNStoreRepository
    {
        private readonly ITNStoreContext _context;
        public ITNRepository(ITNStoreContext context)
        {
            _context = context;
        }
        public async Task<ITNStore> Create(ITNStore iTN)
        {
            _context.ITNStores.Add(iTN);
            await _context.SaveChangesAsync();

            return iTN;
        }

        public async Task Delete(int id)
        {
            var iTNToRemove = await _context.ITNStores.FindAsync(id);
            _context.ITNStores.Remove(iTNToRemove);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ITNStore>> Get()
        {
            return await _context.ITNStores.ToListAsync();
        }

        public async Task<ITNStore> Get(int id)
        {
            return await _context.ITNStores.FindAsync(id);
        }

        public async Task Update(ITNStore iTN)
        {
            _context.Entry(iTN).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
