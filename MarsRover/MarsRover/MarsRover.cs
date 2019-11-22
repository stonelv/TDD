using System;

namespace MarsRover
{
    public class MarsRover
    {
        private int x;
        private int y;
        private DIRECTION direction;
        private int length;
        private int width;

        public MarsRover(int x, int y, DIRECTION direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

        public void setRange(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        
        public void moveForward(int distance)
        {
            switch(direction)
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
            return this.direction;
        }

        public void turnLeft()
        {
            switch(direction)
            {
                case DIRECTION.EAST:
                    this.direction = DIRECTION.NORTH;
                    break;
                case DIRECTION.SOUTH:
                    this.direction = DIRECTION.EAST;
                    break;
                case DIRECTION.WEST:
                    this.direction = DIRECTION.SOUTH;
                    break;
                case DIRECTION.NORTH:
                    this.direction = DIRECTION.WEST;
                    break;
            }
        }

        public void turnRight()
        {
            switch(direction)
            {
                case DIRECTION.EAST:
                    this.direction = DIRECTION.SOUTH;
                    break;
                case DIRECTION.SOUTH:
                    this.direction = DIRECTION.WEST;
                    break;
                case DIRECTION.WEST:
                    this.direction = DIRECTION.NORTH;
                    break;
                case DIRECTION.NORTH:
                    this.direction = DIRECTION.EAST;
                    break;
            }
        }
    }
}