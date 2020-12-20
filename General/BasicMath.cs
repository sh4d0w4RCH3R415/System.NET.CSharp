namespace System.NET.CSharp.General
{
	public static class BasicMath
	{
		public const double PI = Math.PI;
		public const double E = Math.E;

		#region Maximum & Minimum Values
		public const byte BYTE_MAX = byte.MaxValue;
		public const byte BYTE_MIN = byte.MinValue;

		public const decimal DECIMAL_MAX = decimal.MaxValue;
		public const decimal DECIMAL_MIN = decimal.MinValue;

		public const double DOUBLE_MAX = double.MaxValue;
		public const double DOUBLE_MIN = double.MinValue;

		public const float FLOAT_MAX = float.MaxValue;
		public const float FLOAT_MIN = float.MinValue;

		public const int INT_MAX = int.MaxValue;
		public const int INT_MIN = int.MinValue;

		public const long LONG_MAX = long.MaxValue;
		public const long LONG_MIN = long.MinValue;

		public const sbyte SBYTE_MAX = sbyte.MaxValue;
		public const sbyte SBYTE_MIN = sbyte.MinValue;

		public const short SHORT_MAX = short.MaxValue;
		public const short SHORT_MIN = short.MinValue;

		public const uint UINT_MAX = uint.MaxValue;
		public const uint UINT_MIN = uint.MinValue;

		public const ulong ULONG_MAX = ulong.MaxValue;
		public const ulong ULONG_MIN = ulong.MinValue;

		public const ushort USHORT_MAX = ushort.MaxValue;
		public const ushort USHORT_MIN = ushort.MinValue;
		#endregion
		#region Add
		public static byte Add(byte num1, byte num2)
		{
			return (byte)(num1 + num2);
		}
		public static decimal Add(decimal num1, decimal num2)
		{
			return num1 + num2;
		}
		public static double Add(double num1, double num2)
		{
			return (double)(num1 + num2);
		}
		public static float Add(float num1, float num2)
		{
			return (float)(num1 + num2);
		}
		public static int Add(int num1, int num2)
		{
			return num1 + num2;
		}
		public static long Add(long num1, long num2)
		{
			return num1 + num2;
		}
		public static sbyte Add(sbyte num1, sbyte num2)
		{
			return (sbyte)(num1 + num2);
		}
		public static short Add(short num1, short num2)
		{
			return (short)(num1 + num2);
		}
		public static uint Add(uint num1, uint num2)
		{
			return num1 + num2;
		}
		public static ulong Add(ulong num1, ulong num2)
		{
			return num1 + num2;
		}
		public static ushort Add(ushort num1, ushort num2)
		{
			return (ushort)(num1 + num2);
		}
		#endregion
		#region Subtract
		public static byte Subtract(byte num1, byte num2)
		{
			return (byte)(num1 - num2);
		}
		public static decimal Subtract(decimal num1, decimal num2)
		{
			return num1 - num2;
		}
		public static double Subtract(double num1, double num2)
		{
			return (double)(num1 - num2);
		}
		public static float Subtract(float num1, float num2)
		{
			return (float)(num1 - num2);
		}
		public static int Subtract(int num1, int num2)
		{
			return num1 - num2;
		}
		public static long Subtract(long num1, long num2)
		{
			return num1 - num2;
		}
		public static sbyte Subtract(sbyte num1, sbyte num2)
		{
			return (sbyte)(num1 - num2);
		}
		public static short Subtract(short num1, short num2)
		{
			return (short)(num1 - num2);
		}
		public static uint Subtract(uint num1, uint num2)
		{
			return num1 - num2;
		}
		public static ulong Subtract(ulong num1, ulong num2)
		{
			return num1 - num2;
		}
		public static ushort Subtract(ushort num1, ushort num2)
		{
			return (ushort)(num1 - num2);
		}
		#endregion
		#region Multiply
		public static byte Multiply(byte num1, byte num2)
		{
			return (byte)(num1 * num2);
		}
		public static decimal Multiply(decimal num1, decimal num2)
		{
			return num1 * num2;
		}
		public static double Multiply(double num1, double num2)
		{
			return (double)(num1 * num2);
		}
		public static float Multiply(float num1, float num2)
		{
			return (float)(num1 * num2);
		}
		public static int Multiply(int num1, int num2)
		{
			return num1 * num2;
		}
		public static long Multiply(long num1, long num2)
		{
			return num1 * num2;
		}
		public static sbyte Multiply(sbyte num1, sbyte num2)
		{
			return (sbyte)(num1 * num2);
		}
		public static short Multiply(short num1, short num2)
		{
			return (short)(num1 * num2);
		}
		public static uint Multiply(uint num1, uint num2)
		{
			return num1 * num2;
		}
		public static ulong Multiply(ulong num1, ulong num2)
		{
			return num1 * num2;
		}
		public static ushort Multiply(ushort num1, ushort num2)
		{
			return (ushort)(num1 * num2);
		}
		#endregion
		#region Divide
		public static byte Divide(byte num1, byte num2)
		{
			return (byte)(num1 / num2);
		}
		public static decimal Divide(decimal num1, decimal num2)
		{
			return num1 / num2;
		}
		public static double Divide(double num1, double num2)
		{
			return (double)(num1 / num2);
		}
		public static float Divide(float num1, float num2)
		{
			return (float)(num1 / num2);
		}
		public static int Divide(int num1, int num2)
		{
			return num1 / num2;
		}
		public static long Divide(long num1, long num2)
		{
			return num1 / num2;
		}
		public static sbyte Divide(sbyte num1, sbyte num2)
		{
			return (sbyte)(num1 / num2);
		}
		public static short Divide(short num1, short num2)
		{
			return (short)(num1 / num2);
		}
		public static uint Divide(uint num1, uint num2)
		{
			return num1 / num2;
		}
		public static ulong Divide(ulong num1, ulong num2)
		{
			return num1 / num2;
		}
		public static ushort Divide(ushort num1, ushort num2)
		{
			return (ushort)(num1 / num2);
		}
		#endregion
		#region GetPowerOf
		public static byte GetPow(byte baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		public static decimal GetPow(decimal baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		public static double GetPow(double baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		public static float GetPow(float baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		public static int GetPow(int baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		public static long GetPow(long baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		public static sbyte GetPow(sbyte baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		public static short GetPow(short baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		public static uint GetPow(uint baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		public static ulong GetPow(ulong baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		public static ushort GetPow(ushort baseNum, int powerNum)
		{
			return GetPowerOf(baseNum, powerNum);
		}
		// ------------------------------------------------------ //
		private static byte GetPowerOf(byte baseNum, int powerNum)
		{
			byte result = 1;

			for (int i = 0; i < powerNum; i++)
				result = (byte)(result * baseNum);

			return result;
		}
		private static decimal GetPowerOf(decimal baseNum, int powerNum)
		{
			decimal result = 1;

			for (int i = 0; i < powerNum; i++)
				result = result * baseNum;

			return result;
		}
		private static double GetPowerOf(double baseNum, int powerNum)
		{
			double result = 1;

			for (int i = 0; i < powerNum; i++)
				result = (double)(result * baseNum);

			return result;
		}
		private static float GetPowerOf(float baseNum, int powerNum)
		{
			float result = 1;

			for (int i = 0; i < powerNum; i++)
				result = (float)(result * baseNum);

			return result;
		}
		private static int GetPowerOf(int baseNum, int powerNum)
		{
			int result = 1;

			for (int i = 0; i < powerNum; i++)
				result = result * baseNum;

			return result;
		}
		private static long GetPowerOf(long baseNum, int powerNum)
		{
			long result = 1;

			for (int i = 0; i < powerNum; i++)
				result = result * baseNum;

			return result;
		}
		private static sbyte GetPowerOf(sbyte baseNum, int powerNum)
		{
			sbyte result = 1;

			for (int i = 0; i < powerNum; i++)
				result = (sbyte)(result * baseNum);

			return result;
		}
		private static short GetPowerOf(short baseNum, int powerNum)
		{
			short result = 1;

			for (int i = 0; i < powerNum; i++)
				result = (short)(result * baseNum);

			return result;
		}
		private static uint GetPowerOf(uint baseNum, int powerNum)
		{
			uint result = 1;

			for (int i = 0; i < powerNum; i++)
				result = result * baseNum;

			return result;
		}
		private static ulong GetPowerOf(ulong baseNum, int powerNum)
		{
			ulong result = 1;

			for (int i = 0; i < powerNum; i++)
				result = result * baseNum;

			return result;
		}
		private static ushort GetPowerOf(ushort baseNum, int powerNum)
		{
			ushort result = 1;

			for (int i = 0; i < powerNum; i++)
				result = (ushort)(result * baseNum);

			return result;
		}
		#endregion
		#region Modulo
		public static byte Modulo(byte num1, byte num2)
		{
			return (byte)(num1 % num2);
		}
		public static decimal Modulo(decimal num1, decimal num2)
		{
			return num1 % num2;
		}
		public static double Modulo(double num1, double num2)
		{
			return (double)(num1 % num2);
		}
		public static float Modulo(float num1, float num2)
		{
			return (float)(num1 % num2);
		}
		public static int Modulo(int num1, int num2)
		{
			return num1 % num2;
		}
		public static long Modulo(long num1, long num2)
		{
			return num1 % num2;
		}
		public static sbyte Modulo(sbyte num1, sbyte num2)
		{
			return (sbyte)(num1 % num2);
		}
		public static short Modulo(short num1, short num2)
		{
			return (short)(num1 % num2);
		}
		public static uint Modulo(uint num1, uint num2)
		{
			return num1 % num2;
		}
		public static ulong Modulo(ulong num1, ulong num2)
		{
			return num1 % num2;
		}
		public static ushort Modulo(ushort num1, ushort num2)
		{
			return (ushort)(num1 % num2);
		}
		#endregion
	}
}
