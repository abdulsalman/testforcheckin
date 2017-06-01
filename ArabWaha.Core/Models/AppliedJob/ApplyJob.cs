using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArabWaha
{
	public class IndividualApplicationDetails
	{
		[JsonProperty("newApplicationFlag")]
		public bool? NewApplicationFlag { get; set; }

		[JsonProperty("jobPostId")]
		public string JobPostId { get; set; }

		[JsonProperty("employerId")]
		public string EmployerId { get; set; }

		[JsonProperty("applicationStatus")]
		public string ApplicationStatus { get; set; }

		[JsonProperty("coverLetterId")]
		public int? CoverLetterId { get; set; }

		[JsonProperty("nesIndividualID")]
		public string NesIndividualID { get; set; }

		[JsonProperty("applicationID")]
		public string ApplicationID { get; set; }

		[JsonProperty("requireCVFlag")]
		public bool? RequireCVFlag { get; set; }

		[JsonProperty("requireCoverLetterFlag")]
		public bool? RequireCoverLetterFlag { get; set; }

		[JsonProperty("requireCredentialsFlag")]
		public bool? RequireCredentialsFlag { get; set; }

		[JsonProperty("requireOtherFlag")]
		public bool? RequireOtherFlag { get; set; }

		[JsonProperty("requireSurveyFlag")]
		public bool? RequireSurveyFlag { get; set; }

		[JsonProperty("requireReferencesFlag")]
		public bool? RequireReferencesFlag { get; set; }

		[JsonProperty("publishedAnonymously")]
		public bool? PublishedAnonymously { get; set; }

		[JsonProperty("showLink")]
		public bool? ShowLink { get; set; }
	}

	public class ApplyJob
	{
		public string modifiedBy { get; set; }
		public IndividualApplicationDetails IndividualApplicationDetails { get; set; }

		[JsonProperty("code")]
		public int Code { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("individualApplicationId")]
		public string IndividualApplicationId { get; set; }

		//public ApplyJob()
		//{
		//	IndividualApplicationDetails = new IndividualApplicationDetails();
		//}
	}
	public class ApplyJobList
	{
		[JsonProperty("results")]
		public List<ApplyJob> ApplyJob { get; set; }
	}

	public class ApplyJobRoot
	{
		[JsonProperty("d")]
		public ApplyJobList ApplyJobList { get; set; }
	}
}
