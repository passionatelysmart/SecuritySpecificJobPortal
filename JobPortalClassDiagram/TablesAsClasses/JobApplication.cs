/// <summary>
/// JobApplication
/// </summary>
namespace JobPortalClassDiagram
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class JobApplication
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public Guid Id;

        /// <summary>
        /// The applicant identifier
        /// </summary>
        public Guid ApplicantId;

        /// <summary>
        /// The advertiser identifier
        /// </summary>
        public Guid AdvertiserId;

        /// <summary>
        /// The skills
        /// </summary>
        public List<Guid> Skills;

        /// <summary>
        /// The job applied date
        /// </summary>
        public DateTime JobAppliedDate;

        /// <summary>
        /// The additional note
        /// </summary>
        public string AdditionalNote;
    }
}
