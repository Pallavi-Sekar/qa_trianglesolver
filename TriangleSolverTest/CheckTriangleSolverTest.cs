using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class CheckTriangleSolverTest
    {
        [Test]
        public void Test_Valid_Equilateral_Triangle()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 5;

            // Act
            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Equilateral"));
        }
    }
}
