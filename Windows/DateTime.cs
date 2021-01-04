using System.NET.CSharp.General;

namespace System.NET.CSharp.Windows
{
	public class DateTime
	{
		public static string GetDayAsString()
		{
			return System.DateTime.Now.DayOfWeek.ToString();
		}
		public static int GetDayAsNumber()
		{
			return System.DateTime.Now.Day;
		}
		public static int GetMonthAsNumber()
		{
			return System.DateTime.Now.Month;
		}
		public static string GetMonthAsString()
		{
			switch (GetMonthAsNumber())
			{
				case 1:
					return "January";
				case 2:
					return "February";
				case 3:
					return "March";
				case 4:
					return "April";
				case 5:
					return "May";
				case 6:
					return "June";
				case 7:
					return "July";
				case 8:
					return "August";
				case 9:
					return "September";
				case 10:
					return "October";
				case 11:
					return "November";
				case 12:
					return "December";
			}

			return string.Empty;
		}
		public static int GetYear()
		{
			return System.DateTime.Now.Year;
		}

		public static string GetNormalDate()
		{
			switch (GetMonthAsNumber())
			{
				case 1:
					return string.Format("{0} {1}, {2}", "January", GetDayAsNumber(), GetYear());
				case 2:
					return string.Format("{0} {1}, {2}", "February", GetDayAsNumber(), GetYear());
				case 3:
					return string.Format("{0} {1}, {2}", "March", GetDayAsNumber(), GetYear());
				case 4:
					return string.Format("{0} {1}, {2}", "April", GetDayAsNumber(), GetYear());
				case 5:
					return string.Format("{0} {1}, {2}", "May", GetDayAsNumber(), GetYear());
				case 6:
					return string.Format("{0} {1}, {2}", "June", GetDayAsNumber(), GetYear());
				case 7:
					return string.Format("{0} {1}, {2}", "July", GetDayAsNumber(), GetYear());
				case 8:
					return string.Format("{0} {1}, {2}", "August", GetDayAsNumber(), GetYear());
				case 9:
					return string.Format("{0} {1}, {2}", "September", GetDayAsNumber(), GetYear());
				case 10:
					return string.Format("{0} {1}, {2}", "October", GetDayAsNumber(), GetYear());
				case 11:
					return string.Format("{0} {1}, {2}", "November", GetDayAsNumber(), GetYear());
				case 12:
					return string.Format("{0} {1}, {2}", "December", GetDayAsNumber(), GetYear());
			}
			return string.Empty;
		}
		public static string GetEuropeanDate()
		{
			switch (GetMonthAsNumber())
			{
				case 1:
					return string.Format("{1} {0} {2}", "January", GetDayAsNumber(), GetYear());
				case 2:
					return string.Format("{1} {0} {2}", "February", GetDayAsNumber(), GetYear());
				case 3:
					return string.Format("{1} {0} {2}", "March", GetDayAsNumber(), GetYear());
				case 4:
					return string.Format("{1} {0} {2}", "April", GetDayAsNumber(), GetYear());
				case 5:
					return string.Format("{1} {0} {2}", "May", GetDayAsNumber(), GetYear());
				case 6:
					return string.Format("{1} {0} {2}", "June", GetDayAsNumber(), GetYear());
				case 7:
					return string.Format("{1} {0} {2}", "July", GetDayAsNumber(), GetYear());
				case 8:
					return string.Format("{1} {0} {2}", "August", GetDayAsNumber(), GetYear());
				case 9:
					return string.Format("{1} {0} {2}", "September", GetDayAsNumber(), GetYear());
				case 10:
					return string.Format("{1} {0} {2}", "October", GetDayAsNumber(), GetYear());
				case 11:
					return string.Format("{1} {0} {2}", "November", GetDayAsNumber(), GetYear());
				case 12:
					return string.Format("{1} {0} {2}", "December", GetDayAsNumber(), GetYear());
			}
			return string.Empty;
		}
		public static string GetDayState(bool abbreviate)
		{
			if (abbreviate)
			{
				if (GetHour() < 12)
				{
					return "A.M.";
				}
				else if (GetHour() >= 12)
				{
					return "P.M.";
				}
			}
			else if (!abbreviate)
			{
				if (GetHour() < 12)
				{
					return "AM";
				}
				else if (GetHour() >= 12)
				{
					return "PM";
				}
			}

			return string.Empty;
		}

		public static int GetHour()
		{
			return System.DateTime.Now.Hour;
		}
		public static int GetMinute()
		{
			return System.DateTime.Now.Minute;
		}
		public static int GetSecond()
		{
			return System.DateTime.Now.Second;
		}
		public static int GetMillisecond()
		{
			return System.DateTime.Now.Millisecond;
		}
		public static int GetMicrosecond()
		{
			return (GetMillisecond() / 1000).ToString().Split('.')[1].Substring(0, 4).ToInt();
		}
		public static int GetNanosecond()
		{
			return (GetMicrosecond() / 1000).ToString().Split('.')[1].Substring(0, 4).ToInt();
		}
	}
}
