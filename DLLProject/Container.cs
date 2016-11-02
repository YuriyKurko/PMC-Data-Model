using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLLProject
{
    /// <summary>
    /// Generic class that discribe container collection/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Container<T> : MyCollection<Matrix<T>> where T : struct
    {
        private List<Matrix<T>> matrices { get;  set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="Container{T}"/> class.
        /// </summary>
        /// <param name="matrices">The matrices list.</param>
        public Container(List<Matrix<T>> matrices)
        {
            this.matrices = matrices;
        }

        /// <summary>
        /// Initialize a new instance of the <see cref="Container{T}"/> class.
        /// </summary>
        public Container()
        {
        }

        /// <summary>
        /// Adding an element to container
        /// </summary>
        /// <param name="item"></param>
        public override void Add(Matrix<T> item)
        {
            foreach (Matrix<T> m in currentList)
            {
                if (m.Count != item.Count)
                {
                    throw new ContainerMatrixPositionCountException("Matrix position count not match at " + currentList.IndexOf(m) + " matrix");
                }
            }
            currentList.Add(item);
        }
    }
}
