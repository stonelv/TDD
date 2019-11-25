using System;

namespace MarsRover
{
    public class MarsRover
    {
        private int x;
        private int y;
        //private DIRECTION direction;
        private Direct direct;
        private int length;
        private int width;

        public MarsRover(int x, int y, DIRECTION direction)
        {
            this.x = x;
            this.y = y;
            //this.direction = direction;
            this.direct = createDirect(direction);
        }

        private Direct createDirect(DIRECTION direction)
        {
            switch(direction)
            {
                case DIRECTION.EAST:
                    return new East();
                case DIRECTION.SOUTH:
                    return new South();
                case DIRECTION.WEST:
                    return new West();
                case DIRECTION.NORTH:
                    return new North();
            }
            return null;
        }

        public void setRange(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        
        public void moveForward(int distance)
        {
            switch(this.direct.getDirection())
            {
                case DIRECTION.EAST:
                    addX(distance);
                    break;
                case DIRECTION.SOUTH:
                    addY(distance * -1);
                    break;
                case DIRECTION.WEST:
                    addX(distance * -1);
                    break;
                case DIRECTION.NORTH:
                    addY(distance);
                    break;
            }
        }

        private void addY(int distance)
        {
            this.y += distance;
            if (this.y > this.width)
                this.y = this.width;
            if (this.y < 0)
                this.y = 0;
        }

        private void addX(int distance)
        {
            this.x += distance;
            if (this.x > this.length)
                this.x = this.length;
            if (this.x < 0)
                this.x = 0;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public void moveBackward(int distance)
        {
            this.moveForward(distance * -1);
        }

        public DIRECTION getDirection()
        {
            return this.direct.getDirection();
        }

        public void turnLeft()
        {
            this.direct = this.direct.turnLeft();
        }

        public void turnRight()
        {
            this.direct = this.direct.turnRight();
        }
    }
}