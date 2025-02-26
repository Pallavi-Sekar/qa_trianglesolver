using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class CheckTriangleSolverTest
    {
        [Test]
        public void Test_Zero_Length_Side_1()
        {
            int side1 = 0, side2 = 5, side3 = 5;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            Assert.That(result, Is.EqualTo("Invalid - Zero or Negative Side"));
        }

        [Test]
        public void Test_Zero_Length_Side_2()
        {
            int side1 = 3, side2 = 0, side3 = 5;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            Assert.That(result, Is.EqualTo("Invalid - Zero or Negative Side"));
        }

        [Test]
        public void Test_Zero_Length_Side_3()
        {
            int side1 = 5, side2 = 5, side3 = 0;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            Assert.That(result, Is.EqualTo("Invalid - Zero or Negative Side"));
        }



    }
}
