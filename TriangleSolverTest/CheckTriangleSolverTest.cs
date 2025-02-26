using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class CheckTriangleSolverTest
    {
      [Test]
        public void Test_Invalid_Triangle_Inequality_Case1()
        {
            string result = Triangle.AnalyzeTriangle(1, 2, 3);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }

        [Test]
        public void Test_Invalid_Triangle_Inequality_Case2()
        {
            string result = Triangle.AnalyzeTriangle(10, 2, 2);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }

        [Test]
        public void Test_Invalid_Triangle_Inequality_Case3()
        {
            string result = Triangle.AnalyzeTriangle(4, 1, 2);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }
    }
}
