using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace System.NET.CSharp.General
{
	public static class Randomizer
	{
		public static byte RndNumber(byte min, byte max)
		{
			Random rnd = new Random();
			return (byte)rnd.Next(min, max);
		}
		public static byte RndNumberExcl(byte min, byte max)
		{
			Random rnd = new Random();
			return (byte)rnd.Next(min + 1, max - 1);
		}

		public static int RndNumber(int min, int max)
		{
			Random rnd = new Random();
			return rnd.Next(min, max);
		}
		public static int RndNumberExcl(int min, int max)
		{
			Random rnd = new Random();
			return rnd.Next(min + 1, max - 1);
		}

		public static sbyte RndNumber(sbyte min, sbyte max)
		{
			Random rnd = new Random();
			return (sbyte)rnd.Next(min, max);
		}
		public static sbyte RndNumberExcl(sbyte min, sbyte max)
		{
			Random rnd = new Random();
			return (sbyte)rnd.Next(min + 1, max - 1);
		}

		public static short RndNumber(short min, short max)
		{
			Random rnd = new Random();
			return (short)rnd.Next(min, max);
		}
		public static short RndNumberExcl(short min, short max)
		{
			Random rnd = new Random();
			return (short)rnd.Next(min + 1, max - 1);
		}

		public static uint RndNumber(uint min, uint max)
		{
			Random rnd = new Random();
			return (uint)rnd.Next((int)min, (int)max);
		}
		public static uint RndNumberExcl(uint min, uint max)
		{
			Random rnd = new Random();
			return (uint)rnd.Next((int)min + 1, (int)max - 1);
		}

		public static ushort RndNumber(ushort min, ushort max)
		{
			Random rnd = new Random();
			return (ushort)rnd.Next(min, max);
		}
		public static ushort RndNumberExcl(ushort min, ushort max)
		{
			Random rnd = new Random();
			return (ushort)rnd.Next(min + 1, max - 1);
		}

		public static object RndNumber()
		{
			Random rnd = new Random();
			return rnd.Next();
		}

		public static Color RndColor()
		{
			List<Color> allColors = typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public)
				.Select(c => (Color)c.GetValue(null, null)).ToList();
			Random rnd = new Random();
			return allColors[rnd.Next(allColors.Count - 1)];
		}
	}
}
