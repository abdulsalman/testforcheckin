namespace ArabWaha.Models
{
    public class Translation
    {
        public class Default
        {
            public string cancel { get; set; }
            public string ok { get; set; }
            public string no { get; set; }
            public string yes { get; set; }
            public string retry { get; set; }
            public string edit { get; set; }
            public string save { get; set; }
            public string back { get; set; }
            public string settings { get; set; }
            public string later { get; set; }
            public string next { get; set; }
            public string previous { get; set; }
            public string skip { get; set; }
            public string english { get; set; }
            public string arabic { get; set; }
        }

        public class Error
        {
            public string authenticationError { get; set; }
            public string connectionError { get; set; }
            public string errorTitle { get; set; }
            public string unknownError { get; set; }
        }

        public class Intro
        {
            public string welcome { get; set; }
            public string welcomeSubTitle { get; set; }
            public string continueAsGuest { get; set; }
            public string getStarted { get; set; }
            public string getStartedSubTitle { get; set; }
            public string contact { get; set; }
            public string signup { get; set; }
            public string signin { get; set; }
        }


        public class Signin
        {
            public string title { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string forgottenPassword { get; set; }
            public string signinButton { get; set; }
        }

        public class Searchguest
        {
            public string searchJobName { get; set; }
            public string searchLocation { get; set; }
            public string searchDescription { get; set; }
            public string searchButton { get; set; }
            public string haveAccount { get; set; }
        }

        public class Signinotp
        {
            public string enterCode { get; set; }
            public string timeRemaining { get; set; }
            public string phoneMessage { get; set; }
            public string submit { get; set; }
            public string resend { get; set; }
        }

        public class ForgotPassword
        {
            public string sendButton { get; set; }
            public string title { get; set; }
            public string descriptionText { get; set; }
        }

        public class Terms
        {
            public string welcome { get; set; }
            public string termsTitle { get; set; }
            public string termsDescription { get; set; }
            public string infoTitle { get; set; }
            public string infoDescription { get; set; }
            public string termsSigninButton { get; set; }
        }

        public class Searchmain
        {
            public string title { get; set; }
            public string filter { get; set; }
        }

        public class Questionary
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string agreeButton { get; set; }
            public string continueButton { get; set; }
            public string confirmText { get; set; }
            public string addText { get; set; }
        }

        public class Programs
        {
            public string title { get; set; }
        }


        public class Program
        {
            public string title { get; set; }
            public string attend { get; set; }
            public string subtitle { get; set; }
            public string benefitTitle { get; set; }
            public string descriptionText { get; set; }
            public string registerTitle { get; set; }
            public string requirementsTitle { get; set; }
            public string whyTitle { get; set; }
            public string obligationTitle { get; set; }
        }

        public class Menu
        {
            public string menuHome { get; set; }
            public string menuProfile { get; set; }
            public string menuPrograms { get; set; }
            public string menuJobs { get; set; }
            public string menuContactUs { get; set; }
            public string menuSettings { get; set; }
            public string menuLogout { get; set; }
        }

        public class Settings
        {
            public string language { get; set; }
            public string resetPassword { get; set; }
            public string complaints { get; set; }
            public string about { get; set; }
            public string logout { get; set; }
            public string feedbackFooter { get; set; }
            public string title { get; set; }
        }

        public class Contact
        {
            public string title { get; set; }
            public string phonenumber { get; set; }
            public string email { get; set; }
            public string footerText { get; set; }
        }

        public class Profile
        {
            public string title { get; set; }
            public string username { get; set; }
            public string idNumber { get; set; }
            public string status { get; set; }
            public string personalInfo { get; set; }
            public string employmentPreference { get; set; }
            public string education { get; set; }
            public string workExperience { get; set; }
            public string skills { get; set; }
            public string language { get; set; }
            public string licenses { get; set; }
            public string training { get; set; }
            public string references { get; set; }
            public string awards { get; set; }
        }
        public class AppSettings
        {
			public string issalaryhidden { get; set; }
        }

        public Questionary questionary { get; set; }

            public Default @default { get; set; }
        public Error error { get; set; }
        public Intro intro { get; set; }
        public Signin signin { get; set; }
        public Searchguest searchguest { get; set; }
        public Signinotp signinotp { get; set; }
        public ForgotPassword forgotpassword { get; set; }
        public Terms terms { get; set; }
        public Searchmain searchmain { get; set; }
        public Programs programs { get; set; }
        public Program program { get; set; }
        public Menu menu { get; set; }
        public Settings settings { get; set; }
        public Contact contact { get; set; }
        public Profile profile { get; set; }
		public Global global { get; set; }
        public AppSettings appsettings { get; set; }

		public class Global
		{
			public string appname { get; set; }
			public string introguest { get; set; }
			public string introfragment0title { get; set; }
			public string introfragment0description { get; set; }
			public string introfragment1title { get; set; }
			public string introfragment1description { get; set; }
			public string introfragment1signin { get; set; }
			public string introfragment1signup { get; set; }
			public string jobapplicationcardviewTitleTextView { get; set; }
			public string jobLocationTitleTextView { get; set; }
			public string jobCompanyTitleTextView { get; set; }
			public string jobStatusTitleView { get; set; }
			public string jobapplicationStatusTitleView { get; set; }
			public string jobapplicationStatusTitle { get; set; }
			public string matchmatchScoreText { get; set; }
			public string matchedjobStatus { get; set; }
			public string titleApplyProgramAlert { get; set; }
			public string msgApplyProgramAlert { get; set; }
			public string btnTextApplyProgramCancel { get; set; }
			public string btnTextApplyProgramSubmit { get; set; }
			public string msgApplyProgramSubmitSuccess { get; set; }
			public string msgApplyProgramSubmitFailure { get; set; }
			public string msgCommonRequiredField { get; set; }
			public string msgNumberValid { get; set; }
			public string msgMoneyValid { get; set; }
			public string msgIncomeRequiredField { get; set; }
			public string locationunavailabilitymessage { get; set; }
			public string jobdetailsapplicationstatustext { get; set; }
			public string jobdetailsjobpostidtext { get; set; }
			public string jobdetailsjobtypetext { get; set; }
			public string jobdetailsoccupationtext { get; set; }
			public string jobdetailsopenpositiontext { get; set; }
			public string jobdetailsfilledpositiontext { get; set; }
			public string jobdetailssectortext { get; set; }
			public string jobdetailsminexptext { get; set; }
			public string jobdetailsdesiredstartdatetext { get; set; }
			public string jobdetailsoublicationstartdatetext { get; set; }
			public string jobdetailsdescriptionjobdetailstext { get; set; }
			public string jobdetailsgeneralheadertext { get; set; }
			public string jobdetailscardviewbenefitsheadertext { get; set; }
			public string jobdetailsbenefitssalaryfrom { get; set; }
			public string jobdetailsbenefitssalaryto { get; set; }
			public string jobdetailsbenefitsotherbenefits { get; set; }
			public string jobdetailsbenefitsbonusavailability { get; set; }
			public string jobdetailsbenefitsotherbenefits1 { get; set; }
			public string jobdetailsmethodheadertext { get; set; }
			public string jobdetailsmethodrequirementtext { get; set; }
			public string jobdetailsmethodsurveytext { get; set; }
			public string jobdetailsmethodtrainingreqtext { get; set; }
			public string jobdetailslocationheadertext { get; set; }
			public string jobdetailslocationaddresstext { get; set; }
			public string jobdetailslocationworktimetext { get; set; }
			public string jobdetailslocationshifttypetext { get; set; }
			public string jobdetailslocationteleworkingtext { get; set; }
			public string jobdetailslocationmobilitytext { get; set; }
			public string jobdetailslocationfootertext { get; set; }
			public string jobdetailsattachmentsheadertext { get; set; }
			public string jobdetailsqualificationsheadertext { get; set; }
			public string jobdetailsqualificationseducationtext { get; set; }
			public string jobdetailsqualificationsspecialisationtext { get; set; }
			public string jobdetailscontactheadertext { get; set; }
			public string jobdetailscontactbuttontext { get; set; }
			public string jobdetailsapplyjobbuttontext { get; set; }
			public string forgotpassword { get; set; }
			public string forgotpasswordtitle { get; set; }
			public string forgotpasswordinput { get; set; }
			public string forgotpasswordmessage { get; set; }
			public string forgotpasswordmessagefail { get; set; }
			public string ok { get; set; }
			public string signinguest { get; set; }
			public string signup { get; set; }
			public string skip { get; set; }
			public string mainannouncements { get; set; }
			public string mainappliedjobs { get; set; }
			public string mainmyprograms { get; set; }
			public string jobsmatchedjobs { get; set; }
			public string jobswatchlist { get; set; }
			public string logout { get; set; }
			public string sure { get; set; }
			public string yes { get; set; }
			public string no { get; set; }
			public string jobdetailsSkillHeader { get; set; }
			public string jobdetailsLanguageHeader { get; set; }
			public string jobdetailsLicensesHeader { get; set; }
			public string jobdetailsTrainingHeader { get; set; }
			public string appdetailscoverLetterHeader { get; set; }
			public string appdetailsNotesHeader { get; set; }
			public string appdetailsContactButtonText { get; set; }
			public string surveyResponseWarningTitle { get; set; }
			public string surveyResponseWarningMessage { get; set; }
			public string surveyResponseWarningOK { get; set; }
			public string applicationcoverletternotavailablemessage { get; set; }
			public string applicationnotesunavailablemessage { get; set; }
			public string applicationdescripunavailablemessage { get; set; }
			public string profileDateofBirth { get; set; }
			public string profileCity { get; set; }
			public string profileMobile { get; set; }
			public string profileEmail { get; set; }
			public string profileAddress { get; set; }
			public string profilePersonalinfo { get; set; }
			public string profileMaritalStatus { get; set; }
			public string profileEmploymentPreference { get; set; }
			public string profileLookingforJob { get; set; }
			public string profileShiftType { get; set; }
			public string profileTeleworking { get; set; }
			public string profileAboutMe { get; set; }
			public string profileProfile { get; set; }
			public string profileprofileCompleteness { get; set; }
			public string profileEducationLevelofEducation { get; set; }
			public string profileEducationMajor { get; set; }
			public string profileEducationInstitute { get; set; }
			public string profileEducationYears { get; set; }
			public string profileGPA { get; set; }
			public string profileWorkExperienceTitle { get; set; }
			public string profileWorkExperienceCompany { get; set; }
			public string profileWorkExperienceSector { get; set; }
			public string profileWorkExperienceYears { get; set; }
			public string profileWorkExperienceMonthlySalary { get; set; }
			public string profileWorkExperienceRolesResponsibility { get; set; }
			public string profileLicensesLicenseName { get; set; }
			public string profileLicensesExpiry { get; set; }
			public string profileLicensesDrivingLicense { get; set; }
			public string profileLicensesLicenseType { get; set; }
			public string profileTrainingTrainingName { get; set; }
			public string profileTrainingInstituteName { get; set; }
			public string profileTrainingLocation { get; set; }
			public string profileTrainingValidity { get; set; }
			public string profileReferencesName { get; set; }
			public string profileReferencesAssociation { get; set; }
			public string profileReferencesCompany { get; set; }
			public string profileReferencesPhone { get; set; }
			public string profileLanguagesTitle { get; set; }
			public string profileSkillsTitle { get; set; }
			public string profileSkillsTitle2 { get; set; }
			public string msgApplyJobSubmitSuccess { get; set; }
			public string msgfeedbackrequestSubmitSuccess { get; set; }
			public string msgApplyJobSubmitButton { get; set; }
			public string msgRequestFeedbackButton { get; set; }
			public string msgApplyJobcontactButton { get; set; }
			public string networknotconnectedmessage { get; set; }
			public string applyprogtitle { get; set; }
			public string applyprogdescription { get; set; }
			public string applyprogbank { get; set; }
			public string applyprogiban { get; set; }
			public string applyprogibanSA { get; set; }
			public string applyprogibanconditions { get; set; }
			public string applyprogcontact { get; set; }
			public string applyprogextraphone { get; set; }
			public string applyproginternet { get; set; }
			public string applyprogincome { get; set; }
			public string applyprogrent { get; set; }
			public string applyprogcourt { get; set; }
			public string applyprogother { get; set; }
			public string applyprogshare { get; set; }
			public string applyproggov { get; set; }
			public string applyprogadd { get; set; }
			public string applyprogsocial { get; set; }
			public string applyproggosi { get; set; }
			public string applyprogtotal { get; set; }
			public string applyprogsubmit { get; set; }
			public string filtertitle { get; set; }
			public string filtertype { get; set; }
			public string filterpermanent { get; set; }
			public string filtercontract { get; set; }
			public string filtermini { get; set; }
			public string filterintern { get; set; }
			public string filtersummer { get; set; }
			public string filtermale { get; set; }
			public string filtergender { get; set; }
			public string filterfemale { get; set; }
			public string filterworktype { get; set; }
			public string filterfull { get; set; }
			public string filterpart { get; set; }
			public string filtershift { get; set; }
			public string filterday { get; set; }
			public string filternight { get; set; }
			public string filtertwo { get; set; }
			public string filtertravel { get; set; }
			public string filtertele { get; set; }
			public string filtersalary { get; set; }
			public string filteredu { get; set; }
			public string filterele { get; set; }
			public string filterele1 { get; set; }
			public string filterhigh { get; set; }
			public string filterbach { get; set; }
			public string filtermast { get; set; }
			public string filterdoc { get; set; }
			public string filterspec { get; set; }
			public string filtergen { get; set; }
			public string filtereducation { get; set; }
			public string filterart { get; set; }
			public string filterstartdate { get; set; }
			public string filterstartdatevalue { get; set; }
			public string filtersocial1 { get; set; }
			public string filterbuss { get; set; }
			public string filternat { get; set; }
			public string filterict { get; set; }
			public string filtereng { get; set; }
			public string filteragr { get; set; }
			public string filterhealth { get; set; }
			public string filterapply { get; set; }
			public string seachkeywordhinttext { get; set; }
			public string seachlocationhinttext { get; set; }
			public string invalidloginmessage { get; set; }
			public string badrequestloginmessage { get; set; }
			public string postedonmonthtitle { get; set; }
			public string postedondaytitle { get; set; }
			public string nojobdataavailable { get; set; }
			public string nokeywordtyped { get; set; }
			public string guestsearcherrormsg { get; set; }
			public string guestsearcherrortitle { get; set; }
			public string msginvalidotp { get; set; }
			public string msgwaitfornextotp { get; set; }
			public string msgApplyJobSubmitFailure { get; set; }
			public string msgibanaccountlength { get; set; }
			public string complaintscardstatus { get; set; }
			public string complaintscardcomplaintid { get; set; }
			public string complaintscardcreatedon { get; set; }
			public string complaintscardclosedon { get; set; }
			public string titlePSO { get; set; }
			public string titleMobileVerification { get; set; }
			public string InfoMobileVerification { get; set; }
			public string InfoMobileVerification2 { get; set; }
			public string titleMobileChange { get; set; }
			public string filtersalarysubheadertext { get; set; }
			public string msgMobileRequired { get; set; }
			public string beneficial { get; set; }
			public string essential { get; set; }
			public string msgCommonRequiredWithoutField { get; set; }
			public string msgmobilelength { get; set; }
			public string applicationposteddatetitle { get; set; }
			public string applicationcardposteddatetitle { get; set; }
			public string programcalculatortitle { get; set; }
			public string programcalculatordescription { get; set; }
			public string programcalculatorsalaryhint { get; set; }
			public string programcalculatorpaymenttitle { get; set; }
			public string programcalculatorpaymentamounttitle { get; set; }
			public string month { get; set; }
			public string currency { get; set; }
			public string programcalculatorrangevalidationmsg { get; set; }
			public string loadingtext { get; set; }
			public string watchlistAddConfirmation { get; set; }
			public string msgMobileVerificationFailed { get; set; }
			public string searchForJobs { get; set; }
			public string jobpostreadmorebuttontext { get; set; }
			public string termsSubtitleForWebsite { get; set; }
			public string termsSubtitleForProgram { get; set; }
			public string resetpasswordfailuremessage { get; set; }
			public string questionInfoLeastImp { get; set; }
			public string questionInfoMostImp { get; set; }
			public string questionInfoRankTitle { get; set; }
			public string questionInfoRank { get; set; }
			public string questionInfoSelect { get; set; }
			public string questionRankWarning { get; set; }
			public string cardviewCollapseAll { get; set; }
			public string cardviewExpandAll { get; set; }
            public string filterany { get; set; }
		}

    }

}
