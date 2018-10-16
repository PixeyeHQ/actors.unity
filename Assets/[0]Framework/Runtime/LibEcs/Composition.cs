/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  4:30 PM
================================================================*/


using System;
using System.Collections.Generic;


namespace Homebrew
{
  
    public class Composition : IEquatable<Composition>
    {
  
        internal int[] include = new int[0];
        internal int[] exclude = new int[0];


        public override bool Equals(object obj)
        {
            var other = obj as Composition;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            int hc = include.Length;
            int len1 = include.Length;
            int len2 = exclude.Length;

            unchecked
            {
                for (int i = 0; i < len1; ++i)
                {
                    hc = unchecked(hc * 17 + include[i]);
                }

                hc += exclude.Length;
                for (int i = 0; i < len2; ++i)
                {
                    hc = unchecked(hc * 31 + exclude[i]);
                }
            }

            return hc;
        }

     
 
        public bool Equals(Composition other)
        {
            if (include.Length != other.include.Length) return false;

            int len1 = include.Length;
            int len2 = exclude.Length;

            for (int i = 0; i < len1; i++)
            {
                if (include[i] != other.include[i]) return false;
            }

            if (exclude.Length != other.exclude.Length) return false;

            for (int i = 0; i < len2; i++)
            {
                if (exclude[i] != other.exclude[i]) return false;
            }

            return true;
        }
    }
}