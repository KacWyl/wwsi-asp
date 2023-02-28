using System.ComponentModel.DataAnnotations;

namespace TabelaLigi.Db.Models;

public class Team
{
    public int Id { get; set; }
    [StringLength(40)]
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    [Range(0, 100)]
    public byte MatchesWon { get; set; }
    [Required]
    [Range(0, 100)]
    public byte MatchesLost { get; set; }
    [Required]
    [Range(0, 100)]
    public byte MatchesDrawn { get; set; }
    [Required]
    [Range(0, 150)]
    public int GoalsScored { get; set; }
    [Required]
    [Range(0, 150)]
    public int GoalsLost { get; set; }

    public int GoalsDifferential => GoalsScored - GoalsLost;
    public int MatchesPlayed => MatchesWon + MatchesLost + MatchesDrawn;
    public int Points => MatchesWon * 3 + MatchesDrawn;
}