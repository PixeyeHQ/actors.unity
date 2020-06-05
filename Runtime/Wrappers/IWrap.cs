//  Project  : ecs
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;

namespace Pixeye.Actors
{
  public interface IWrap<TProp> : IWrap
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    IWrap<TProp> Subscribe(Action<TProp> callback);
  }

  public interface IWrap
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void FirstTime();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void Check();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void Dispose();
  }
}