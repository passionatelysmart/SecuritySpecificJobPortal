/// <summary>
/// JobMatch
/// </summary>
namespace JobPortalClassDiagram
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class JobMatch
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public Guid Id;

        /// <summary>
        /// The advertiser identifier
        /// </summary>
        public Guid AdvertiserId;

        /// <summary>
        /// The applidcant identifier
        /// </summary>
        public Guid ApplidcantId;

        /// <summary>
        /// The skills
        /// </summary>
        public List<Guid> Skills;
    }
}
