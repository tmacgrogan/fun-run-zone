namespace api.Data.Entities;
public class ParticipantPlacement
{

    public int Id { get; set; }
    public Participant Participant { get; set; }
    public GameItem<GameItem> Game { get; set; }
    public int Placement { get; set; }
    // submitted screenshot

}
