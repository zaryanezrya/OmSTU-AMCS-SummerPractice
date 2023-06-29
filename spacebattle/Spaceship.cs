﻿namespace spacebattle
{
    public class Spaceship
    {
        private int[]? coordinates = null;
        private int[]? speedvector = null;
        private bool CanAction = true;

        public void SetCoordinates(int x, int y)
        {
            coordinates = new int[] { x, y };
        }

        public void SetSpeedVector(int x, int y)
        {
            speedvector = new int[] { x, y };
        }

        public void CannotAction()
        {
            CanAction = false;
        }

        public int[]? MovingAction()
        {
            if (coordinates != null & speedvector != null & CanAction)
            {
                return new int[] { coordinates[0] + speedvector[0], coordinates[1] + speedvector[1] };
            }

            else { throw new Exception("coordinates or speed vector was null"); }
        }
    }
}