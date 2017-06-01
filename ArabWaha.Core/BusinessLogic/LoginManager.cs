using System;
using System.Text;
using System.Threading.Tasks;
using ArabWaha.Common;
using ArabWaha.Models;
using ArabWaha.Web;

namespace ArabWaha.Core.BusinessLogic
{
    public class LoginManager
    {
        public static async Task Login(String email, String password, bool isGuest, EnumGlobal.LoginMode loginMode)
        {
			//try
			//{
			//	DebugDataSingleton.Instance.BasicAuth = "Basic OTAwNjI3OTpzYXBAMTIzNA==";
			//	DebugDataSingleton.Instance.IsHafiz = false;
			//	var bytes = Encoding.UTF8.GetBytes(string.Format("{0}:{1}", email, password));
			//	var base64String = Convert.ToBase64String(bytes);
			//	string authHeader = String.Format("Basic {0}", base64String);

			//	var result = await AWWebClient.Instance.RegisterUser(authHeader, Constants.Device);
			//	//var result = await AWWebClient.Instance.RegisterUser("Basic OTAwNjI3OTpzYXBAMTIzNA==", Constants.Device);
			//	if (result.StatusCode == "201") //success case
			//	{
			//		DebugDataSingleton.Instance.ApplicationConnectionId = result.Result.RegistrationObjectItem.ApplicationConnectionId;
			//		DebugDataSingleton.Instance.UserName = result.Result.RegistrationObjectItem.UserName;
			//		DebugDataSingleton.Instance.BasicAuth = authHeader;   //X-SMP-APPCID
			//		DebugDataSingleton.Instance.X_SMP_APPCID = result.Result.RegistrationObjectItem.ApplicationConnectionId;
			//		DebugDataSingleton.Instance.Language = "en";

			//		DebugDataSingleton.Instance.NesIndividualID = "IND";

			//		bool isHafiz = false;
			//		if (!isGuest)
			//		{
			//			var programs = await AWWebClient.Instance.GetAllPrograms();

			//			if (programs != null && programs.Result != null)
			//			{
			//				TmpObject.ProgramListRoot = programs.Result;
			//				foreach (ArabWaha.Models.Programs masterProgram in programs.Result.programList.programs)
			//				{
			//					if ((masterProgram.ProgramId == "1") || (masterProgram.ProgramId == "2"))
			//					{
			//						if ((masterProgram.Status == EnumGlobal.ProgramStatus.Eligible.GetHashCode().ToString()) ||
			//							(masterProgram.Status == EnumGlobal.ProgramStatus.Enrolled.GetHashCode().ToString()))
			//						{
			//							DebugDataSingleton.Instance.IsHafiz = true;
			//							isHafiz = true;
			//							break;
			//						}
			//					}
			//				}
			//			}
			//			DebugDataSingleton.Instance.UserMobileNumber = null;
			//			var resultIndividualProfile = await AWWebClient.Instance.GetIndividualProfileDetailsSet();
			//			if (resultIndividualProfile != null)
			//			{
			//				if (resultIndividualProfile.StatusCode == "200")
			//				{
			//					if (resultIndividualProfile.Result != null &&
			//						resultIndividualProfile.Result.ProfileBatchDetailList.ProfileBatchDetailSet != null &&
			//						resultIndividualProfile.Result.ProfileBatchDetailList.ProfileBatchDetailSet[0].GetIndividualProfileDetailsResponse != null &&
			//						resultIndividualProfile.Result.ProfileBatchDetailList.ProfileBatchDetailSet[0].GetIndividualProfileDetailsResponse.IndividualPersonalDetails != null)
			//					{
			//						DebugDataSingleton.Instance.UserMobileNumber = resultIndividualProfile.Result.ProfileBatchDetailList.ProfileBatchDetailSet[0].GetIndividualProfileDetailsResponse.IndividualPersonalDetails.MobileNumber;
			//						DebugDataSingleton.Instance.RegistrationStatus = resultIndividualProfile.Result.ProfileBatchDetailList.ProfileBatchDetailSet[0].GetIndividualProfileDetailsResponse.IndividualPersonalDetails.RegistrationStatus;
			//					}
			//				}
			//			}
			//			if (DebugDataSingleton.Instance.UserMobileNumber != null)
			//			{
			//				//var resultMobileUsability = await AWWebClient.Instance.CheckMobileUsability(DebugDataSingleton.Instance.UserMobileNumber);
			//				var resultMobileUsability = await AWWebClient.Instance.VerifyUser();
			//				if (resultMobileUsability.StatusCode == "200")
			//				{
			//					if (resultMobileUsability.Result != null)
			//					{
			//						//TODO: for debugging.. To be removed - Start
			//						//resultMobileUsability.Result.IndividualMobile.Code ="1"; 
			//						//TODO: for debugging.. To be removed - End
			//						if (resultMobileUsability.Result.VerifyUserRootList.VerifyUserList[0].mobileVerificationStatus.HasValue)
			//						{
			//							if (resultMobileUsability.Result.VerifyUserRootList.VerifyUserList[0].mobileVerificationStatus.Value == true)
			//							{
			//								DebugDataSingleton.Instance.IsPSORequired = false;
			//								if (isHafiz == true)
			//								{
			//									var psoRoot = await AWWebClient.Instance.OTPRequest(1, EnumGlobal.OTPRequestType.OTPRequest, string.Empty);
			//									if (psoRoot.StatusCode == System.Net.HttpStatusCode.InternalServerError.ToString())
			//									{
			//										DebugDataSingleton.Instance.IsPSORequired = true;
			//									}
			//								}
			//								DebugDataSingleton.Instance.LoginMode = EnumGlobal.LoginMode.Individual_Login;
			//								View.ShowLoading(false);
			//								View.ShowOnBoarding(isHafiz, isGuest, EnumGlobal.LoginMode.Individual_Login);
			//							}
			//							else // Mobile usability validation failed
			//							{
			//								DebugDataSingleton.Instance.LoginMode = EnumGlobal.LoginMode.Individual_Mobile;
			//								View.ShowLoading(false);
			//								View.ShowOnBoarding(isHafiz, isGuest, EnumGlobal.LoginMode.Individual_Mobile);
			//							}
			//						}
			//						else
			//						{
			//							View.ShowLoading(false);
			//							View.ShowError(result.StatusCode);
			//						}
			//					}
			//					else // Mobile usability check failed
			//					{
			//						View.ShowLoading(false);
			//						View.ShowError(result.StatusCode);
			//					}
			//				}
			//				else // Mobile usability check failed
			//				{
			//					View.ShowLoading(false);
			//					View.ShowError(result.StatusCode);
			//				}
			//				//Calling Employment pref call --calling as a parallel task as the result is not required immediatly after login
			//				GetEmploymentPreference();

			//			}
			//			else // Mobile not available user..
			//			{
			//				View.ShowLoading(false);
			//				View.ShowError(resultIndividualProfile.StatusCode);
			//			}
			//		}
			//		else // Guest User
			//		{
			//			var resultIndividual = await AWWebClient.Instance.GetCSRFTOKEN();
			//			//
			//			DebugDataSingleton.Instance.NesIndividualID = "0";

			//			View.ShowLoading(false);
			//			View.ShowOnBoarding(isHafiz, isGuest, loginMode);
			//		}


			//		//}
			//		//else // NESIndividualID fetch failed
			//		//{
			//		//  View.ShowLoading(false);
			//		//  View.ShowError(resultIndividual.StatusCode);
			//		//}
			//	}
			//	else  // User Registration failed
			//	{
			//		View.ShowLoading(false);
			//		View.ShowError(result.StatusCode);
			//	}
			//}
			//catch (Exception ex)
			//{
			//	View.ShowLoading(false);
			//	Debug.Print(ex.ToString());
			//	View.ShowError(getErrorMessageFromException(ex));
			//}
        }
     
    }
}
