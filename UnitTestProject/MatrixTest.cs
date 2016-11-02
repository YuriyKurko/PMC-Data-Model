using DLLProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        [ExpectedException(typeof(PositionTypeException))]
        public void DifferentMatrixPositionType()
        {
            Random random = new Random();

            Position<double> position1 = new Position<double>();
            Position<double> position2 = new Position<double>();
            Matrix<double> matrix = new Matrix<double>();

            for (int i= 0; i < 100; i++)
            {
                position1.Add(new Point2D<double>(random.NextDouble(), random.NextDouble()));
                position2.Add(new Point1D<double>(random.NextDouble()));
            }

            matrix.Add(position1);
            matrix.Add(position2);
        }

        [TestMethod]
        [ExpectedException(typeof(Matrix3DPointCountException))]
        public void MatrixSameNumber3DPosition()
        {
            Random random = new Random();

            Position<double> position1 = new Position<double>();
            Position<double> position2 = new Position<double>();
            Matrix<double> matrix = new Matrix<double>();

            for (int i = 0; i < 200; i++)
            {
                if (i < 100)
                {
                    position1.Add(new Point3D<double>(random.NextDouble(), random.NextDouble(), random.NextDouble()));
                }

                position2.Add(new Point3D<double>(random.NextDouble(), random.NextDouble(), random.NextDouble()));
            }

            matrix.Add(position1);
            matrix.Add(position2);
        }
    }
}
