namespace SpaceBattle;
public class SpaceBattle
{
    public double[] Movement (double[] position, double[] speed, bool possibility_of_movement){
        if(position[0]==double.NaN | position[1]==double.NaN){
            throw new Exception();
        }
        else if (speed[0]==double.NaN | speed[1]==double.NaN){
            throw new Exception();
        }
        else if (possibility_of_movement==false){
            throw new Exception();
        }
        else{
            position[0] += speed[0];
            position[1] += speed[1];
            return position;
        }
    }
 }
