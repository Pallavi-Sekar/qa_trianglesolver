using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class CheckTriangleSolverTest
    {
        [Test]
        public void Test_Valid_Scalene_Triangle_1()
        {
            int side1 = 3, side2 = 4, side3 = 5;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            Assert.That(result, Is.EqualTo("Scalene"));
        }

        [Test]
        public void Test_Valid_Scalene_Triangle_2()
        {
            int side1 = 8, side2 = 6, side3 = 7;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);


            Assert.That(result, Is.EqualTo("Scalene"));
        }

        [Test]
        public void Test_Valid_Scalene_Triangle_3()
        {
            int side1 = 9, side2 = 4, side3 = 12;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            Assert.That(result, Is.EqualTo("Scalene"));
        }

        [Test]
        public void Test_Valid_Scalene_Triangle_4()
        {

            int side1 = 15, side2 = 11, side3 = 9;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            Assert.That(result, Is.EqualTo("Scalene"));
        }

        [Test]
        public void Test_Valid_Scalene_Triangle_5()
        {

            int side1 = 20, side2 = 25, side3 = 30;


            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);


            Assert.That(result, Is.EqualTo("Scalene"));
        }


    }
}
