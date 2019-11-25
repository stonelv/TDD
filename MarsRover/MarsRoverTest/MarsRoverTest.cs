using MarsRover;
using NUnit.Framework;

namespace MarsRoverTest
{
    [TestFixture]
    class MarsRoverTest
    {
        private MarsRover.MarsRover marsRover;

        [SetUp]
        public void initial()
        {
            marsRover = new MarsRover.MarsRover(10, 10, DIRECTION.EAST);
            marsRover.setRange(100, 100); //设定了火星车的活动范围
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(1)]
        public void test_move_forward(int distance)
        {
            marsRover.moveForward(distance);
            Assert.AreEqual(marsRover.getX(), 10 + distance);
            Assert.AreEqual(marsRover.getY(), 10);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(1)]
        public void test_move_backward(int distance)
        {
            marsRover.moveBackward(distance);
            Assert.AreEqual(marsRover.getX(), 10 - distance);
            Assert.AreEqual(marsRover.getY(), 10);
        }

        [Test]
        public void test_move_out_of_range()
        {
            marsRover.moveForward(91);
            Assert.AreEqual(marsRover.getX(), 100);
            marsRover.moveBackward(150);
            Assert.AreEqual(marsRover.getX(), 0);
        }


        [Test]
        public void test_turn_left()
        {
            marsRover.turnLeft();
            Assert.AreEqual(marsRover.getDirection(), DIRECTION.NORTH);
        }

        [Test]
        public void test_turn_right()
        {
            marsRover.turnRight();
            Assert.AreEqual(marsRover.getDirection(), DIRECTION.SOUTH);
        }
    }
}
