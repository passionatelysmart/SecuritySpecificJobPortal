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
        /// The username
        /// </summary>
        public string Username;

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
        /// The resume
        /// </summary>
        public object Resume;          
    }
}
