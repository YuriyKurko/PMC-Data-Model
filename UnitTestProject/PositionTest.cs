using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DLLProject;

namespace UnitTestProject
{
    [TestClass]
    public class PositionTest
    {
        [TestMethod]
        public void PositionAdd()
        {
            Position<int> position = new Position<int>();
            Point<int> point = new Point1D<int>(1);
            position.Add(point);
            Assert.IsTrue(position.Contains(point));
        }

        [TestMethod]
        public void NullPointPosition()
        {
            Position<decimal> position = new Position<decimal>();
            Matrix<decimal> matrix = new Matrix<decimal>();

            matrix.Add(position);

            Assert.IsTrue(matrix[0].Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(PositionTypeException))]
        public void DifferentPositionType()
        {
            Point<double> point1 = new Point2D<double>(2, 1);
            Point<double> point2 = new Point3D<double>(2, 4, 5);
            Position<double> position = new Position<double>();
            position.Add(point1);
            position.Add(point2);
        }
    }
}

