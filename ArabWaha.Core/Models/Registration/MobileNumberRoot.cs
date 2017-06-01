using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArabWaha.Models
{
	public class IndividualMobile
	{
		[JsonProperty("mobileNumber")]
		public string MobileNumber { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }

		
		public string verify { get; set; }
		public string otp { get; set; }
		public string nesIndividualId { get; set; }
	}

	public class IndividualMobileList
	{
		public IList<IndividualMobile> results { get; set; }
	}

	public class IndividualMobileRoot
	{
		[JsonProperty("d")]
		public IndividualMobileList IndividualMobileList { get; set; }
	}

	public class PSOAuthentication
	{
		[JsonProperty("nesIndividualId")]
		public string NesIndividualId { get; set; }

		[JsonProperty("loginAttempts")]
		public string LoginAttempts { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("message")]
		public object Message { get; set; }
	}

	public class PSOAuthenticationList
	{
		[JsonProperty("results")]
		public PSOAuthentication PSOAuthentication { get; set; }
	}

	public class PSORoot
	{
		[JsonProperty("d")]
		public PSOAuthenticationList PSOAuthenticationList { get; set; }
	}

	public class VerifyUser
	{
		//public string UserID { get; set; }
		//public string SapBpID { get; set; }
		public string language { get; set; }
		public string code { get; set; }
		public string message { get; set; }
		public bool? mobileVerificationStatus { get; set; }
		public object mobileUsabilityStatus { get; set; }
	}

	public class VerifyUserRootList
	{
		[JsonProperty("results")]
		public IList<VerifyUser> VerifyUserList { get; set; }
	}

	public class VerifyUserRoot
	{
		[JsonProperty("d")]
		public VerifyUserRootList VerifyUserRootList { get; set; }
	}

	public class CheckMobileUsability
	{
		[JsonProperty("mobileNumber")]
		public string MobileNumber { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }
	}

	public class CheckMobileUsabilityRoot
	{
		[JsonProperty("d")]
		public CheckMobileUsability CheckMobileUsability { get; set; }
	}
}
