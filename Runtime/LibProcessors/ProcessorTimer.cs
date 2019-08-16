//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;
using Pixeye.Framework;
using Unity.IL2CPP.CompilerServices;
 
namespace Pixeye.Source
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	sealed class ProcessorTimer : ITick, IKernel
	{

		internal static ProcessorTimer Default = new ProcessorTimer();

		internal Timer[] source = new Timer[10];
		internal int length;

		public ProcessorTimer()
		{
			ProcessorUpdate.Add(this);
		}

		public void Tick(float delta)
		{
			for (int i = 0; i < length; i++)
			{
				ref var timer = ref source[i];
				ref var t = ref timer.t;

				if ((t -= delta) > delta) continue;

				timer.action();
				RemoveAt(i);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void RemoveAt(int index)
		{
			--length;
			for (int i = index; i < length; ++i)
				SetElement(i, ref source[i + 1]);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SetElement(int index, ref Timer arg)
		{
			source[index] = arg;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ref Timer Add(float t, Action action)
		{
			if (length >= source.Length)
				Array.Resize(ref source, length << 1);

			var index = length++;
			Timer timer;
			timer.action = action;
			timer.t = t;
			timer.pointer = index;
			source[index] = timer;
			return ref source[index];
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal int Restart(float t, Action action)
		{
			if (length >= source.Length)
				Array.Resize(ref source, length << 1);

			var index = length++;
			Timer timer;
			timer.action = action;
			timer.t = t;
			timer.pointer = index;
			source[index] = timer;
			return index;
		}
	 
		public void Dispose()
		{
			for (int i = 0; i < length; i++)
			{
				source[i].action = null;
			}
			length = 0;
		}

	}
}