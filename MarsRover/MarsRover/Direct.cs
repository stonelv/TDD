using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    abstract class Direct
    {
        public abstract Direct turnLeft();
        public abstract Direct turnRight();

        public abstract DIRECTION getDirection();
    }
}
