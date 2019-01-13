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
        public string JobDescription;

        /// <summary>
        /// The job information
        /// </summary>
        public string JobInformation;
    }
}

