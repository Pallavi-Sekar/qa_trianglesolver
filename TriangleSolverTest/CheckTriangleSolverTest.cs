using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class CheckTriangleSolverTest
    {
      [Test]
        public void Test_Invalid_Zero_Side_Case1()
        {
            string result = Triangle.AnalyzeTriangle(0, 3, 3);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void Test_Invalid_Zero_Side_Case2()
        {
            string result = Triangle.AnalyzeTriangle(3, 0, 4);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void Test_Invalid_Zero_Side_Case3()
        {
            string result = Triangle.AnalyzeTriangle(4, 5, 0);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }
    }
}
