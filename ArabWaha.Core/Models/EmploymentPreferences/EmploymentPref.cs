using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArabWaha
{
	/// <summary>
	/// Employment preference.
	/// </summary>
	public class EmploymentPref
	{
		public string employmentPreferenceId { get; set; }
		public string city { get; set; }
		public string region { get; set; }
		public string country { get; set; }
		public string Order { get; set; }
		public string nesIndividualId { get; set; }
		public string geocodeLattitude { get; set; }
		public string geocodeLongitude { get; set; }
	}

	public class EmploymentPrefList
	{
		[JsonProperty("results")]
		public IList<EmploymentPref> EmploymentPref { get; set; }
	}

	public class EmploymentPrefListRoot
	{
		[JsonProperty("d")]
		public EmploymentPrefList EmploymentPrefList { get; set; }
	}
}
