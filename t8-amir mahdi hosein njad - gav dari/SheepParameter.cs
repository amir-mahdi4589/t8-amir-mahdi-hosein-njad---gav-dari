public class SheepParameter : Environment
{
    public DateTime date { get; set; }
    public int timeToStand { get; set; }
    public int toDIE { get; set; }
    public int timeToRelax { get; set; }

    public override string ToString()
    {
        return $"Name: {Name} tavalod: {Birthday} sen: {Math.Round((double)life() / 365, 0)}";
    }
}





