using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class East : Direct
    {
        public override DIRECTION getDirection()
        {
            return DIRECTION.EAST;
        }

        public override Direct turnLeft()
        {
            return new North();
        }

        public override Direct turnRight()
        {
            return new South();
        }
    }
}
