namespace SpaceBattleLib;

public class LinearMotion
{
    public double[] Coordinates {get; set;} 
    public double[] Speed {get; set;}
    public bool relocate {get; set;}

    public LinearMotion()
    {
        this.Coordinates = new double[2];
        this.Speed = new double[2];
        this.relocate = true;
    }
    public void Movement()
    {
        foreach(double x in Coordinates.Concat(Speed).ToArray())
        {
            if (double.IsNaN(x) | double.IsInfinity(x)) throw new System.Exception();
        }

        if (relocate == false) throw new System.Exception();

        for (int i = 0; i < Coordinates.Length;i++)
        {
            Coordinates[i] += Speed[i];
        }
    }
}

public class MovementFuel
{
    public double amountFuel {get; set;}
    public double fuelConsumption {get; set;}
    public MovementFuel()
    {
        this.amountFuel = 0;
        this.fuelConsumption = 0;
    }
    public void AbilityMove()
    {
        if (fuelConsumption > amountFuel) throw new System.Exception();

        amountFuel -= fuelConsumption;
    }
}

public class ReversalPossibility
{
    public double angleInclination {get; set;} 
    public double angularVelocity {get; set;} 
    public bool reversalPossibility {get; set;}
    public ReversalPossibility()
    {
        this.angleInclination = 0;
        this.angularVelocity = 0;
        this.reversalPossibility = true;
    }
    public void Reversal()
    {
        foreach(double x in new double[]{angleInclination, angularVelocity})
        {
            if (double.IsNaN(x) | double.IsInfinity(x)) throw new System.Exception();
        }
        if (reversalPossibility == false) throw new System.Exception();

        if(angleInclination < 360)
        {
            angleInclination += angularVelocity;
        }
        else
        {
            angleInclination += angularVelocity;
            angleInclination -= 360;
        }
    }
}