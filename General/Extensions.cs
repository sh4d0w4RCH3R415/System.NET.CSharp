using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace System.NET.CSharp.General
{
	public static class Extensions
	{
		[DllImport("user32")]
		private static extern int SendMessage(IntPtr handle, int message, int wparam, int lparam);
		
		#region Number Conversion
		#region ToByte
		public static byte ToByte(this int number)
		{
			return (byte)number;
		}
		public static byte ToByte(this decimal number)
		{
			return (byte)number;
		}
		public static byte ToByte(this double number)
		{
			return (byte)number;
		}
		public static byte ToByte(this float number)
		{
			return (byte)number;
		}
		public static byte ToByte(this long number)
		{
			return (byte)number;
		}
		public static byte ToByte(this sbyte number)
		{
			return (byte)number;
		}
		public static byte ToByte(this short number)
		{
			return (byte)number;
		}
		public static byte ToByte(this uint number)
		{
			return (byte)number;
		}
		public static byte ToByte(this ulong number)
		{
			return (byte)number;
		}
		public static byte ToByte(this ushort number)
		{
			return (byte)number;
		}
		public static byte ToByte(this IntPtr number)
		{
			return (byte)number;
		}
		#endregion
		#region ToDecimal
		public static decimal ToDecimal(this byte number)
		{
			return number;
		}
		public static decimal ToDecimal(this int number)
		{
			return number;
		}
		public static decimal ToDecimal(this double number)
		{
			return (decimal)number;
		}
		public static decimal ToDecimal(this float number)
		{
			return (decimal)number;
		}
		public static decimal ToDecimal(this long number)
		{
			return number;
		}
		public static decimal ToDecimal(this sbyte number)
		{
			return number;
		}
		public static decimal ToDecimal(this short number)
		{
			return number;
		}
		public static decimal ToDecimal(this uint number)
		{
			return number;
		}
		public static decimal ToDecimal(this ulong number)
		{
			return number;
		}
		public static decimal ToDecimal(this ushort number)
		{
			return number;
		}
		public static decimal ToDecimal(this IntPtr number)
		{
			return (decimal)number;
		}
		#endregion
		#region ToDouble
		public static double ToDouble(this byte number)
		{
			return number;
		}
		public static double ToDouble(this decimal number)
		{
			return (double)number;
		}
		public static double ToDouble(this int number)
		{
			return number;
		}
		public static double ToDouble(this float number)
		{
			return number;
		}
		public static double ToDouble(this long number)
		{
			return number;
		}
		public static double ToDouble(this sbyte number)
		{
			return number;
		}
		public static double ToDouble(this short number)
		{
			return number;
		}
		public static double ToDouble(this uint number)
		{
			return number;
		}
		public static double ToDouble(this ulong number)
		{
			return number;
		}
		public static double ToDouble(this ushort number)
		{
			return number;
		}
		public static double ToDouble(this IntPtr number)
		{
			return (double)number;
		}
		#endregion
		#region ToFloat
		public static float ToFloat(this byte number)
		{
			return number;
		}
		public static float ToFloat(this decimal number)
		{
			return (float)number;
		}
		public static float ToFloat(this double number)
		{
			return (float)number;
		}
		public static float ToFloat(this int number)
		{
			return number;
		}
		public static float ToFloat(this long number)
		{
			return number;
		}
		public static float ToFloat(this sbyte number)
		{
			return number;
		}
		public static float ToFloat(this short number)
		{
			return number;
		}
		public static float ToFloat(this uint number)
		{
			return number;
		}
		public static float ToFloat(this ulong number)
		{
			return number;
		}
		public static float ToFloat(this ushort number)
		{
			return number;
		}
		public static float ToFloat(this IntPtr number)
		{
			return (float)number;
		}
		#endregion
		#region ToInt
		public static int ToInt(this byte number)
		{
			return number;
		}
		public static int ToInt(this decimal number)
		{
			return (int)number;
		}
		public static int ToInt(this double number)
		{
			return (int)number;
		}
		public static int ToInt(this float number)
		{
			return (int)number;
		}
		public static int ToInt(this long number)
		{
			return (int)number;
		}
		public static int ToInt(this sbyte number)
		{
			return number;
		}
		public static int ToInt(this short number)
		{
			return number;
		}
		public static int ToInt(this uint number)
		{
			return (int)number;
		}
		public static int ToInt(this ulong number)
		{
			return (int)number;
		}
		public static int ToInt(this ushort number)
		{
			return number;
		}
		public static int ToInt(this IntPtr number)
		{
			return (int)number;
		}
		#endregion
		#region ToLong
		public static long ToLong(this byte number)
		{
			return number;
		}
		public static long ToLong(this decimal number)
		{
			return (long)number;
		}
		public static long ToLong(this double number)
		{
			return (long)number;
		}
		public static long ToLong(this float number)
		{
			return (long)number;
		}
		public static long ToLong(this int number)
		{
			return number;
		}
		public static long ToLong(this sbyte number)
		{
			return number;
		}
		public static long ToLong(this short number)
		{
			return number;
		}
		public static long ToLong(this uint number)
		{
			return number;
		}
		public static long ToLong(this ulong number)
		{
			return (long)number;
		}
		public static long ToLong(this ushort number)
		{
			return number;
		}
		public static long ToLong(this IntPtr number)
		{
			return (long)number;
		}
		#endregion
		#region ToSByte
		public static sbyte ToSByte(this byte number)
		{
			return (sbyte)number;
		}
		public static sbyte ToSByte(this decimal number)
		{
			return (sbyte)number;
		}
		public static sbyte ToSByte(this double number)
		{
			return (sbyte)number;
		}
		public static sbyte ToSByte(this float number)
		{
			return (sbyte)number;
		}
		public static sbyte ToSByte(this long number)
		{
			return (sbyte)number;
		}
		public static sbyte ToSByte(this int number)
		{
			return (sbyte)number;
		}
		public static sbyte ToSByte(this short number)
		{
			return (sbyte)number;
		}
		public static sbyte ToSByte(this uint number)
		{
			return (sbyte)number;
		}
		public static sbyte ToSByte(this ulong number)
		{
			return (sbyte)number;
		}
		public static sbyte ToSByte(this ushort number)
		{
			return (sbyte)number;
		}
		public static sbyte ToSByte(this IntPtr number)
		{
			return (sbyte)number;
		}
		#endregion
		#region ToShort
		public static short ToShort(this byte number)
		{
			return number;
		}
		public static short ToShort(this decimal number)
		{
			return (short)number;
		}
		public static short ToShort(this double number)
		{
			return (short)number;
		}
		public static short ToShort(this float number)
		{
			return (short)number;
		}
		public static short ToShort(this long number)
		{
			return (short)number;
		}
		public static short ToShort(this sbyte number)
		{
			return number;
		}
		public static short ToShort(this int number)
		{
			return (short)number;
		}
		public static short ToShort(this uint number)
		{
			return (short)number;
		}
		public static short ToShort(this ulong number)
		{
			return (short)number;
		}
		public static short ToShort(this ushort number)
		{
			return (short)number;
		}
		public static short ToShort(this IntPtr number)
		{
			return (short)number;
		}
		#endregion
		#region ToUInt
		public static uint ToUInt(this byte number)
		{
			return number;
		}
		public static uint ToUInt(this decimal number)
		{
			return (uint)number;
		}
		public static uint ToUInt(this double number)
		{
			return (uint)number;
		}
		public static uint ToUInt(this float number)
		{
			return (uint)number;
		}
		public static uint ToUInt(this long number)
		{
			return (uint)number;
		}
		public static uint ToUInt(this sbyte number)
		{
			return (uint)number;
		}
		public static uint ToUInt(this short number)
		{
			return (uint)number;
		}
		public static uint ToUInt(this int number)
		{
			return (uint)number;
		}
		public static uint ToUInt(this ulong number)
		{
			return (uint)number;
		}
		public static uint ToUInt(this ushort number)
		{
			return number;
		}
		public static uint ToUInt(this IntPtr number)
		{
			return (uint)number;
		}
		#endregion
		#region ToULong
		public static ulong ToULong(this byte number)
		{
			return number;
		}
		public static ulong ToULong(this decimal number)
		{
			return (ulong)number;
		}
		public static ulong ToULong(this double number)
		{
			return (ulong)number;
		}
		public static ulong ToULong(this float number)
		{
			return (ulong)number;
		}
		public static ulong ToULong(this long number)
		{
			return (ulong)number;
		}
		public static ulong ToULong(this sbyte number)
		{
			return (ulong)number;
		}
		public static ulong ToULong(this short number)
		{
			return (ulong)number;
		}
		public static ulong ToULong(this uint number)
		{
			return number;
		}
		public static ulong ToULong(this int number)
		{
			return (ulong)number;
		}
		public static ulong ToULong(this ushort number)
		{
			return number;
		}
		public static ulong ToULong(this IntPtr number)
		{
			return (ulong)number;
		}
		#endregion
		#region ToUShort
		public static ushort ToUShort(this byte number)
		{
			return number;
		}
		public static ushort ToUShort(this decimal number)
		{
			return (ushort)number;
		}
		public static ushort ToUShort(this double number)
		{
			return (ushort)number;
		}
		public static ushort ToUShort(this float number)
		{
			return (ushort)number;
		}
		public static ushort ToUShort(this long number)
		{
			return (ushort)number;
		}
		public static ushort ToUShort(this sbyte number)
		{
			return (ushort)number;
		}
		public static ushort ToUShort(this short number)
		{
			return (ushort)number;
		}
		public static ushort ToUShort(this uint number)
		{
			return (ushort)number;
		}
		public static ushort ToUShort(this ulong number)
		{
			return (ushort)number;
		}
		public static ushort ToUShort(this int number)
		{
			return (ushort)number;
		}
		public static ushort ToUShort(this IntPtr number)
		{
			return (ushort)number;
		}
		#endregion
		#region ToIntPtr
		public static IntPtr ToIntPtr(this byte number)
		{
			return (IntPtr)number;
		}
		public static IntPtr ToIntPtr(this decimal number)
		{
			return (IntPtr)number;
		}
		public static IntPtr ToIntPtr(this double number)
		{
			return (IntPtr)number;
		}
		public static IntPtr ToIntPtr(this float number)
		{
			return (IntPtr)number;
		}
		public static IntPtr ToIntPtr(this long number)
		{
			return (IntPtr)number;
		}
		public static IntPtr ToIntPtr(this sbyte number)
		{
			return (IntPtr)number;
		}
		public static IntPtr ToIntPtr(this short number)
		{
			return (IntPtr)number;
		}
		public static IntPtr ToIntPtr(this uint number)
		{
			return (IntPtr)number;
		}
		public static IntPtr ToIntPtr(this ulong number)
		{
			return (IntPtr)number;
		}
		public static IntPtr ToIntPtr(this ushort number)
		{
			return (IntPtr)number;
		}
		public static IntPtr ToIntPtr(this int number)
		{
			return (IntPtr)number;
		}
		#endregion
		#endregion
		#region String Management
		public static bool ClearStr(this string str)
		{
			str = string.Empty;
			return true;
		}
		public static bool IsNull(this string str)
		{
			return str == null;
		}
		public static bool IsEmpty(this string str)
		{
			return str == "" || str == string.Empty;
		}
		public static string FormatStr(this string str, params object[] values)
		{
			return string.Format(str, values);
		}
		public static bool CheckString(this string str, string requiredValue)
		{
			return str == requiredValue;
		}
		#endregion
		#region Windows Messages
		public static int Send(this Message winMsg)
		{
			SendMessage(winMsg.HWnd, winMsg.Msg, winMsg.WParam.ToInt(), winMsg.LParam.ToInt());
			return 0;
		}
		public static int GetHandle(this Message winMsg)
		{
			return winMsg.HWnd.ToInt();
		}
		public static int GetMessage(this Message winMsg)
		{
			return winMsg.Msg;
		}
		public static int GetWParam(this Message winMsg)
		{
			return winMsg.WParam.ToInt();
		}
		public static int GetLParam(this Message winMsg)
		{
			return winMsg.LParam.ToInt();
		}
		public static int GetWinMsgResult(this Message winMsg)
		{
			return winMsg.Result.ToInt();
		}
		#endregion
		#region Array & List Management
		public static bool HasElements<T>(this T[] array)
		{
			return array.Length > 0;
		}
		public static bool HasElements<T>(this List<T> list)
		{
			return list.Count > 0;
		}

		public static void SortAlphabetically<T>(this T[] array)
		{
			Array.Sort(array, (x, y) => string.Compare(x.ToString(), y.ToString()));
		}
		public static void SortAlphabetically<T>(this List<T> list)
		{
			T[] array = list.ToArray();
			Array.Sort(array, (x, y) => string.Compare(x.ToString(), y.ToString()));
		}
		#endregion
		#region Byte Conversion
		public static string ToReadableBytes(long bytes)
		{
			List<string> supportedTypes = new List<string> { " B", " KB", " GB", " TB", " PB" };

			for (int i = 0; i < supportedTypes.Count; i++)
			{
				long temp = bytes / Math.Pow(1024, i + 1).ToInt();

				if (temp == 0)
				{
					return (bytes / Math.Pow(1024, i).ToInt()) + supportedTypes[i];
				}
			}

			return bytes.ToString();
		}
		#endregion
		#region General Stuff
		public static bool Exists(this object obj)
		{
			return obj != null;
		}
		#endregion
	}
}
