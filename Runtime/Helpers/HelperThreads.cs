//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games


using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
 
namespace Pixeye.Framework
{
	public static class HelperThreads
	{
	}

	public delegate void HandleSegmentGroup(SegmentGroup segment);

	public sealed class SegmentGroup
	{
		public GroupCore source;
		public float delta;

		public int indexFrom;
		public int indexTo;

		internal Thread thread;
		internal ManualResetEvent HasWork;
		internal ManualResetEvent WorkDone;


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Enumerator GetEnumerator()
		{
			return new Enumerator(indexFrom, indexTo);
		}

		public struct Enumerator : IEnumerator<int>
		{
			readonly int length;
			int position;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal Enumerator(int from, int to)
			{
				position = from - 1;
				length   = to;
			}

			public int Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get { return position; }
			}

			object IEnumerator.Current => Current;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return ++position < length;
			}


			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Dispose()
			{
			}


			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Reset()
			{
				position = -1;
			}
		}
	}
}