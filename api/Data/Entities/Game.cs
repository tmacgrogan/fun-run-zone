
namespace api.Data.Entities;


public class Game
{

    public int Id { get; set; }
    public string Name { get; set; }
    public Participant Chooser { get; set; }
    public string? DownloadLink { get; set; }
    public ICollection<ParticipantPlacement> ParticipantPlacements { get; set; } = new List<ParticipantPlacement>();

}
