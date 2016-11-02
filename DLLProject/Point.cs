using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLProject
{
    /// <summary>
    /// Generic abstract point class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Point<T> where T : struct
    {
        public T? x { get; set; }
        public T? y { get; set; }
        public T? z { get; set; }

        /// <summary>
        /// Initialize a new instance of the 1D Point
        /// </summary>
        /// <param name="x"></param>
        public Point(T? x)
        {
            this.x = x;
        }

        /// <summary>
        ///Initialize a new instance of the 2D Point
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(T? x, T? y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        ///Initialize a new instance of the 3D Point
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point(T? x, T? y, T? z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    /// <summary>
    /// Generic class that discribe 1D Point/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Point1D<T> : Point<T> where T : struct
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="Point1D{T}"/> class.
        /// </summary>
        /// <param name="x"></param>
        public Point1D(T? x) : base(x)
        {
            this.x = x;
        }
    }

    /// <summary>
    /// Generic class that discribe 2D Point/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Point2D<T> : Point<T> where T : struct
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="Point2D{T}"/> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point2D(T? x, T? y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }
    }

    /// <summary>
    /// Generic class that discribe 3D Point/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Point3D<T> : Point<T> where T : struct
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="Point3D{T}"/> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point3D(T? x, T? y, T? z) : base(x, y, z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

}