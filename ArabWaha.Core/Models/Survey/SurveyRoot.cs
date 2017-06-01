using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArabWaha
{
	public class Survey
	{
		public string surveyId { get; set; }
		public string individualId { get; set; }
		public string surveyName { get; set; }
		public string surveyDescription { get; set; }
		public string surveyType { get; set; }
		public DateTime startDate { get; set; }
		public DateTime endDate { get; set; }
		public string addSurveyToPSO { get; set; }
		public string isPublished { get; set; }
		public string isActive { get; set; }
	}

	public class SurveyList
	{
		[JsonProperty("results")]
		public IList<Survey> Surveys { get; set; }
	}

	public class SurveyRoot
	{
		[JsonProperty("d")]
		public SurveyList SurveyList { get; set; }
	}
}
