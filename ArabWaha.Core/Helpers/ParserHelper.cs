using System;
using System.Globalization;
using ArabWaha.Common;

namespace ArabWaha.Helpers
{
	public static class ParserHelper
	{
		private static string[] allFormats ={"yyyy/MM/dd","yyyy/M/d",
			"dd/MM/yyyy","d/M/yyyy",
			"dd/M/yyyy","d/MM/yyyy","yyyy-MM-dd",
			"yyyy-M-d","dd-MM-yyyy","d-M-yyyy",
			"dd-M-yyyy","d-MM-yyyy","yyyy MM dd",
			"yyyy M d","dd MM yyyy","d M yyyy",
			"dd M yyyy","d MM yyyy"};

		public static int ParseStringToInt(string s)
		{
			int i;
			int.TryParse(s, out i);
			return i;
		}

		public static string ParseString(string s) => string.IsNullOrEmpty(s) ? "" : s;

		public static string ParseObjectToString(object o) => o == null ? "" : o.ToString();

		public static string ParseDateToHijri(string date)
		{
			//DateTime checkDate;
			//bool isValid = DateTime.TryParse(date, out checkDate);
			if (date == "0000-00-00")
				return "";

			CultureInfo enCulture = new CultureInfo("en-US");

			DateTime tempDate = DateTime.ParseExact(date, allFormats,
				   enCulture.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);

			CultureInfo arSA = new CultureInfo("ar-SA");
			//arSA.DateTimeFormat.Calendar = new UmAlQuraCalendar();//TODO :Check UmAlQuarCalendar

			return tempDate.ToString("yyyy/MM/dd", arSA.DateTimeFormat);
		}

		public static string ParseToGregorian(string date)
		{
			CultureInfo arCI = new CultureInfo("ar-SA");
			CultureInfo enCulture = new CultureInfo("en-US");
			string hijri = date;

			DateTime tempDate = DateTime.ParseExact(hijri, allFormats,
			                                        arCI.DateTimeFormat, DateTimeStyles.AllowInnerWhite);
			var returnData = tempDate.ToString("dd/MM/yyyy",enCulture.DateTimeFormat);
			return returnData;


		}

		public static string FormatGregorianDate(string date)
		{
			CultureInfo arCI = new CultureInfo("ar-SA");
			CultureInfo enCulture = new CultureInfo("en-US");
			string hijri = date;

			DateTime tempDate = DateTime.ParseExact(hijri, allFormats,
													enCulture.DateTimeFormat, DateTimeStyles.AllowInnerWhite);
			var returnData = tempDate.ToString("dd/MM/yyyy", enCulture.DateTimeFormat);
			return returnData;


		}

		public static string MobileNumberDisplay(string mobilenumber)
		{
			return mobilenumber.Replace("+", "") + "+";
		}

		public static string MobileNumberPersist(string mobilenumber)
		{
			mobilenumber = mobilenumber.Replace("+", "");
			return "+" + mobilenumber;
		}

		public static string ParseDate(DateTime date)
		{
			return string.Format("{0:d/M/yyyy}", date);
		}

		public static string ParseDatePeriodInYear(DateTime? dateStart, DateTime? dateEnd)
		{
			if (dateStart != null && dateEnd != null)
			{
				return String.Format("{0:yyyy}", dateStart) + " - " + String.Format("{0:yyyy}", dateEnd);
			}
			else if (dateStart != null && dateEnd == null)
			{
				return String.Format("{0:yyyy}", dateStart);
			}
			else if (dateStart == null && dateEnd != null)
			{
				return String.Format("{0:yyyy}", dateEnd);
			}
			else
			{
				return string.Empty;
			}
		}

		public static string ParseDatePeriodInMonthAndYear(DateTime? dateStart, DateTime? dateEnd)
		{
			if (dateStart != null && dateEnd != null)
			{
				return String.Format("{0:M/yyyy}", dateStart) + " - " + String.Format("{0:M/yyyy}", dateEnd);
			}
			else if (dateStart != null && dateEnd == null)
			{
				return String.Format("{0:M/yyyy}", dateStart);
			}
			else if (dateStart == null && dateEnd != null)
			{
				return String.Format("{0:M/yyyy}", dateEnd);
			}
			else
			{
				return string.Empty;
			}
		}

		public static string ParseTrainingLocation(string city, string country)
		{
			return city + ", " + country;
		}

		public static string ParseIndividualAddress(Address address)
		{
			string strAddress = string.Empty;
			if (address.StreetName != null)
			{
				if (address.StreetName.Trim().Length > 0)
				{
					strAddress += address.StreetName;
				}
			}

			if (address.City != null)
			{
				if (address.City.Trim().Length > 0)
				{
					if (strAddress.Trim().Length > 0)
					{
						strAddress += ", " + address.City;
					}
					else
					{
						strAddress += address.City;
					}
				}
			}

			if (address.Region != null)
			{
				if (address.Region.Trim().Length > 0)
				{
					if (strAddress.Trim().Length > 0)
					{
						strAddress += ", " + address.Region;
					}
					else
					{
						strAddress += address.Region;
					}
				}
			}

			if (address.Country != null)
			{
				if (address.Country.Trim().Length > 0)
				{
					if (strAddress.Trim().Length > 0)
					{
						strAddress += ", " + address.Country;
					}
					else
					{
						strAddress += address.Country;
					}
				}
			}

			if (address.PostalCode != null)
			{
				if (address.PostalCode.Trim().Length > 0)
				{
					if (strAddress.Trim().Length > 0)
					{
						strAddress += " - " + address.PostalCode;
					}
					else
					{
						strAddress += address.PostalCode;
					}
				}
			}

			return strAddress;
		}

	}
}