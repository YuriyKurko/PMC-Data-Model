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
    public class ContainersTest
    {
        [TestMethod]
        [ExpectedException(typeof(ContainersMatrixTypeException))]
        public void ContainerMatrixType()
        {
            Random random = new Random();

            Point2D<double> point1 = new Point2D<double>(1, 1);
            Point3D<double> point2 = new Point3D<double>(1, 1, 1);

            Position<double> position1 = new Position<double>();
            Position<double> position2 = new Position<double>();

            Matrix<double> matrix1 = new Matrix<double>();
            Matrix<double> matrix2 = new Matrix<double>();

            Container<double> container1 = new Container<double>();
            Container<double> container2 = new Container<double>();

            Containers<double> containers = new Containers<double>();

            position1.Add(point1);
            position1.Add(point1);

            position2.Add(point2);
            position2.Add(point2);

            matrix1.Add(position1);
            matrix1.Add(position1);

            matrix2.Add(position2);
            matrix2.Add(position2);

            container1.Add(matrix1);
            container2.Add(matrix2);

            containers.Add(container1);
            containers.Add(container2);

        }

        [TestMethod]
        [ExpectedException(typeof(ContainersMatrixCountException))]
        public void ContainerMatrixCount()
        {
            Random random = new Random();

            Point2D<double> point1 = new Point2D<double>(1, 1);
            Point3D<double> point2 = new Point3D<double>(1, 1, 1);

            Position<double> position1 = new Position<double>();
            Position<double> position2 = new Position<double>();

            Matrix<double> matrix1 = new Matrix<double>();

            Container<double> container1 = new Container<double>();
            Container<double> container2 = new Container<double>();

            Containers<double> containers = new Containers<double>();

            position1.Add(point1);
            position1.Add(point1);

            position2.Add(point2);
            position2.Add(point2);

            matrix1.Add(position1);
            matrix1.Add(position1);

            container1.Add(matrix1);
            container1.Add(matrix1);
            container1.Add(matrix1);

            container2.Add(matrix1);

            containers.Add(container1);
            containers.Add(container2);
        }


        [TestMethod]
        public void LargeDataSetStress()
        {
            Random random = new Random();

            Containers<int> containers = new Containers<int>();
            for (int i = 0; i < 2; i++)
            {
                Container<int> container = new Container<int>();
                for (int j = 0; j < 1000; j++)
                {
                    Matrix<int> matrix = new Matrix<int>();
                    for (int k = 0; k < 500; k++)
                    {
                        Position<int> position = new Position<int>();
                        for (int m = 0; m < 2; m++)
                        {
                            position.Add(new Point2D<int>(random.Next(10), random.Next(10)));
                        }
                        matrix.Add(position);
                    }
                    container.Add(matrix);
                }
                containers.Add(container);
            }
        }

    }
}
