namespace SpaceBattle;
public class SpaceBattle
{
    private double[] position = new double[2]{double.NaN, double.NaN};
    private double[] speed = new double[2]{double.NaN, double.NaN};
    private bool possibility_of_movement = true;

    public SpaceBattle(double x, double y, double x_speed, double y_speed, bool possibility_of_movement)
    {
        double n_position = new double[2]{x,y};
        double n_speed = new double[2]{x_speed,y_speed};
        this.position = n_position;
        this.speed = n_speed;
        this.possibility_of_movement = possibility_of_movement;
    }

    public double[] Movement (double[] position, double[] speed, bool possibility_of_movement)
    {
        if(position[0]==NaN & position[1]=double.Nan)
        {
            throw new Exception();
        }
        else if (speed[0]==NaN & speed[1]=double.Nan)
        {
            throw new Exception();
        }
        else if (possibility_of_movement==false)
        {
            throw new Exception();
        }
        else
        {
            position[0] += speed[0];
            position[1] += speed[1];
            return position;
        }
    }
 }
