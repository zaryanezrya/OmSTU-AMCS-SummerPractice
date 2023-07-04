namespace SpaceBattleLib;
public class SpaceShip
{
    public double[] position= new double[2]{double.NaN, double.NaN};
    public double[] speed= new double[2]{double.NaN,double.NaN};
    public bool can_ship_fly= true;

    public void Space_Ship()
    {}

    public void SetPosition(double[] pos)
    {
        this.position = pos;
    }

    public void SetSpeed(double[] speed){
        this.speed = speed;
    }

    public void SetSPosOfMove(bool can_ship_fly){
        this.can_ship_fly = can_ship_fly;
    }
    public double[] Movement (){
        if(double.IsNaN(position[0]) || double.IsNaN(position[1])){
            throw new Exception();
        }
        else if (double.IsNaN(speed[0]) || double.IsNaN(speed[1])){
            throw new Exception();
        }
        else if (can_ship_fly==false){
            throw new Exception();
        }
        else{
            position[0] += speed[0];
            position[1] += speed[1];
            return position;
        }
    }
}

