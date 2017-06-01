using System;
using Newtonsoft.Json;

namespace ArabWaha
{

	public class ApplicationFeedback
	{
		[JsonProperty("applicationId")]
		public string ApplicationId { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("saveSubmit")]
		public string ApplicantOccupation { get; set; }
	}

	public class FeedbackRoot
	{
		[JsonProperty("d")]
		public ApplicationFeedback ApplicationFeedback { get; set; }
	}
}
