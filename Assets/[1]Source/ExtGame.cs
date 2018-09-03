//   Project : Battlecruiser3.0
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/18/2018

using Homebrew;
using UnityEngine;

public static class ExtGame
{
    public static readonly Vector2[] sides = {Vector2.up, Vector2.right, Vector2.down, Vector2.left};
    public static readonly RaycastHit2D[] hits = new RaycastHit2D[20];
    public static readonly Collider2D[] colliders = new Collider2D[20];
 
    public static int[] Convert(this TagNode[] tagNodes)
    {
        var tags = new int[tagNodes.Length];
        for (int i = 0; i < tagNodes.Length; i++)
        {
            tags[i] = tagNodes[i].tag;
        }

        return tags;
    }

    public static void TagsAdd(this Actor a, params TagNode[] tagNodes)
    {
        var tags = new int[tagNodes.Length];

        for (int i = 0; i < tagNodes.Length; i++)
        {
            tags[i] = tagNodes[i].tag;
        }

        a.TagsAdd(tags);
    }
}