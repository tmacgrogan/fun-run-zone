
namespace api.Data.Entities;
public class Player
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string GamerTag { get; set; }


    public int Points { get; set; }
    public ICollection<ParticipantScores> Scores { get; set; } = new List<ParticipantScoresItem>();
}
