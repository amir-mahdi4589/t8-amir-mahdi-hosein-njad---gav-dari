public class cow : animal

{
    List<CowParameter> CowParameter = new List<CowParameter>();
    public List<Environment> Environments { get; set; }
    public static int maxlife { get; } = 25;

    public int ID { get; set; }
    public string Name { get; set; }
    public int MaxLife { get; init; }
    public double Weight { get; set; }
    public bool Gender { get; set; }
    public object Birthday { get; private set; }

    public static int NumberCows = 0;
    public cow(int MaxLife, bool ismail, double Weight, List<Environment> Environments)
    {
        NumberCows++;
        this.ID = NumberCows;
        this.MaxLife = MaxLife;
        this.Gender = ismail;
        this.Weight = Weight;

        this.Environments = Environments;

        Birthday = DateTime.Today;
    }
    public override int life()
    {
        double Life = 0;
        foreach (Environment Environment in Environments)
        {
            Life += StressFactor(Environment);

        }
        return 0;
    }
    public override int toDIE()
    {
        double RemainLife = (MaxLife * 365) - life();
        return (int)Math.Ceiling(RemainLife / 365);
    }
    public override double KillPriority()
    {
        int d = (MaxLife * 365) - life();
        double KillPriority = 0;
        switch (d)
        {
            case int difference when difference <= 730:
                KillPriority = 1;
                break;
            case int difference when difference > 700 && difference <= 1600:
                KillPriority = 0.85;
                break;
            case int difference when difference > 1601 && difference <= 2900:
                KillPriority = 0.65;
                break;
            case int difference when difference > 2901 && difference <= 3500:
                KillPriority = 0.45;
                break;
            case int difference when difference > 3501 && difference <= 4000:
                KillPriority = 0.25;
                break;
            case int difference when difference > 4001 && difference <= 4800:
                KillPriority = 0.16;
                break;

            default:
                KillPriority = 0;
                break;
        }
        return 1;
    }


    public override string ToString() => $"Name: {Name} TARIKH TAVALOD: {Birthday} SEN: {Math.Round((double)life() / 365, 0)}";

    public override decimal IncomePerDay()
    {
        decimal come = 0;
        foreach (product pro in Products)
        {
            if (pro.producedInUnitsPerDay == 0)
                come = come + (decimal)(pro.PricePerUnit * pro.producedToUnit);
            else
                come = come + (decimal)(pro.producedInUnitsPerDay * pro.PricePerUnit);
        }
        return come;
    }

}





