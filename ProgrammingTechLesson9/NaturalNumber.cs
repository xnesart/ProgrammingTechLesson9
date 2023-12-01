namespace ProgrammingTechLesson9;

public class NaturalNumber
{
    private int _basis;
    private int _power;

    public int Basis { get; set; }

    public int Power
    {
        get { return _power; }
        set { _power = value; }
    }
    
    public NaturalNumber(int basis, int power)
    {
        Basis = basis;
        Power = power;
    }

    public double CalculatePower()
    {
        return Math.Pow(Basis, Power);
    }
}