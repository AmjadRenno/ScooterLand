using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Server.Repositories
{
	public interface IYdelseRepository
	{
		List<Ydelse> GetYdelses();
		Ydelse GetYdelse(int id);
		void AddYdelse(Ydelse ydelse);
		bool DeleteYdelse(int id);
		bool UpdateYdelse(Ydelse ydelse);
	}
}
