using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLLProject
{
    /// <summary>
    /// Generic class that discribe matrix collection/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Matrix<T> : MyCollection<Position<T>> where T: struct  
    {
        private List<Position<T>> positions { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="Matrix{T}"/> class.
        /// </summary>
        /// <param name="positions">The matrices list.</param>
        public Matrix(List<Position<T>> positions)
        {
            this.positions = positions;
        }

        /// <summary>
        /// Initialize a new instance of the <see cref="Matrix{T}"/> class.
        /// </summary>
        public Matrix()
        {

        }

        /// <summary>
        /// Adding an element to matrix
        /// </summary>
        /// <param name="item"></param>
        public override void Add(Position<T> item)
        {
            if (item.Count > 0)
            {
                foreach (Position<T> p in currentList)
                {
                    if (p.FirstOrDefault().GetType() != item.FirstOrDefault().GetType())
                    {
                        throw new PositionTypeException("Positions type not match at " + currentList.IndexOf(p) + " position");
                    }

                    if (p.FirstOrDefault().GetType() == typeof(Point3D<T>))
                    {
                        if (p.Count != item.Count)
                        {
                            throw new Matrix3DPointCountException("Points count not match at " + currentList.IndexOf(p) + " position");
                        }
                    }
                }
            }
            currentList.Add(item);
        }
    }
}
