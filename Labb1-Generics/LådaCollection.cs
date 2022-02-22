using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb1_Generics
{
    public class LådaCollection : ICollection<Låda>
    {
        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }

        private List<Låda> innerCol;

        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }

        public Låda this[int index]
        {
            get { return (Låda)innerCol[index]; }
            set { innerCol[index] = value; }
        }

        public bool Contains(Låda item)
        {
            bool found = false;

            foreach (Låda L in innerCol)
            {
                if (L.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public bool Contains(Låda item, EqualityComparer<Låda> comp)
        {
            bool found = false;

            foreach (Låda L in innerCol)
            {
                if (comp.Equals(L, item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void Add(Låda item)
        {
            if (!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine($"En låda med dessa dimensionerna " +
                    $"(Höjd {item.höjd}, Bredd {item.bredd}, Längd {item.längd}) finns redan.");
            }
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public int Count
        {
            get { return innerCol.Count; }
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("Arrayen kan inte vara null");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("Startindex i arrayen kan inte vara mindre än 0");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("Arrayen har färre element än Collection");

            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }

        public bool Remove(Låda item)
        {
            bool result = false;

            for (int i = 0; i < innerCol.Count; i++)
            {
                Låda curLåda = innerCol[i];

                if (new LådaSameDimensions().Equals(curLåda, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        public bool IsReadOnly
        {
            get { return false; }
        }
    }
}
