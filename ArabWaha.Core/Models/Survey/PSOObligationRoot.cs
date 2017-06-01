using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArabWaha
{
	public class PSOObligation
	{
		public string nesIndividualId { get; set; }
		public string obligationId { get; set; }
	}

	public class PSOObligationList
	{
		public IList<PSOObligation> results { get; set; }
	}

	public class PSOObligationRoot
	{
		[JsonProperty("d")]
		public PSOObligationList PSOObligationList { get; set; }
	}
}
