using System.Collections.Generic;

namespace WebHookReceiver.Models
{
    public class WebHookEvent
    {
		/// <summary>
        /// The ID of the User that caused this webhook to occur.
		/// </summary>
        public string userID { get; set; } = string.Empty;

		/// <summary>
        /// The company in which this webhook occurred.
		/// </summary>
		public string companyID { get; set; } = string.Empty;

		/// <summary>
        /// The source of the webhook. This is typically a database table name,
		/// may also refer to other sources in Odyssey, such as a production transaction.
		/// </summary>
		public string source { get; set; } = string.Empty;

		/// <summary>
        /// The action that was performed to cause this webhook. Example values are:
		/// 'ADD' to denote a new record, 'CHANGE' to denote an update, and 'DELETE' to denote record removal.
		/// </summary>
		public string action { get; set; } = string.Empty;

		/// <summary>
        /// An array of objects. If applicable, this array contains all the records that existed
		/// prior to the change. For example, if a Product is being updated, this would contain a
		/// single object that represents the Product before the change.
		/// </summary>
		public List<dynamic> previousData { get; set; } = null;

		/// <summary>
        /// An array of objects. If applicable, this array contains all the records that existed
		/// after the change. For example, if a Product is being updated, this would contain a
		/// single object that represents the Product after the change.
		/// </summary>
		public List<dynamic> data { get; set; } = null;
    }
}