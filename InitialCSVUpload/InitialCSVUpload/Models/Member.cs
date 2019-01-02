using System;

namespace InitialCSVUpload.Models
{
	public class Member
	{
		public Guid ID { get; set; }
		public string EmailAddress { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}