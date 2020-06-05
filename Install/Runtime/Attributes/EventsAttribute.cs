//  Project : Actors
// Contacts : Pix - ask@pixeye.games

#if ACTORS_EVENTS_MANUAL
using System;

namespace Pixeye.Actors
{
  public class EventsAttribute : Attribute
  {
    public Op op;

    public EventsAttribute(Op op)
    {
      this.op = op;
    }
  }
}

#endif