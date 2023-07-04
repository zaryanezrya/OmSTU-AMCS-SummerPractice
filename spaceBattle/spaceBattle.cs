﻿namespace spaceBattle
{
    public class SpaceShip
    {
        private double[]? startCoordinates;
        private double[]? speedCoordinates;
        private bool abilityToMove = true;

        public void SetCoordinates(double x, double y)
        {
            startCoordinates = new double[] { x, y };
        }

        public void SetSpeedCoordinates(double x, double y)
        {
            speedCoordinates = new double[] { x, y };
        }

        public void NotMoving()
        {
            abilityToMove = false;
        }

        public double[] MovingAction()
        {
            if (startCoordinates == null & speedCoordinates == null & not abilityToMove)
            {
                throw new Exception("check the values, maybe something is set as null!");
            }

            else 
            { 
                return new double[] { startCoordinates[0] + speedCoordinates[0], startCoordinates[1] +speedCoordinates[1] }; 
            }
        }
    }
}
