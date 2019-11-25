namespace MarsRover
{
    class South : Direct
    {
        public override DIRECTION getDirection()
        {
            return DIRECTION.SOUTH;
        }

        public override Direct turnLeft()
        {
            return new East();
        }

        public override Direct turnRight()
        {
            return new West();
        }
    }
}
