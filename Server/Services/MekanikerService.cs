using BlazorAppClientServer.Shared.Models;
using global::BlazorAppClientServer.Client.Services;
using global::BlazorAppClientServer.Server.Models;
using global::BlazorAppClientServer.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppClientServer.Server.Services
{
    public class MekanikerService : IMekanikerService
        {
            private readonly MyDBContext _context;

            public MekanikerService(MyDBContext context)
            {
                _context = context ?? throw new ArgumentNullException(nameof(context));
            }

            public async Task<IEnumerable<Mekaniker>> GetAllMekanikers()
            {
                return await _context.Mekanikers.ToListAsync();
            }

            public async Task<Mekaniker> GetMekanikerById(int mekanikerId)
            {
                return await _context.Mekanikers.FindAsync(mekanikerId);
            }

            public async Task<Mekaniker> AddMekaniker(Mekaniker mekaniker)
            {
                _context.Mekanikers.Add(mekaniker);
                await _context.SaveChangesAsync();
                return mekaniker;
            }

            public async Task<bool> UpdateMekaniker(Mekaniker mekaniker)
            {
                var existingMekaniker = await _context.Mekanikers.FindAsync(mekaniker.MekanikerId);
                if (existingMekaniker == null) return false;

                existingMekaniker.Navn = mekaniker.Navn; // Update properties as needed
                await _context.SaveChangesAsync();
                return true;
            }

            public async Task<bool> DeleteMekaniker(int mekanikerId)
            {
                var mekaniker = await _context.Mekanikers.FindAsync(mekanikerId);
                if (mekaniker == null) return false;

                _context.Mekanikers.Remove(mekaniker);
                await _context.SaveChangesAsync();
                return true;
            }
    }
}
