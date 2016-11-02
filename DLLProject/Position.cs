using DLLProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLLProject
{
    /// <summary>
    /// Generic class that discribe position collection/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Position<T> : MyCollection<Point<T>> where T : struct
    {
        private List<Point<T>> points { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="Position{T}"/> class.
        /// </summary>
        /// <param name="points">The matrices list.</param>
        public Position(List<Point<T>> points)
        {
            this.points = points;
        }

        /// <summary>
        /// Initialize a new instance of the <see cref="Position{T}"/> class.
        /// </summary>
        public Position()
        {
            
        }

        /// <summary>
        /// Adding an element to position
        /// </summary>
        /// <param name="item"></param>
        public override void Add(Point<T> item)
        {
            foreach (Point<T> p in currentList)
            {
                if (p.GetType() != item.GetType())
                {
                    throw new PositionTypeException("Positions type not match at " + currentList.IndexOf(p) + " position");
                }
            }

            currentList.Add(item);
        }
    }
}