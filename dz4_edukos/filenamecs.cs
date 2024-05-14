using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4_edukos
{
	public interface IMailConstructor
	{
		IMailConstructor AddSubject(string subject);
		IMailConstructor AddContent(string content);
		IMailConstructor AddRecipient(string recipient);
		IMailConstructor AddAttachments(string attachments);
		Mail Construct();
	}
	public class Mail
	{
		public string Subject { get; set; }
		public string Content { get; set; }
		public string Recipient { get; set; }
		public string Attachments { get; set; }
	}

	public class MailConstructor : IMailConstructor
	{
		Mail mail;
		public MailConstructor()
		{
			mail = new Mail();
		}
		public IMailConstructor AddContent(string content)
		{
			mail.Content = content;
			return this;
		}
		public IMailConstructor AddSubject(string subject)
		{
			mail.Subject = subject;
			return this;
		}
		public IMailConstructor AddRecipient(string recipient)
		{
			mail.Recipient = recipient;
			return this;
		}
		public IMailConstructor AddAttachments(string attachments)
		{
			mail.Attachments = attachments;
			return this;
		}
		public Mail Construct()
		{
			return mail;
		}
	}

	public class SMTP
	{
		IMailConstructor mailConstructor;
		public SMTP(IMailConstructor mailConstructor)
		{
			this.mailConstructor = mailConstructor;
		}
		public void SendNoReplyMail()
		{
			Mail mail=mailConstructor.AddSubject("No Reply").AddContent("Hello World").Construct();
			//Sending logic here
			SendMail(mail);
		}
	}
	public void SendMail(Mail mail)
	{
		Console.WriteLine(mail.Recipient);
		Console.WriteLine(mail.Content);
		Console.WriteLine(mail.Subject);
	}
}
