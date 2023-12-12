public class CowParameter : Environment
{
    public HealthP<int> TimeStand { get; set; }

    public HealthP<int> toDIE { get; set; }

    public HealthP<int> TimeRelax { get; set; }

    public HealthP<int> NumberEfMeals { get; set; }
    public DateTime Date { get; set; }

    public override string ToString()
    {
        return $"Name: {Name} tavalod: {Birthday} sen: {Math.Round((double)life() / 365, 0)}";
    }
}





