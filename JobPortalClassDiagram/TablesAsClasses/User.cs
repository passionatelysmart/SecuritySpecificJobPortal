/// <summary>
/// User
/// </summary>
namespace JobPortalClassDiagram
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        /// <summary>
        /// The user identifier
        /// </summary>
        public Guid Id;

        /// <summary>
        /// The password
        /// </summary>
        public string Password;

        /// <summary>
        /// The name
        /// </summary>
        public string Name;

        /// <summary>
        /// The username
        /// </summary>
        public string Username;

        /// <summary>
        /// The current job availability
        /// </summary>
        public string CurrentJobAvailability;

        /// <summary>
        /// The current job opportunities
        /// </summary>
        public string CurrentJobOpportunities;

        /// <summary>
        /// The current job category
        /// </summary>
        public string CurrentJobCategory;

        /// <summary>
        /// The current industry experience
        /// </summary>
        public string CurrentIndustryExperience;       

        /// <summary>
        /// The current location
        /// </summary>
        public string CurrentLocation;

        /// <summary>
        /// The remote access availability
        /// </summary>
        public bool RemoteAccessAvailability;

        /// <summary>
        /// The desired day rate
        /// </summary>
        public int DesiredDayRate;

        /// <summary>
        /// The email
        /// </summary>
        public string Email;

        /// <summary>
        /// The current job title
        /// </summary>
        public string CurrentJobTitle;

        /// <summary>
        /// The current company name
        /// </summary>
        public string CurrentCompanyName;

        /// <summary>
        /// The phone contact
        /// </summary>
        public string PhoneContact;

        /// <summary>
        /// The skills
        /// </summary>
        public List<Guid> Skills;

        /// <summary>
        /// The user type
        /// </summary>
        public Guid UserType;

        /// <summary>
        /// The user actions
        /// </summary>
        public List<Guid> UserActions;

        /// <summary>
        /// The certifications
        /// </summary>
        public List<object> Certifications;

        /// <summary>
        /// The employers
        /// </summary>
        public List<object> Employers;

        /// <summary>
        /// The linked in profile
        /// </summary>
        public string LinkedInProfile;

        /// <summary>
        /// The github profile
        /// </summary>
        public string GithubProfile;

        /// <summary>
        /// The website
        /// </summary>
        public string Website;

        /// <summary>
        /// The age
        /// </summary>
        public int Age;

        /// <summary>
        /// The recieve notifications
        /// </summary>
        public bool RecieveNotifications;        

        /// <summary>
        /// The resume
        /// </summary>
        public object Resume;

        /// <summary>
        /// The photo
        /// </summary>
        public object Photo;
    }
}
