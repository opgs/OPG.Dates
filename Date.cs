using System;

namespace OPG.Dates
{
	public sealed class OPGDate
	{
		private static DateTime now = DateTime.UtcNow;

		public static string GetHTTPHeader()
		{
			now = DateTime.UtcNow;
			return "Date: " + now.DayOfWeek.ToString().Substring(0,3) + ", " + now.Day + " " + now.Month + " "  + now.Year + " " + now.Hour + ":" + now.Minute + ":" + now.Second + " GMT\r\n";
		}

		public OPGDate()
		{

		}

		public OPGDate(int dateIn)
		{
			now = new DateTime(dateIn);
		}
	}
}
