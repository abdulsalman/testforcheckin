#region FileHeader
// ***********************************************************************
// Assembly         : DragonPassMobile
// Author           : 443628
// Created          : 20-03-2015
// ***********************************************************************
// <copyright file="Localization.cs" company="CTS">
//     Copyright ©  2014
// </copyright>
// <summary></summary>
// *********************************************************************** 
#endregion
using System.Globalization;
using Xamarin.Forms;
using System.Resources;
using System.Reflection;



using System;

namespace ArabWaha.Core.Localization
{
    public class LocalizationHelper 
	{
		/// <summary>
		/// The culture info object.
		/// </summary>
		static readonly CultureInfo cultureInfo;
        static ResourceManager resourceManager;
        /// <summary>
        /// static constructor to call dependency service
        /// </summary>
        static LocalizationHelper()
        {
            resourceManager = new ResourceManager("ArabWaha.Core.Dictiionary.AppResources", typeof(LocalizationHelper).GetTypeInfo().Assembly);
            cultureInfo = DependencyService.Get<ICustomLocalization>().GetCurrentCultureInfo();
        }

		/// <summary>
		/// Get appropriate resource values from resource files
		/// </summary>
		public static string GetString(string key)
		{
            if(resourceManager ==null)
                resourceManager = new ResourceManager("ArabWaha.Core.Dictiionary.AppResources", typeof(LocalizationHelper).GetTypeInfo().Assembly);

            return resourceManager.GetString(key, cultureInfo);
		}
		private static string AndroidToDotnetLanguage(string androidLanguage)
		{
			var netLanguage = androidLanguage;
			if (netLanguage.Substring(0, 2) == "ar")
				return "ar";
			else
				return "en";
		}

		public static string GetDictionoryValue(string GroupCode, string value)
		{
			string dictionoryValue = string.Empty;
			var groupCodeValue = string.Concat(GroupCode, "_", value);
			if (!string.IsNullOrEmpty(value))
				dictionoryValue = LocalizationHelper.GetString(Convert.ToString(groupCodeValue));

			return dictionoryValue;
		}
    }
}

