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

        [Test]
        public void Test_Isosceles_Triangle()
        {
            string result = Triangle.AnalyzeTriangle(5, 5, 3);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void Test_Scalene_Triangle()
        {
            string result = Triangle.AnalyzeTriangle(3, 4, 5);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void Test_Invalid_Zero_Side()
        {
            string result = Triangle.AnalyzeTriangle(0, 3, 3);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void Test_Invalid_Negative_Side()
        {
            string result = Triangle.AnalyzeTriangle(-2, 3, 3);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void Test_Invalid_Triangle_Inequality()
        {
            string result = Triangle.AnalyzeTriangle(1, 2, 3);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }

        [Test]
        public void Test_Invalid_Triangle_Inequality_LargeSide()
        {
            string result = Triangle.AnalyzeTriangle(10, 2, 2);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }

        [Test]
        public void Test_Invalid_Negative_Side_Triangle_Inequality()
        {
            string result = Triangle.AnalyzeTriangle(5, -1, 3);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void Test_Invalid_Zero_Side_AnotherCombination()
        {
            string result = Triangle.AnalyzeTriangle(3, 0, 4);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }
    }
}
