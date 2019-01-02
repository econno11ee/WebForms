using InitialCSVUpload.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InitialCSVUpload
{
	public partial class _Default : Page
	{
		private MemberInfoRepository _repo = new MemberInfoRepository();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string csvPath = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload1.PostedFile.FileName);
			FileUpload1.SaveAs(csvPath);


			using (TextFieldParser parser = new TextFieldParser(csvPath))
			{
				parser.TextFieldType = FieldType.Delimited;
				parser.SetDelimiters(",");

				parser.ReadLine();
				while (!parser.EndOfData)
				{
					string[] fields = parser.ReadFields();

					Member member = new Member()
					{
						EmailAddress = fields[0],
						FirstName = fields[1],
						LastName = fields[2]
					};

					Member previousRecord = _repo.GetMembers().FirstOrDefault(x => x.EmailAddress == member.EmailAddress);
					if (previousRecord == null)
					{
						_repo.CreateRecord(member);
					}
					else
					{
						_repo.UpdateRecord(previousRecord, member);
					}
				}

				OutputLabel1.Text = $"You have successfully uploaded {FileUpload1.PostedFile.FileName} to the database!";
			}
		}
	}
}