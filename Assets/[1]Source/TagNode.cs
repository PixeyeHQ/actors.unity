//   Project : Actors-Example
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/24/2018

using Homebrew;

[System.Serializable]
public struct TagNode
{
    [TagFilter(typeof(Tag))] public int tag;
}