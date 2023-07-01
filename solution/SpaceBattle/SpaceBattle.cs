namespace SpaceBattle {
public class Spacebattle {
    public static double[] ship(double[] coordinates, double[] speed, bool Position, bool Speed, bool Movement) {
        if (!Position || !Speed || !Movement) {
            throw new System.Exception();
        }
        coordinates[0] += speed[0];
        coordinates[1] += speed[1];
        return coordinates;
    }
}
}
