namespace Pixeye.Actors
{
  public class groups
  {
    public GroupCore this[int index] => globals[index];

    public static bool has(int index)
    {
      return globals.Length > index && globals[index] != null;
    }

    public static GroupCore[] globals = new GroupCore[32];
    internal static CacheGroup All = new CacheGroup();
    internal static FamilyGroupTags ByTag = new FamilyGroupTags();
    internal static FamilyGroupTags ByType = new FamilyGroupTags();
  }
}