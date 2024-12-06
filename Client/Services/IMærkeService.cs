using BlazorAppClientServer.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppClientServer.Client.Services
{
    public interface IMærkeService
    {
        Task<Mærke[]?> GetAllMærker();
        Task<Mærke> GetMærkeById(int id);
        Task<bool> AddMærke(Mærke mærke);
        Task<bool> UpdateMærke(Mærke mærke);
        Task<bool> DeleteMærke(int id);
    }
}
