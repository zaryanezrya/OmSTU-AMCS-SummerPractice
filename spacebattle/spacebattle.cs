namespace SpaceBattle;
public class ShipMove
{
    private bool _AllowToMove;
    private bool _IsSpeed;
    private bool _IsPosition;

    public double[] _Speed = new double[2];
    public double[] _Position = new double[2];

    public static double[] ShipMoving(double[] position, double[] speed, bool IsAllow, bool IsPosition, bool IsSpeed){
        var SM = new ShipMove();
        SM._AllowToMove = IsAllow;
        SM._IsPosition = IsPosition;
        SM._IsSpeed = IsSpeed;
        SM._Position = position;
        SM._Speed = speed; // мне кажется, в дальнейшем(если бы эта лаба продолжалась) эти значения можно было использовать в других методах 
        if (!(SM._AllowToMove) || !(SM._IsPosition) || !(SM._IsSpeed)) throw new Exception();
        double x = SM._Position[0] + SM._Speed[0];
        double y = SM._Position[1] + SM._Speed[1];
        double[] finish = {x, y};
        return finish; 
    }
}
