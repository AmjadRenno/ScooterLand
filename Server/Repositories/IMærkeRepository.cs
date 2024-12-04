using BlazorAppClientServer.Shared.Models;
using System.Collections.Generic;

namespace BlazorAppClientServer.Server.Repositories
{
    public interface IMærkeRepository
    {
        List<Mærke> GetAllMærker();
        Mærke GetMærke(int id);
        bool AddMærke(Mærke mærke);
        bool UpdateMærke(Mærke mærke);
        bool DeleteMærke(int id);
    }
}
