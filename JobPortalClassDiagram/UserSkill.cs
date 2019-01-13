/// <summary>
/// UserSkill
/// </summary>
namespace JobPortalClassDiagram
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class UserSkill : Skill
    {
        /// <summary>The user identifier</summary>
        public Guid UserId;

        /// <summary>
        /// The password
        /// </summary>
        public Guid Password;
    }
}
