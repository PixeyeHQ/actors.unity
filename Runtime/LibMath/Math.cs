using System.Runtime.CompilerServices;
 
 
namespace Pixeye.Framework
{
    public static partial class HelperFramework
    {
        #region MATH
	
		public static bool Every(this float step, float time)
		{
			if (step % time == 0)
			{
				return true;
			}

			return false;
		}

		public static bool Every(this int step, float time)
		{
			if (step % time == 0)
			{
				return true;
			}

			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool PlusCheck(ref this float arg0_pl, float val_pl, float clamp_pl = 1f)
		{
			arg0_pl = Math.Min(clamp_pl, arg0_pl + val_pl);
			return arg0_pl == clamp_pl;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool MinusCheck(ref this float arg0_mn, float val_mn, float clamp_mn = 0f)
		{
			arg0_mn = Math.Max(clamp_mn, arg0_mn - val_mn);
			return arg0_mn == clamp_mn;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool PlusCheck(ref this int arg0_pl, int val_pl, int clamp_pl = 1)
		{
			arg0_pl = Math.Min(clamp_pl, arg0_pl + val_pl);
			return arg0_pl == clamp_pl;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool MinusCheck(ref this int arg0_mn, int val_mn, int clamp_mn = 0)
		{
			arg0_mn = Math.Max(clamp_mn, arg0_mn - val_mn);
			return arg0_mn == clamp_mn;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Plus(ref this float arg0_pl, float val_pl, float clamp_pl = 1f)
		{
			arg0_pl = Math.Min(clamp_pl, arg0_pl + val_pl);
			;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Minus(ref this float arg0_mn, float val_mn, float clamp_mn = 0f)
		{
			arg0_mn = Math.Max(clamp_mn, arg0_mn - val_mn);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Plus(ref this int arg0_pl, int val_pl, int clamp_pl = 1)
		{
			arg0_pl = Math.Min(clamp_pl, arg0_pl + val_pl);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Minus(ref this int arg0_mn, int val_mn, int clamp_mn = 0)
		{
			arg0_mn = Math.Max(clamp_mn, arg0_mn - val_mn);
			;
		}

		#endregion

		#region BITS

		public static void BitOn(this ref int bitToTurnOn, int value)
		{
			bitToTurnOn |= value;
		}

		public static void BitOff(this ref int bitToTurnOff, int value)
		{
			bitToTurnOff &= ~value;
		}

		public static void BitFlip(this ref int bitToFlip, int value)
		{
			bitToFlip = value ^ bitToFlip;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool BitCheck(this ref int bits, int value)
		{
			return (bits & value) == value;
		}

		#endregion
    }
}