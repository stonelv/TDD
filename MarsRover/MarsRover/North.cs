namespace MarsRover
{
    internal class North : Direct
    {
        public override DIRECTION getDirection()
        {
            return DIRECTION.NORTH;
        }

        public override Direct turnLeft()
        {
            return new West();
        }

        public override Direct turnRight()
        {
            return new East();
        }
    }
}