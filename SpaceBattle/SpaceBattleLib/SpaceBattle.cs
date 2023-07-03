namespace SpaceBattleLib;

public class SpaceBattle
{
    public static double[] Movement(double[] Coordinates, double[] Speed, bool relocate)
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

        return  Coordinates;
    }
}