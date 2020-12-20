using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace System.NET.CSharp.Configuration
{
	public class Ini : Profile
	{
		public Ini() {}
		public Ini(string fileName) : base(fileName) {}
		public Ini(Ini ini) : base(ini) {}

		public override string DefaultName => DefaultNameWithoutExtension + ".ini";
		public override object Clone() => new Ini(this);

		[DllImport("kernel32", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		private static extern int WritePrivateProfileString(string section, string key, string value, string fileName);

		[DllImport("kernel32", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		private static extern int WritePrivateProfileString(string section, string key, int value, string fileName);

		[DllImport("kernel32", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		private static extern int WritePrivateProfileString(string section, int key, string value, string fileName);

		[DllImport("kernel32", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder result, int size, string fileName);

		[DllImport("kernel32", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		private static extern int GetPrivateProfileString(string section, int key, string defaultValue, [MarshalAs(UnmanagedType.LPArray)] byte[] result, int size, string fileName);

		[DllImport("kernel32", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		private static extern int GetPrivateProfileString(string section, string key, string defaultValue, [MarshalAs(UnmanagedType.LPArray)] byte[] result, int size, string fileName);

		[DllImport("kernel32", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		private static extern int GetPrivateProfileString(int section, string key, string defaultValue, [MarshalAs(UnmanagedType.LPArray)] byte[] result, int size, string fileName);

		public override void SetValue(string section, string entry, object value)
		{
			if (section == null || entry == null)
				return;
			if (value == null)
			{
				RemoveEntry(section, entry);
			}
			else
			{
				VerifyNotReadOnly();
				VerifyName();
				VerifyAndAdjustSection(ref section);
				VerifyAndAdjustEntry(ref entry);
				if (!RaiseChangeEvent(true, ProfileChangeType.SetValue, section, entry, value))
					return;
				if (WritePrivateProfileString(section, entry, value.ToString(), Name) == 0)
					throw new Win32Exception();
				RaiseChangeEvent(false, ProfileChangeType.SetValue, section, entry, value);
			}
		}
		public override object GetValue(string section, string entry)
		{
			if (section == null || entry == null)
				return null;
			VerifyName();
			VerifyAndAdjustSection(ref section);
			VerifyAndAdjustEntry(ref entry);
			int num1 = 250;
			StringBuilder result;
			int num2;
			while (true)
			{
				result = new StringBuilder(num1);
				num2 = 2 * GetPrivateProfileString(section, entry, "", result, num1, Name);
				if (num2 >= num1 - 2)
					num1 *= 2;
				else break;
			}
			return num2 == 0 && !HasEntry(section, entry) ? null : result.ToString();
		}

		public override void RemoveEntry(string section, string entry)
		{
			if (!HasEntry(section, entry))
				return;
			VerifyNotReadOnly();
			VerifyName();
			VerifyAndAdjustSection(ref section);
			VerifyAndAdjustEntry(ref entry);
			if (!RaiseChangeEvent(true, ProfileChangeType.RemoveEntry, section, entry, null))
				return;
			if (WritePrivateProfileString(section, entry, 0, Name) == 0)
				throw new Win32Exception();
			RaiseChangeEvent(false, ProfileChangeType.RemoveEntry, section, entry, null);
		}
		public override void RemoveSection(string section)
		{
			if (!HasSection(section))
				return;
			VerifyNotReadOnly();
			VerifyName();
			VerifyAndAdjustSection(ref section);
			if (!RaiseChangeEvent(true, ProfileChangeType.RemoveSection, section, null, null))
				return;
			if (WritePrivateProfileString(section, 0, "", Name) == 0)
				throw new Win32Exception();
			RaiseChangeEvent(false, ProfileChangeType.RemoveSection, section, null, null);
		}

		public override string[] GetEntryNames(string section)
		{
			if (!HasSection(section))
				return null;
			VerifyAndAdjustSection(ref section);
			int size = 500;
			byte[] numArray;
			int num;
			while (true)
			{
				numArray = new byte[size];
				num = 2 * GetPrivateProfileString(section, 0, "", numArray, size, Name);
				if (num >= size - 3)
					size *= 2;
				else break;
			}
			string str = Encoding.Unicode.GetString(numArray, 0, num - (num > 0 ? 2 : 0));
			return str == "" ? new string[0] : str.Split(new char[1]);
		}
		public override string[] GetSectionNames()
		{
			if (!File.Exists(Name))
				return null;
			int size = 500;
			byte[] numArray;
			int num;
			while (true)
			{
				numArray = new byte[size];
				num = 2 * GetPrivateProfileString(0, "", "", numArray, size, Name);
				if (num >= size - 3)
					size *= 2;
				else break;
			}
			string str = Encoding.Unicode.GetString(numArray, 0, num - (num > 0 ? 2 : 0));
			return str == "" ? new string[0] : str.Split(new char[1]);
		}
	}
}
