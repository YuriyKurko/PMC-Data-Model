using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLLProject
{
    public abstract class MyCollection<T> : ICollection<T>
    {
        protected List<T> currentList;
        protected bool isReadOnly;

        /// <summary>
        /// Constructor, that inicializates a collection storage
        /// </summary>
        public MyCollection()
        {
            currentList = new List<T>();
        }

        /// <summary>
        /// Indexer  for the collection
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public virtual T this[int index]
        {
            get { return (T)currentList[index]; }
            set { currentList[index] = value; }
        }

        /// <summary>
        /// Count property
        /// Shows, how many elements does this collection contain
        /// </summary>
        public virtual int Count
        {
            get { return currentList.Count; }
        }
        /// <summary>
        /// Is Read Only Property
        /// Shows, if the collection is Read Only or not
        /// </summary>
        public virtual bool IsReadOnly
        {
            get
            {
                return isReadOnly;
            }
        }

        /// <summary>
        /// Abstract method for adding element to collection
        /// </summary>
        /// <param name="item"></param>
        public abstract void Add(T item);
 
        /// <summary>
        /// Method for removing element from the collection
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public virtual bool Remove(T item)
        {
            bool result = false;

            for (int i = 0; i < currentList.Count; i++)
            {
                T obj = (T)currentList[i];


                if (obj.Equals(item))
                {
                    currentList.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Method, that shows if the collection does contain the searching element in it
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public virtual bool Contains(T item)
        {
            foreach (var position in currentList)
            {
                if (position.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method that copies an array contens to the collection
        /// </summary>
        /// <param name="positions">array that should be copy to collection</param>
        /// <param name="index">index of the element since which should start copy</param>
        public virtual void CopyTo(T[] positions, int index)
        {
            currentList.CopyTo(positions, index);
        }

        /// <summary>
        /// Method that allows to clear all the contans of the collection
        /// </summary>
        public void Clear()
        {
            currentList.Clear();
        }

        /// <summary>
        /// Virtual method for creating the enumartor of collection
        /// </summary>
        public virtual IEnumerator<T> GetEnumerator()
        {
            foreach (var item in currentList)
            {
                yield return (T)item;
            }
        }

        /// <summary>
        /// Sets the enumerator
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
