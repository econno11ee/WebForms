using System.Data.Entity;

namespace InitialCSVUpload.Models
{
	public class MemberInfoDbContext : DbContext
	{
		public MemberInfoDbContext() : base("MemberInfoDbContext")
		{
		}
		public DbSet<Member> Members { get; set; }
	}
}