using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class CheckTriangleSolverTest
    {
        [Test]
        public void Test_Valid_Isosceles_Triangle_1()
        {
            /
            int side1 = 5, side2 = 5, side3 = 3;

          
            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            
            Assert.That(result, Is.EqualTo("Isosceles"));
        }

        [Test]
        public void Test_Valid_Isosceles_Triangle_2()
        {
          
            int side1 = 6, side2 = 6, side3 = 4;

         
            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

           
            Assert.That(result, Is.EqualTo("Isosceles"));
        }

        [Test]
        public void Test_Valid_Isosceles_Triangle_3()
        {
           
            int side1 = 7, side2 = 7, side3 = 5;

            string result = TriangleSolver.TriangleSolver.GetTriangleType(side1, side2, side3);

            Assert.That(result, Is.EqualTo("Isosceles"));
        }

    }
}
