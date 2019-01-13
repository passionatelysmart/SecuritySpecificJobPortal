/// <summary>
/// Appointment
/// </summary>
namespace JobPortalClassDiagram
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class Appointment
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
        /// The appointment date
        /// </summary>
        public DateTime AppointmentDate;

        /// <summary>
        /// The venue
        /// </summary>
        public string Venue;
    }
}
