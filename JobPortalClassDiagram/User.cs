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
        public Guid Password;

        /// <summary>
        /// The username
        /// </summary>
        public string Username;

        public List<Skill> Skills;

        /// <summary>
        /// The user type
        /// </summary>
        public UserType UserType;


    }
}
