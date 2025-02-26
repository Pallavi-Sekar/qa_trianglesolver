using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class CheckTriangleSolverTest
    {
      [Test]
        public void Test_Isosceles_Triangle_Case1()
        {
            string result = Triangle.AnalyzeTriangle(5, 5, 3);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void Test_Isosceles_Triangle_Case2()
        {
            string result = Triangle.AnalyzeTriangle(4, 4, 6);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void Test_Isosceles_Triangle_Case3()
        {
            string result = Triangle.AnalyzeTriangle(7, 9, 9);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }
    }
}
