using System.Xml.Linq;

public abstract class animal
{
    public List<Environment> EnvironmentS { get; set; }
    public List<Cost> Costs { get; set; }
    public List<product> Products { get; set; }


    public DateTime Birthday { get; set; }
    public int maxlife { get; set; }
    public double weight { get; set; }
    public bool ismail { get; set; }
    public string Name { get; set; }
    public int id { get; set; }

    public abstract double StressFactor(Environment Environment);
    public abstract int life();
    public abstract int toDIE();
    public abstract double KillPriority();
    public abstract int costPerDay();
    public abstract decimal IncomePerDay();
    public abstract decimal IncomeMeal(double priceMeat);
    public abstract decimal SRANDARD();
    public abstract decimal CURENT();

}





