using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1_Generics
{
    public class Låda : IEquatable<Låda>
    {
        public Låda(int h, int l, int b)
        {
            this.höjd = h;
            this.längd = l;
            this.bredd = b;
        }

        // Dimensions for height, length and width to check if the boxes are equal

        public int höjd { get; set; }
        public int längd { get; set; }
        public int bredd { get; set; }


        public bool Equals(Låda other) // Checks if two objects are equal
        {
            if (new LådaSameDimensions().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
