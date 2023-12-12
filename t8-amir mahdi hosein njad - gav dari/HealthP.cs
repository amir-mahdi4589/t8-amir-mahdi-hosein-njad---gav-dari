public class HealthP<T>
{
    public string Name { get; set; }

    public T CURENT { get; set; }

    public T SRANDARD { get; set; }

    public double Coefficient { get; set; }

    public double StressFactor()
    {
        double result = Convert.ToDouble(CURENT) / Convert.ToDouble(SRANDARD);
        return Math.Round(result * Coefficient, 2);
    }

    public override string ToString()
    {
        return $"NAME: {Name} SRANDARD: {SRANDARD} CURENT: {CURENT}";
    }
}





