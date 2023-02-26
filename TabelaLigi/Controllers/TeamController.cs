using Microsoft.AspNetCore.Mvc;
using TabelaLigi.Db;

namespace TabelaLigi.Controllers;

[Controller]
[Route("[controller]")]
public class TeamController : Controller
{
    private readonly ITeamsRepository _teamsRepo;

    public TeamController(ITeamsRepository teamsRepo)
    {
        _teamsRepo = teamsRepo;
    }

    public async Task<IActionResult> Index()
    {
        return Ok(await _teamsRepo.ReadAllTeamsAsync());
    }

    [Route("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _teamsRepo.ReadTeamAsync(id));
    }
}