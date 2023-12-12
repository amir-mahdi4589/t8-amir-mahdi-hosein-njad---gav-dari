public class Sheep : animal
{
    public static int SheepsNumber;
    public static int SheepNum = 0;

    public Sheep(int id, string name, bool ismale, double weight, DateTime birtday)
    {
        SheepNum++;
        this.weight = weight;
        this.id = id;
        this.Name = name;
        this.ismail = ismale;
        this.Birthday = birtday;
    }
    public DateTime birthdate { get; set; }
    public List<Environment> Environments { get; set; }
    public int ID { get; set; }
    public string Name { get; set; }
    public int MaxLife { get; init; }
    public double Weight { get; set; }
    public bool Gender { get; set; }
    public object Birthday { get; private set; }


    public override double StressFactor(Environment Environment)
    {
        double StressFactor = 0;

        StressFactor += Environment.TDS.StressFactor() + Environment.temp.StressFactor() + Environment.density.StressFactor() + Environment.db.StressFactor() + Environment.aql.StressFactor() + Environment.ox.StressFactor();

        return Math.Round(StressFactor / (double)6, 2);
    }
    public override int life()
    {
        double life = 0;
        foreach (Environment Environment in Environments)
        {
            life += StressFactor(Environment);
        }

        return (int)Math.Floor(life);


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
                KillPriority = 0.80;
                break;
            case int difference when difference > 1601 && difference <= 2900:
                KillPriority = 0.60;
                break;
            case int difference when difference > 2901 && difference <= 3500:
                KillPriority = 0.40;
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

        return KillPriority;
    }
    public override string ToString() => $"Name: {Name} TARIKH TAVALOD: {Birthday} SEN: {Math.Round((double)life() / 365, 0)}";
}





