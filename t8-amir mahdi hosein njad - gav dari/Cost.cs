public struct Cost : animal
{
    public string Name { get; set; }

    public string UnitOfMeasure { get; set; }

    public decimal Price { get; set; }

    public double DailyProduce { get; set; }

    public override string ToString() { return $"Name :{Name}, roozane: {DailyProduce}{UnitOfMeasure}, ghymat: {Price}"; }


}





