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
    public class UserType
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public Guid Id;

        /// <summary>
        /// The user identifier
        /// </summary>
        public Guid UserId;

        /// <summary>
        /// The user actions
        /// </summary>
        public List<Guid> UserActions;
       
    }
}
