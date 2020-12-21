using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNoWin()
        {
            var ticTacToeLogic = new TicTacToeLogic();

            int [] spaces = 
            { 
                1, -1, 0, -1,
                1, -1, 0, -1,
                1, 1, 0, 1,
                -1, -1, -1, -1
            };

            var isOneWin = ticTacToeLogic.IsWin(spaces, 1);
            var isZeroWin = ticTacToeLogic.IsWin(spaces, 0);

            Assert.IsFalse(isOneWin);
            Assert.IsFalse(isZeroWin);
        }

        [Test]
        public void TestHorizontalWin()
        {
            var ticTacToeLogic = new TicTacToeLogic();

            int[] spaces =
            {
                1, -1, 0, -1,
                1, -1, 0, -1,
                0, 0, 0, 0,
                -1, -1, -1, -1
            };

            var isOneWin = ticTacToeLogic.IsWin(spaces, 1);
            var isZeroWin = ticTacToeLogic.IsWin(spaces, 0);

            Assert.IsFalse(isOneWin);
            Assert.IsTrue(isZeroWin);
        }

        [Test]
        public void TestVerticalWin()
        {
            var ticTacToeLogic = new TicTacToeLogic();

            int[] spaces =
            {
                0, -1, 0, -1,
                0, -1, 0, -1,
                0, -1, 0, 0,
                -1, -1, 0, -1
            };

            var isOneWin = ticTacToeLogic.IsWin(spaces, 1);
            var isZeroWin = ticTacToeLogic.IsWin(spaces, 0);

            Assert.IsFalse(isOneWin);
            Assert.IsTrue(isZeroWin);
        }

        [Test]
        public void TestDiagonalWin()
        {
            var ticTacToeLogic = new TicTacToeLogic();

            int[] spaces =
            {
                0, -1, 0, -1,
                0, 0, -1, -1,
                0, -1, 0, 0,
                -1, -1, 0, 0
            };

            var isOneWin = ticTacToeLogic.IsWin(spaces, 1);
            var isZeroWin = ticTacToeLogic.IsWin(spaces, 0);

            Assert.IsFalse(isOneWin);
            Assert.IsTrue(isZeroWin);
        }

        [Test]
        public void TestReverseDiagonalWin()
        {
            var ticTacToeLogic = new TicTacToeLogic();

            int[] spaces =
            {
                1, -1, 0, 0,
                0, 0, 0, -1,
                0, 0, 0, 1,
                0, -1, 1, 0
            };

            var isOneWin = ticTacToeLogic.IsWin(spaces, 1);
            var isZeroWin = ticTacToeLogic.IsWin(spaces, 0);

            Assert.IsFalse(isOneWin);
            Assert.IsTrue(isZeroWin);
        }
    }
}