#region FileHeader
// ***********************************************************************
// Assembly         : DragonPassMobile
// Author           : 443628
// Created          : 20-03-2015
// ***********************************************************************
// <copyright file="ILocalization.cs" company="CTS">
//     Copyright ©  2014
// </copyright>
// <summary></summary>
// *********************************************************************** 
using System.Globalization;


#endregion
using System;

namespace ArabWaha.Core.Localization
{
	public interface ICustomLocalization 
	{ 
		/// <summary>
		/// Gets the current culture info.
		/// </summary>
		/// <returns>The current culture info.</returns>
		CultureInfo GetCurrentCultureInfo (); 

		/// <summary>
		/// Sets the locale.
		/// </summary>
		void SetLocale (); 
	} 
}

