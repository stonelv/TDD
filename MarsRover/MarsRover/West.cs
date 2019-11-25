namespace MarsRover
{
    internal class West : Direct
    {
        public override DIRECTION getDirection()
        {
            return DIRECTION.WEST;
        }

        public override Direct turnLeft()
        {
            return new South();
        }

        public override Direct turnRight()
        {
            return new North();
        }
    }
}