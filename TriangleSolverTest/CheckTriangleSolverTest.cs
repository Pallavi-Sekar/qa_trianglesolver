using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class CheckTriangleSolverTest
    {
        [Test]
        public void Test_Invalid_Triangle_Inequality_1()
        {
            int side1 = 1, side2 = 2, side3 = 3;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            Assert.That(result, Is.EqualTo("Invalid - Triangle Inequality"));
        }

        [Test]
        public void Test_Invalid_Triangle_Inequality_2()
        {
            int side1 = 10, side2 = 2, side3 = 2;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            Assert.That(result, Is.EqualTo("Invalid - Triangle Inequality"));
        }

        [Test]
        public void Test_Invalid_Triangle_Inequality_3()
        {
            int side1 = 7, side2 = 5, side3 = 13;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            Assert.That(result, Is.EqualTo("Invalid - Triangle Inequality"));
        }




    }
}
