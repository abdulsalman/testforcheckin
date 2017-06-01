﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArabWaha.Models
{
	public class DebugDataSingleton
	{
		private static DebugDataSingleton instance;
		public static DebugDataSingleton Instance => instance ?? (instance = new DebugDataSingleton());

		/// <summary>
		/// Gets or sets the application connection identifier.
		/// </summary>
		/// <value>The application connection identifier.</value>
		public string ApplicationConnectionId { get; set; }
		/// <summary>
		/// Gets or sets the name of the user.
		/// </summary>
		/// <value>The name of the user.</value>
		public string UserName { get; set; }
		/// <summary>
		/// Gets or sets the basic auth.
		/// </summary>
		/// <value>The basic auth.</value>
		public string BasicAuth { get; set; }
		/// <summary>
		/// Gets or sets the nes individual identifier.
		/// </summary>
		/// <value>The nes individual identifier.</value>
		public string NesIndividualID { get; set; }
		/// <summary>
		/// Gets or sets the x smp appcid.
		/// </summary>
		/// <value>The x smp appcid.</value>
		public string X_SMP_APPCID { get; set; }
		/// <summary>
		/// Gets or sets the cookie.
		/// </summary>
		/// <value>The cookie.</value>
		public string COOKIE { get; set; }
		/// <summary>
		/// Gets or sets the x csrf token.
		/// </summary>
		/// <value>The x csrf token.</value>
		public string X_CSRF_TOKEN { get; set; }
		/// <summary>
		/// Gets or sets the sap bp individual identifier.
		/// </summary>
		/// <value>The sap bp individual identifier.</value>
		public string SapBpIndividualID { get; set; }
		/// <summary>
		/// Gets or sets the sap bp individual identifier.
		/// </summary>
		/// <value>The sap bp individual identifier.</value>
		public string Language { get; set; }
		/// <summary>
		/// Gets or sets the employment preference location.
		/// </summary>
		/// <value>The employment preference location.</value>
		public string Employment_Pref_Location { get; set; }
		/// <summary>
		/// Gets or sets logged in users mobile no.
		/// </summary>
		/// <value>Logged in users mobile no.</value>
		public string UserMobileNumber { get; set; }
		/// <summary>
		/// Gets or sets logged in users login mode.
		/// </summary>
		/// <value>Logged in users mode</value>
		public EnumGlobal.LoginMode LoginMode { get; set; }
		/// <summary>
		/// Gets or sets the latitude.
		/// </summary>
		/// <value>The latitude.</value>
		public string Latitude { get; set; }
		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		/// <value>The longitude.</value>
		public string Longitude { get; set; }

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		/// <value>The longitude.</value>
		public bool IsHafiz { get; set; }

		/// <summary>
		/// Gets or sets the registration status.
		/// </summary>
		/// <value>The Registration Status.</value>
		public string RegistrationStatus { get; set; }

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		/// <value>The longitude.</value>
		public bool IsPSORequired { get; set; }

		/// <summary>
		/// Gets or sets Survey Iterator.
		/// </summary>
		/// <value>The PSO Survey Iterator.</value>
		public SurveyIterator PSOSurveyIterator { get; set; }

		/// <summary>
		/// Gets or sets logged in users login mode.
		/// </summary>
		/// <value>Logged in users mobile no.</value>
		public bool IsFirstSurvey { get; set; } = false;

		/// <summary>
		/// Gets or sets the PSO Obligation ID.
		/// </summary>
		/// <value>PSO Obligation ID.</value>
		public string PSOObligationID { get; set; }

		public bool IsTrustFailure { get; set; } = false;

		public bool ComplaintsSectionCollapsed { get; set; } = false;
	}
}
