/// <summary>
/// Message
/// </summary>
namespace JobPortalClassDiagram
{
    using System;
    using System.Net.Mail;

    /// <summary>
    /// 
    /// </summary>
    public class Message
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public Guid Id;

        /// <summary>
        /// The code
        /// </summary>
        public Guid Type;

        /// <summary>
        /// The subject
        /// </summary>
        public string Subject;

        /// <summary>
        /// Converts to .
        /// </summary>
        public MailAddress To;

        /// <summary>
        /// From
        /// </summary>
        public MailAddress From;

        /// <summary>
        /// The sent date
        /// </summary>
        public DateTime SentDate;
    }
}
