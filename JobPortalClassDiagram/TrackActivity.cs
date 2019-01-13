/// <summary>
/// UserType
/// </summary>
namespace JobPortalClassDiagram
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class TrackActivity
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public Guid Id;

        /// <summary>
        /// The event created date
        /// </summary>
        public DateTime EventCreatedDate;

        /// <summary>
        /// The job identifier
        /// </summary>
        public Guid JobId;

        /// <summary>
        /// The applicant identifier
        /// </summary>
        public Guid ApplicantId;

        /// <summary>
        /// The advertiser identifier
        /// </summary>
        public Guid AdvertiserId;

        /// <summary>
        /// The job application identifier 
        /// </summary>
        public Guid JobApplicationId;

        /// <summary>
        /// The job match identifier
        /// </summary>
        public Guid JobMatchId;

        /// <summary>
        /// The event
        /// </summary>
        public string EventDetails;

        /// <summary>
        /// The activity type
        /// </summary>
        public Guid ActivityType;
    }
}
