using KRAssignment2;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        string equilateral()
        {
            return TriangleSolver.Analize("1", "1", "1");
        }

        string isosceles()
        {
            return TriangleSolver.Analize("1", "1", "2");
        }

        string scalene()
        {
            return TriangleSolver.Analize("1", "2", "3");
        }

        string neither()
        {
            return TriangleSolver.Analize("-8", "-9", "-10");
        }

        string sideEqualToZero()
        {
            return TriangleSolver.Analize("0", "0", "0");
        }

        /*If the method receive all the sides of the triangle and all values are positive it can form a triangle,
         so here i validate what kind of trangle is formed (equilateral, isosceles or scalene)*/
        [Test]
        public void TestEquilateralMethod()
        {
            Assert.AreEqual(equilateral(), TriangleSolver.Analize("1", "1", "1"));
        }

        [Test]
        public void TestIsoscelesMethod()
        {
            Assert.AreEqual(isosceles(), TriangleSolver.Analize("2", "1", "1"));
        }

        [Test]
        public void TestScaleneMethod()
        {
            Assert.AreEqual(scalene(), TriangleSolver.Analize("2", "3", "4"));
        }


        /*If the method return neither means that the method receives all the sides but it cannot form a tringle with negative values */
        [Test]
        public void TestNeitherMethod()
        {
            Assert.AreSame(neither(), TriangleSolver.Analize("-1", "-2", "-3"));
        }

        /*If the method return empty means that is missing one or more side of the
        triangle, so here i evaluate if the conditions is fulfilled if no value is entered.*/
        [Test]
        public void TestEmptySideMethod()
        {
            Assert.IsEmpty(TriangleSolver.Analize("1", "2", ""));
        }

        /*If the first codition is different that the second is fullfilled since evaluate 
         different cases values equal to zero and negative values.*/
        [Test]
        public void TestSideEqualToZeroMethod()
        {
            Assert.AreNotEqual(neither(), TriangleSolver.Analize("0", "0", "0"));
        }
    }
}