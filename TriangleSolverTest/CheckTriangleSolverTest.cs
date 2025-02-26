using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class CheckTriangleSolverTest
    {
       [Test]
        public void Test_Equilateral_Triangle()
        {
            string result = Triangle.AnalyzeTriangle(5, 5, 5);
            Assert.That(result, Is.EqualTo("Equilateral triangle"));
        }
    }
}
