using TabelaLigi.Db.Models;

namespace TabelaLigi.Db;

public interface ITeamsRepository
{
    Task<Team> ReadTeamAsync(int id);
    Task<IEnumerable<Team>> ReadAllTeamsAsync();
}