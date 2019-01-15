/// <summary>
/// Job
/// </summary>
namespace JobPortalClassDiagram
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Job
    {
        /// <summary>The user identifier</summary>
        public Guid Id;

        /// <summary>
        /// The category
        /// </summary>
        public string Category;

        /// <summary>
        /// The budget
        /// </summary>
        public string Budget;

        /// <summary>
        /// The location
        /// </summary>
        public string Location;

        /// <summary>
        /// The company identifier
        /// </summary>
        public string CompanyId;

        /// <summary>
        /// The user identifier
        /// </summary>
        public Guid AdvertiserId;

        /// <summary>
        /// The skills
        /// </summary>
        public List<Guid> Skills;

        /// <summary>
        /// The password
        /// </summary>
        public string Description;

        /// <summary>
        /// The designation      
        /// </summary>
        public string Designation;

        /// <summary>
        /// The type
        /// </summary>
        public string Type;

        /// <summary>
        /// The job information
        /// </summary>
        public string Information;

        /// <summary>
        /// The start date
        /// </summary>
        public DateTime StartDate;
    }
}

