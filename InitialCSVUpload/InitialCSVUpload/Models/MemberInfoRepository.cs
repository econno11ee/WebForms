using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InitialCSVUpload.Models
{
	public class MemberInfoRepository
	{
		MemberInfoDbContext _Context = new MemberInfoDbContext();
		public List<Member>GetMembers()
		{
			return (from m in _Context.Members
				   select m).ToList();
		}

		public void CreateRecord(Member member)
		{
			member.ID =  Guid.NewGuid();
			_Context.Members.Add(member);
			_Context.SaveChanges();
		}

		public void DeleteRecord(Member member)
		{
			Member memberToDelete = GetMembers().FirstOrDefault(x => x.Equals(member));
			_Context.Members.Remove(memberToDelete);
			_Context.SaveChanges();
		}

		public void UpdateRecord(Member previousMember, Member member)
		{
			if (previousMember.EmailAddress != member.EmailAddress ||
				previousMember.FirstName != member.FirstName || 
				previousMember.LastName != member.LastName)
			{
				DeleteRecord(previousMember);
				member.ID = previousMember.ID;
				CreateRecord(member);
			}
		}
	}
}