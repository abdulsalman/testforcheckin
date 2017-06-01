using System;
using ArabWaha.Models;

namespace ArabWaha
{
	public static class ApplicationExceptionHelper
	{
		/// <summary>
		/// Handles the exception.
		/// </summary>
		/// <param name="ex">Ex.</param>
		public static void HandleException(Exception ex)
		{
			if (ex.Message.ToLower().Contains("an error occurred while sending the request"))
			{
				DebugDataSingleton.Instance.IsTrustFailure = true;
                //TODO -Show the Message in Dialog
				//DialogsHelper.Alert(CrossCurrentActivity.Current.Activity, "الاتصال بالإنترنت غير متاح. تأكد من الاتصال ثم حاول مرة أخرى");
			}
            else
            {
                //TODO: log exception
				//DialogsHelper.Alert(CrossCurrentActivity.Current.Activity, "الاتصال بالإنترنت غير متاح. تأكد من الاتصال ثم حاول مرة أخرى");
            }
		}
	}
}
