﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb1_Generics
{
    // Class to compare volume of the boxes to check if equal
    public class LådaSameVolume : EqualityComparer<Låda>
    {
        public override bool Equals(Låda L1, Låda L2)
        {
            if ((L1.bredd, L1.höjd, L1.längd) == (L2.bredd, L2.höjd, L2.längd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Låda låd) // Used to check if objects have same hash code
        {
            int hCode = låd.bredd ^ låd.höjd ^ låd.längd;
            Console.WriteLine("Hash code: " + hCode,GetHashCode());
            return hCode.GetHashCode();
        }
    }
}
