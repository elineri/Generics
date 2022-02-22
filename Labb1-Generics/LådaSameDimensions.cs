using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb1_Generics
{
    public class LådaSameDimensions : EqualityComparer<Låda>
    {
        // Compares if the objects are equal
        public override bool Equals(Låda L1, Låda L2)
        {
            if (L1.bredd == L2.bredd && L1.höjd == L2.höjd && L1.längd == L2.längd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Låda låd)
        {
            var hCode = låd.bredd ^ låd.höjd ^ låd.längd;
            return hCode.GetHashCode();
        }
    }
}
