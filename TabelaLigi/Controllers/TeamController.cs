using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using TabelaLigi.Db;
using TabelaLigi.Db.Models;

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
        var teams = (await _teamsRepo.ReadAllTeamsAsync())
            .OrderByDescending(t => t.Points)
            .ThenByDescending(t => t.GoalsDifferential)
            .ToImmutableList();
        return View(teams);
    }
    public async Task<IActionResult> Details(int id)
    {
        return View(await _teamsRepo.ReadTeamAsync(id));
    }

    public async Task<IActionResult> Delete(int id)
    {
        return View(await _teamsRepo.ReadTeamAsync(id));
    }
    
    [HttpPost]
    public async Task<IActionResult> ConfirmDelete([FromForm] int id)
    {
        await _teamsRepo.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        return View(await _teamsRepo.ReadTeamAsync(id));
    }

    public async Task<IActionResult> Edit(Team team)
    {
        await _teamsRepo.UpdateAsync(team);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(
        [Bind("Name", "MatchesWon", "MatchesLost", "MatchesDrawn", "GoalsScored", "GoalsLost")]
        [FromForm]
        Team team)
    {
        await _teamsRepo.CreateAsync(team);
        return RedirectToAction(nameof(Index));
    }
}