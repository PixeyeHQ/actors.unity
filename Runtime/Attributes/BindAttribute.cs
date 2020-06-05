using System;

namespace Pixeye.Actors
{
  public class BindAttribute : Attribute
  {
    public int id;

    public BindAttribute(int id)
    {
      this.id = id;
    }

    public BindAttribute()
    {
    }
  }
}