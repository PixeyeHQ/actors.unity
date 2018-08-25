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
    public delegate void CompositionDelegate(bool added);

    public class Composition : IEquatable<Composition>
    {
        public List<CompositionDelegate> delegates = new List<CompositionDelegate>(4);
        public List<int> ids = new List<int>(20);
        public bool changed;

        public Composition TagsInclude(params int[] include)
        {
            this.include = include;
            return this;
        }

        public Composition TagsExclude(params int[] exclude)
        {
            this.exclude = exclude;
            return this;
        }


        public Composition Add(CompositionDelegate del)
        {
            delegates.Add(del);
            return this;
        }

        public Composition Add<T>() where T : new()
        {
            var key = typeof(T).GetHashCode();
            ids.Add(key);
            if (Behavior.behaviors.ContainsKey(key)) return this;

            var behavior = new T() as Behavior;
            Behavior.behaviors.Add(key, behavior);
     
            return this;
        }


        public int[] include = new int[0];
        public int[] exclude = new int[0];


        public override bool Equals(object obj)
        {
            var other = obj as Composition;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            var hc = include.Length;
            var len1 = include.Length;
            var len2 = exclude.Length;

            unchecked
            {
                for (var i = 0; i < len1; ++i)
                {
                    hc = unchecked(hc * 17 + include[i]);
                }

                hc += exclude.Length;
                for (var i = 0; i < len2; ++i)
                {
                    hc = unchecked(hc * 31 + exclude[i]);
                }
            }

            return hc;
        }

    
        public bool Contain(IReadOnlyDictionary<int, int> tags)
        {
            for (var i = 0; i < include.Length; i++)
            {
                if (!tags.ContainsKey(include[i])) return false;
            }

            for (var i = 0; i < exclude.Length; i++)
            {
                if (tags.ContainsKey(exclude[i])) return false;
            }

            return true;
        }

        private static bool HasTags(IReadOnlyDictionary<int, int> tags, params int[] filter)
        {
            for (var i = 0; i < filter.Length; i++)
            {
                if (!tags.ContainsKey(filter[i])) return false;
            }

            return true;
        }

        public static bool HasTagAny(IReadOnlyDictionary<int, int> tags, params int[] filter)
        {
            for (var i = 0; i < filter.Length; i++)
            {
                if (tags.ContainsKey(filter[i])) return true;
            }

            return false;
        }


        public bool Equals(Composition other)
        {
            if (include.Length != other.include.Length) return false;

            var len1 = include.Length;
            var len2 = exclude.Length;

            for (var i = 0; i < len1; i++)
            {
                if (include[i] != other.include[i]) return false;
            }

            if (exclude.Length != other.exclude.Length) return false;

            for (var i = 0; i < len2; i++)
            {
                if (exclude[i] != other.exclude[i]) return false;
            }

            return true;
        }
    }
}