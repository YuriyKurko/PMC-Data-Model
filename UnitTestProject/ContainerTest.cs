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
    public class ContainerTest
    {
        [TestMethod]
        [ExpectedException(typeof(ContainerMatrixPositionCountException))]
        public void ContainerMatrixPositionCount()
        {
            Random random = new Random();

            Position<double> position1 = new Position<double>();
            Position<double> position2 = new Position<double>();

            Matrix<double> matrix1 = new Matrix<double>();
            Matrix<double> matrix2 = new Matrix<double>();

            Container<double> container = new Container<double>();


            matrix1.Add(position1);
            matrix1.Add(position1);
            matrix1.Add(position1);
            matrix1.Add(position1);

            matrix2.Add(position2);

            container.Add(matrix1);
            container.Add(matrix2);

        }
    }
}
