using Microsoft.EntityFrameworkCore;
using TabelaLigi.Db.Models;

namespace TabelaLigi.Db;

public class TeamsRepository : ITeamsRepository
{
    private readonly LigaContext _dbContext;

    public TeamsRepository(LigaContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Team> ReadTeamAsync(int id)
    {
        var team = await _dbContext.Teams.FindAsync(id);
        if (team is null)
        {
            throw new ArgumentException($"No team found for provided id={id}");
        }
        return team;
    }

    public async Task<IEnumerable<Team>> ReadAllTeamsAsync()
    {
        return await _dbContext.Teams.ToListAsync();
    }
}