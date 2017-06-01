using System;
using System.Collections.Generic;

namespace ArabWaha.Models
{
	public class SurveryResponseSet
	{
		public string surveyId { get; set; }
		public string questionId { get; set; }
		public string answerType { get; set; }
		public string answerOptionId { get; set; }
		public string rank { get; set; }
		public string percentage { get; set; }
		public string otherText { get; set; }
		public string importanceCode { get; set; }
	}

	public class SurveyResponse
	{
		public string nesIndividualId { get; set; }
		public string surveyId { get; set; }
		public string PsoObligationId { get; set; }
		public string tncIdToAccept { get; set; }
		public string step1Num { get; set; }
		public string step1Confirmation { get; set; }
		public string step2Num { get; set; }
		public string step2Confirmation { get; set; }
		public IList<SurveryResponseSet> SurveryResponseSet { get; set; }
	}

	public class AnswerDetails
	{
		public string QuestionID { get; set; }
		public string AnswerID { get; set; }
		public bool Clicked { get; set; }
		public string ImportanceCode { get; set; }
	}
}
