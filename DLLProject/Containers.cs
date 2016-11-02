using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLLProject

{    /// <summary>
     /// Generic class that discribe container collection/>
     /// </summary>
     /// <typeparam name="T"></typeparam>
    public class Containers<T> : MyCollection<Container<T>> where T : struct
    {
        private List<Container<T>> containers { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="Containers{T}"/> class.
        /// </summary>
        /// <param name="containers">The matrices list.</param>
        public Containers(List<Container<T>> containers)
        {
            this.containers = containers;
        }

        /// <summary>
        /// Initialize a new instance of the <see cref="Containers{T}"/> class.
        /// </summary>
        public Containers()
        {


        }

        /// <summary>
        /// Return string with containers result
        /// </summary>
        public string PrintResult(Containers<T> containers)
        {
            string result = "";
            int containerNumber = 0;

            foreach (Container<T> container in containers)
            {
                result += $"Container<{containerNumber}>\n";
                containerNumber++;
                int matrixNumber = 0;
                foreach (Matrix<T> matrix in container)
                {
                    result += $"\t Matrix<{matrixNumber}>\n";
                    matrixNumber++;
                    int positionNumber = 0;
                    foreach (Position<T> position in matrix)
                    {
                        result += $"\t\t Postion<{positionNumber}>\n";
                        positionNumber++;
                        int pointNumber = 0;
                        foreach (var point in position)
                        {
                            result += $"\t\t\tPoint<{pointNumber}> {point.x,2}   {point.y}   {point.z}\n";
                            pointNumber++;
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Adding an element to containers
        /// </summary>
        /// <param name="item"></param>
        public override void Add(Container<T> item)
        {
            foreach (Container<T> c in currentList)
            {
                if (item[0][0].Count > 0)
                {

                    if (c.FirstOrDefault().FirstOrDefault().FirstOrDefault().GetType() != item.FirstOrDefault().FirstOrDefault().FirstOrDefault().GetType())
                    {
                        throw new ContainersMatrixTypeException("Matrix type not match at " + currentList.IndexOf(c) + " matrix");
                    }
                }

                if (c.Count != item.Count)
                {
                    throw new ContainersMatrixCountException("Matrix count not match at " + currentList.IndexOf(c) + " container");
                }

            }
            currentList.Add(item);
        }
    }
}

