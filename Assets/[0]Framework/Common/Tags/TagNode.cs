//   Project : Actors-Example
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/24/2018
namespace Homebrew
{
    [System.Serializable]
    public class TagNode
    {
        [TagFilter(typeof(Tag))] public int tag;
    }

    public static partial class FrameworkExtensions
    {
        public static int[] Convert(this TagNode[] tagNodes)
        {
            var tags = new int[tagNodes.Length];
            for (int i = 0; i < tagNodes.Length; i++)
            {
                tags[i] = tagNodes[i].tag;
            }

            return tags;
        }
                      
        public static void ConvertTags(this Actor a, params TagNode[] tagNodes)
        {
            var tags = new int[tagNodes.Length];

            for (int i = 0; i < tagNodes.Length; i++)
            {
                tags[i] = tagNodes[i].tag;
            }

            a.entity.Add(tags);
        }
    }
}