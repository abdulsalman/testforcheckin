using System;
using System.Collections.Generic;
using ArabWaha.Core.Localization;
using ArabWaha.Enums;
using ArabWaha.Helpers;
using Newtonsoft.Json;
namespace ArabWaha
{
	public class TrainingLocation
	{
		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }
	}

	public class Address
	{
		[JsonProperty("buildingNumber")]
		public string BuildingNumber { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("geocodeLattitude")]
		public string GeocodeLattitude { get; set; }

		[JsonProperty("geocodeLongitude")]
		public string GeocodeLongitude { get; set; }

		[JsonProperty("postalCode")]
		public string PostalCode { get; set; }

		[JsonProperty("region")]
		public string Region { get; set; }

		[JsonProperty("streetName")]
		public string StreetName { get; set; }
	}

	public class IndividualPersonalDetails
	{
		[JsonProperty("nesIndividualId")]
		public string NesIndividualId { get; set; }

		[JsonProperty("individualFirstName")]
		public string IndividualFirstName { get; set; }

		[JsonProperty("individualSecondName")]
		public string IndividualSecondName { get; set; }

		[JsonProperty("individualThirdName")]
		public string IndividualThirdName { get; set; }

		[JsonProperty("individualLastName")]
		public string IndividualLastName { get; set; }

		[JsonProperty("individualDob")]
        public DateTime IndividualDob { get; set; }

		private string localMaritalStatus = string.Empty;

		[JsonProperty("maritalStatus")]
		public string MaritalStatus
		{
			get
			{
				if (localMaritalStatus != null)
				{
					int intValue = 0;
					int.TryParse(localMaritalStatus, out intValue);
					EnumGlobal.MaritalStatus maritalStatus = (EnumGlobal.MaritalStatus)intValue;
					return LocalizationHelper.GetString(maritalStatus.ToString());
				}
				else
					return "";

			}

			set
			{
				localMaritalStatus = value;
			}
		}

		[JsonProperty("address")]
		public Address Address { get; set; }

		private string localMobileNumber = string.Empty;
		[JsonProperty("mobileNumber")]
		public string MobileNumber
		{
			get
			{
				return ParserHelper.MobileNumberDisplay(localMobileNumber);
			}
			set { localMobileNumber = value; }
		}

		[JsonProperty("emailId")]
		public string EmailId { get; set; }

		[JsonProperty("registrationStatus")]
		public string RegistrationStatus { get; set; }
	}

	public class IndividualGeneralPreferences
	{
		[JsonProperty("aboutMe")]
		public string AboutMe { get; set; }

		private string localShiftType = string.Empty;
		[JsonProperty("shiftTypeId")]
		public string ShiftTypeId
		{
			get
			{
				if (localShiftType != null)
				{
					int intValue = 0;
					int.TryParse(localShiftType, out intValue);
					ShiftTypeEnum shiftType = (ShiftTypeEnum)intValue;
					return LocalizationHelper.GetString(shiftType.ToString());
				}
				else
					return "";
			}

			set
			{
				localShiftType = value;
			}
		}

		private string localHaveLicense = string.Empty;
		[JsonProperty("haveLicense")]
		public string HaveLicense
		{
			get
			{
				if (localHaveLicense != null)
				{
					EnumGlobal.General general = EnumGlobal.General.COMMON_No;
					if (localHaveLicense == EnumGlobal.General.COMMON_Yes.GetHashCode().ToString())
					{
						general = EnumGlobal.General.COMMON_Yes;
					}
					return LocalizationHelper.GetString(general.ToString());
				}
				else
					return "";
			}

			set
			{
				localHaveLicense = value;
			}
		}

		private string localLicenseCategory = string.Empty;
		[JsonProperty("drivingLicenseCategoryId")]
		public string DrivingLicenseCategoryId
		{
			get
			{
				if (!string.IsNullOrEmpty(localLicenseCategory))
				{
					string[] strType = localLicenseCategory.Split(':');
					string licenseTypes = string.Empty;
					if (strType.Length > 0)
					{
						foreach (string str in strType)
						{
							licenseTypes += LocalizationHelper.GetString(str) + "\n";
						}

						if (licenseTypes.Length > 0)
						{
							licenseTypes = licenseTypes.Substring(0, licenseTypes.Length - 2);
						}
					}
					return licenseTypes;
				}
				else
					return "";
			}

			set
			{
				localLicenseCategory = value;
			}
		}

		[JsonProperty("profileRefrenceNumber")]
		public string ProfileRefrenceNumber { get; set; }

		[JsonProperty("profileTitle")]
		public string ProfileTitle { get; set; }

		[JsonProperty("profilePercentage")]
		public string ProfilePercentage { get; set; }

		private string localActivelySearching = string.Empty;
		[JsonProperty("isActivelySearching")]
		public string IsActivelySearching
		{
			get
			{
				if (localActivelySearching != null)
				{
					bool boolValue = false;
					bool.TryParse(localActivelySearching, out boolValue);
					EnumGlobal.General general = EnumGlobal.General.COMMON_No;
					if (boolValue == true)
					{
						general = EnumGlobal.General.COMMON_Yes;
					}
					return LocalizationHelper.GetString(general.ToString());
				}
				else
					return "";
			}

			set
			{
				localActivelySearching = value;
			}
		}
	}

	public class EmploymentPreference
	{
		private string localTeleworking = string.Empty;
		[JsonProperty("teleworkingId")]
		public string TeleworkingId
		{
			get
			{
				if (localTeleworking != null)
					return LocalizationHelper.GetString(localTeleworking);
				else
					return "";
			}
			set
			{
				localTeleworking = value;
			}
		}
	}

	public class ListOfEmploymentPreferences
	{

		public EmploymentPreference EmploymentPreference { get; set; }
	}

	public class GetIndividualProfileDetailsResponse
	{
		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }

		public IndividualPersonalDetails IndividualPersonalDetails { get; set; }
		public IndividualGeneralPreferences IndividualGeneralPreferences { get; set; }
		public ListOfEmploymentPreferences ListOfEmploymentPreferences { get; set; }
	}

	public class Result
	{
		//Set 2
		[JsonProperty("nesIndividualId")]
		public string NesIndividualId { get; set; }

		private string localMajor = string.Empty;
		public string MajorAreaOfStudy
		{
			get
			{
				if (localMajor != null)
				{
					SpecialisationMajorFirstEnum majoFirstType = (SpecialisationMajorFirstEnum)Enum.Parse(typeof(SpecialisationMajorFirstEnum), localMajor);
					return LocalizationHelper.GetString(Convert.ToString(majoFirstType));
				}
				else
					return "";
			}
			set
			{

				localMajor = value;

			}
		}

		private string localCollegeId = string.Empty;
		[JsonProperty("collegeId")]
		public string CollegeId
		{
			get
			{
				if (localCollegeId != null)
				{
					if (UniversityTypeId.ToUpper().Trim() == EnumGlobal.UniversityTypeID.GOV.ToString())
					{
						return LocalizationHelper.GetDictionoryValue("GUNIVNAME", localCollegeId);
					}
					else
					{
						return LocalizationHelper.GetDictionoryValue("PUNIVNAME", localCollegeId);
					}
				}
				else
					return "";
			}
			set
			{
				localCollegeId = value;
			}
		}

		[JsonProperty("universityTypeId")]
		private string UniversityTypeId { get; set; }

		[JsonProperty("startDate")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("endDate")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("gpaScaleId")]
		public string GpaScaleId { get; set; }

		private string localGpaPoint = string.Empty;
		[JsonProperty("gpaPointValue")]
        public string GpaPointValue
        {
            get
            {
                if (GpaScaleId != null && localGpaPoint != null)
                {

                    if (GpaScaleId.ToUpper().Trim() == EnumGlobal.GPAScale.GPA.ToString())
                    {
                        return string.Format(LocalizationHelper.GetString(EnumGlobal.GPAScale.GPA.ToString()), localGpaPoint);
                    }
                    else if (GpaScaleId.ToUpper().Trim() == EnumGlobal.GPAScale.PERC.ToString())
                    {
                        return string.Format(LocalizationHelper.GetString(EnumGlobal.GPAScale.PERC.ToString()), localGpaPoint);
                    }
                    else
                    {
                        return localGpaPoint;
                    }
                }
                else
                {
                    return string.Empty;
                }

            }
            set
            {
                localGpaPoint = value;
            }
        }

		private string localEducationLevel = string.Empty;
		[JsonProperty("educationLevel")]
		public string EducationLevel
		{
			get
			{
				return LocalizationHelper.GetString(localEducationLevel);
			}
			set
			{
				localEducationLevel = value;
			}
		}

		//Set 3
		[JsonProperty("licenseName")]
		public string LicenseName { get; set; }

		[JsonProperty("expiryDate")]
		public DateTime? ExpiryDate { get; set; }


		public object ID { get; set; }

		//Set 4
		[JsonProperty("company")]
		public string Company { get; set; }

		private string localOccupationId = string.Empty;
		[JsonProperty("occupationId")]
		public string OccupationId
		{
			get
			{
				return LocalizationHelper.GetString(localOccupationId);
			}
			set
			{
				localOccupationId = value;
			}
		}

		private string localSector = string.Empty;
		[JsonProperty("sectorId")]
		public string SectorId
		{
			get
			{
				return LocalizationHelper.GetDictionoryValue("SEC", localSector);
			}
			set
			{
				localSector = value;
			}
		}

		[JsonProperty("salaryFromId")]
		public string SalaryFromId { get; set; }

		[JsonProperty("responsibilities")]
		public string Responsibilities { get; set; }

		//Set 5
		[JsonProperty("referenceName")]
		public string ReferenceName { get; set; }

		[JsonProperty("referenceRole")]
		public string ReferenceRole { get; set; }

		private string localContact = string.Empty;
		[JsonProperty("referenceContact")]
		public string ReferenceContact
		{
			get
			{
				return ParserHelper.MobileNumberDisplay(localContact);
			}
			set { localContact = value; }
		}

		//Set 6
		[JsonProperty("skillId")]
		public string SkillId { get; set; }

		private string localLanguage = string.Empty;
		[JsonProperty("language")]
		public string Language
		{
			get
			{
				return LocalizationHelper.GetDictionoryValue("LANG", localLanguage);
			}
			set { localLanguage = value; }
		}

		private string localLanguageLevel = string.Empty;
		[JsonProperty("languageLevel")]
		public string LanguageLevel
		{
			get
			{
				EnumGlobal.SkillLevel skill = (EnumGlobal.SkillLevel)Enum.Parse(typeof(EnumGlobal.SkillLevel), localLanguageLevel);
				return skill.GetHashCode().ToString();
			}
			set { localLanguageLevel = value; }
		}

		[JsonProperty("skillName")]
		public string SkillName { get; set; }

		private string localSkillLevel = string.Empty;
		[JsonProperty("skillLevel")]
		public string SkillLevel
		{
			get
			{
				EnumGlobal.SkillLevel skill = (EnumGlobal.SkillLevel)Enum.Parse(typeof(EnumGlobal.SkillLevel), localSkillLevel);
				return skill.GetHashCode().ToString();
			}
			set { localSkillLevel = value; }
		}

		[JsonProperty("publishSkill")]
		public string PublishSkill { get; set; }

		//Set 7
		[JsonProperty("trainingName")]
		public string TrainingName { get; set; }

		[JsonProperty("instituteName")]
		public string InstituteName { get; set; }

		[JsonProperty("certificateExpiryDate")]
		public DateTime? CertificateExpiryDate { get; set; }

		[JsonProperty("trainingLocation")]
		public TrainingLocation TrainingLocation { get; set; }

		//Profile Completeness
		public object ProgramCode { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }

		public object PersonalProfileCompletionPercentage { get; set; }
		public object CareerProfileCompletionPercentage { get; set; }
		public object ProfileCompletenessPercentage { get; set; }
	}

	public class ProfileBatchDetailSet
	{
		[JsonProperty("nesIndividualId")]
		public string NesIndividualId { get; set; }

		public GetIndividualProfileDetailsResponse GetIndividualProfileDetailsResponse { get; set; }
	}

	public class ProfileBatchDetailList
	{
		[JsonProperty("results")]
		public IList<ProfileBatchDetailSet> ProfileBatchDetailSet { get; set; }
	}

	public class ProfileBatchDetail
	{
		[JsonProperty("d")]
		public ProfileBatchDetailList ProfileBatchDetailList { get; set; }
	}

	public class ProfileBatchDetailResultSet
	{
		public IList<Result> results { get; set; }
	}

	public class ProfileBatchDetailResult
	{
		[JsonProperty("d")]
		public ProfileBatchDetailResultSet ProfileBatchDetailResultSet { get; set; }
	}

	public class ProfileBatchDetailContainer
	{
		public ProfileBatchDetail ProfileBatchDetail_1 { get; set; }
		public ProfileBatchDetailResult ProfileBatchDetail_2 { get; set; }
		public ProfileBatchDetailResult ProfileBatchDetail_3 { get; set; }
		public ProfileBatchDetailResult ProfileBatchDetail_4 { get; set; }
		public ProfileBatchDetailResult ProfileBatchDetail_5 { get; set; }
		public ProfileBatchDetailResult ProfileBatchDetail_6 { get; set; }
		public ProfileBatchDetailResult ProfileBatchDetail_7 { get; set; }
	}

	public class ProfileCompleteness
	{
		public IList<Result> results { get; set; }
	}
	public class ProfileCompletenessRoot
	{
		[JsonProperty("d")]
		public ProfileCompleteness ProfileCompleteness { get; set; }
	}
}
