public class Environment
{
    public HealthP<int> TDS { get; set; }
    public HealthP<int> temp { get; set; }
    public HealthP<int> density { get; set; }
    public HealthP<int> db { get; set; }
    public HealthP<int> aql { get; set; }
    public HealthP<int> ox { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;

}





