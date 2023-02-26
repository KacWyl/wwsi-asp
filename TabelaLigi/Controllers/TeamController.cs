using Microsoft.AspNetCore.Mvc;
using TabelaLigi.Db;

namespace TabelaLigi.Controllers;

public class TeamController : Controller
{
    private readonly ITeamsRepository _teamsRepo;

    public TeamController(ITeamsRepository teamsRepo)
    {
        _teamsRepo = teamsRepo;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _teamsRepo.ReadAllTeamsAsync());
    }
    public async Task<IActionResult> Details(int id)
    {
        return View(await _teamsRepo.ReadTeamAsync(id));
    }

    public async Task<IActionResult> Delete(int id)
    {
        return View(await _teamsRepo.ReadTeamAsync(id));
    }
    
    public IActionResult ConfirmDelete()
    {
        throw new NotImplementedException();
    }
}