using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class CheckTriangleSolverTest
    {
      [Test]
        public void Test_Scalene_Triangle_Case1()
        {
            string result = Triangle.AnalyzeTriangle(3, 4, 5);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void Test_Scalene_Triangle_Case2()
        {
            string result = Triangle.AnalyzeTriangle(6, 8, 10);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void Test_Scalene_Triangle_Case3()
        {
            string result = Triangle.AnalyzeTriangle(7, 11, 13);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void Test_Scalene_Triangle_Case4()
        {
            string result = Triangle.AnalyzeTriangle(9, 12, 15);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void Test_Scalene_Triangle_Case5()
        {
            string result = Triangle.AnalyzeTriangle(5, 7, 9);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }
    }
}
