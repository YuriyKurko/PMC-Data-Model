using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLLProject
{

    public class PositionTypeException : Exception
    {
        public PositionTypeException()
        {
        }

        public PositionTypeException(string message)
            : base(message)
        {
        }

        public PositionTypeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class Matrix3DPointCountException : Exception
    {
        public Matrix3DPointCountException()
        {
        }

        public Matrix3DPointCountException(string message)
            : base(message)
        {
        }

        public Matrix3DPointCountException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class ContainersMatrixTypeException : Exception
    {
        public ContainersMatrixTypeException()
        {
        }
        public ContainersMatrixTypeException(string message)
        : base(message)
        {
        }
        public ContainersMatrixTypeException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }

    public class ContainerMatrixPositionCountException : Exception
    {
        public ContainerMatrixPositionCountException()
        {
        }
        public ContainerMatrixPositionCountException(string message)
        : base(message)
        {
        }
        public ContainerMatrixPositionCountException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }

    public class ContainersMatrixCountException : Exception
    {
        public ContainersMatrixCountException()
        {
        }
        public ContainersMatrixCountException(string message)
        : base(message)
        {
        }
        public ContainersMatrixCountException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}

