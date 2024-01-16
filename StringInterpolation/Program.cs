using Microsoft.VisualBasic;
using System;

namespace StringInterpolation
{
	public class Program
	{
		public static string FormatDate(int year, int month, int day)
		{
			return $"{year}/{month}/{day}";
		}
	}
}
