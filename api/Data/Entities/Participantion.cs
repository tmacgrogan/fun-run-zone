namespace api.Data.Entities;
using api.Enums;


public class Participant
{

    public int Id { get; set; }

    public ParticipationType ParticipationType { get; set; }
    public ICollection<ParticipantPlacement> ParticipationPlacements { get; set; } = new List<ParticipationPlacement>();
}
