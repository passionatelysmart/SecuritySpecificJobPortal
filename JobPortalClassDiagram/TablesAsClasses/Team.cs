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
    public class Team
    {
        /// <summary>
        /// The user identifier
        /// </summary>
        public Guid Id;

        /// <summary>
        /// The password
        /// </summary>
        public string Name;

        /// <summary>
        /// The team created date
        /// </summary>
        public string TeamCreatedDate;

        /// <summary>
        /// The user ids
        /// </summary>
        public List<Guid> UserIds;        
    }
}
