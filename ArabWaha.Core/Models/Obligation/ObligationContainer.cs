using System;
using System.Collections.Generic;
using ArabWaha.Models;
using Newtonsoft.Json;

namespace ArabWaha
{
	//Entities for Obligation Announcements
	public class ObligationAnnouncement
	{
		[JsonProperty("informationSharingId")]
		public string InformationSharingId { get; set; }

		[JsonProperty("announcemenTitle")]
		public string AnnouncementTitle { get; set; }

		[JsonProperty("individualId")]
		public string IndividualId { get; set; }

		[JsonProperty("messageBody")]
		public object MessageBody { get; set; }
	}

	public class ObligationAnnouncementList
	{
		[JsonProperty("results")]
		public IList<ObligationAnnouncement> ObligationAnnouncements { get; set; }
	}

	public class ObligationAnnouncementRoot
	{
		[JsonProperty("d")]
		public ObligationAnnouncementList ObligationAnnouncementList { get; set; }
	}


	//Entities for Terms and Conditions
	public class TermsAndConditions
	{
		public IList<TermsResult> results { get; set; }
		//[JsonProperty("individualId")]
		//public string IndividualId { get; set; }

		//[JsonProperty("audienceType")]
		//public string AudienceType { get; set; }

		//[JsonProperty("termsAndConditionsText")]
		//public string TermsAndConditionsText { get; set; }
	}

	public class TermsAndConditionsRoot
	{
		[JsonProperty("d")]
		public TermsAndConditions TermsAndConditions { get; set; }
	}

	//Entities for Program Terms and Conditions

	public class TermsResult
	{
		[JsonProperty("termsAndConditionsId")]
		public string TermsAndConditionsId { get; set; }

		[JsonProperty("termsAndConditionsText")]
		public string TermsAndConditionsText { get; set; }

		[JsonProperty("documentName")]
		public string DocumentName { get; set; }

		[JsonProperty("processId")]
		public string ProcessId { get; set; }

		[JsonProperty("tncArabicText")]
		public string TncArabicText { get; set; }

		[JsonProperty("individualId")]
		public string IndividualId { get; set; }

		[JsonProperty("audienceType")]
		public string AudienceType { get; set; }

		[JsonProperty("programId")]
		public string ProgramId { get; set; }
	}

	public class ProgramTerms
	{
		public IList<TermsResult> results { get; set; }
	}

	public class ProgramTermsRoot
	{
		[JsonProperty("d")]
		public ProgramTerms ProgramTerms { get; set; }
	}


	public class ObligationContainer
	{
		public ObligationAnnouncementRoot ObligationAnnouncementRoot { get; set; }
		public ObligationsListRoot ObligationsListRoot { get; set; }
		public TermsAndConditionsRoot TermsAndConditionsRoot { get; set; }
		public ProgramTermsRoot ProgramTermsRoot { get; set; }
		public SurveyRoot SurveyRoot { get; set; }
	}
}
