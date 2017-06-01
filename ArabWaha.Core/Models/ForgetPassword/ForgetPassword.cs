using System;
using Newtonsoft.Json;

namespace ArabWaha
{
	public class ForgetPassword
	{
		public string userName { get; set; }
		public string code { get; set; }
		public string message { get; set; }
	}

	public class ForgetPasswordRoot
	{
		[JsonProperty("d")]
		public ForgetPassword ForgetPassword { get; set; }
	}
}
