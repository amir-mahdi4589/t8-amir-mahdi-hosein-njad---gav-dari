public class product : animal
{
    public string Nmae { get; private set; }
    public string unitOfMeasure { get; private set; }
    public double producedInUnitsPerDay { get; private set; }
    public double producedToUnit { get; private set; }
    public double PricePerUnit { get; private set; }
    public override string ToString()
    {
        return $"Number Of Product: {NoProduct} Name: {name} har 1 rooz: {PricePerUnit}  tolidi har rooz: {producedInUnitsPerDay}{unitOfMeasure} tolidi har vahed: {producedToUnit}{unitOfMeasure}";
    }
}





