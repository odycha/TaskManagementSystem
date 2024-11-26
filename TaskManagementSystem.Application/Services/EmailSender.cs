using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;

namespace TaskManagementSystem.Application.Services
{
	public class EmailSender(IConfiguration configuration) : IEmailSender
	{
		private readonly IConfiguration _configuration = configuration;

		// Original method required by IEmailSender
		public async Task SendEmailAsync(string email, string subject, string htmlMessage)
		{
			var defaultFromAddress = _configuration["EmailSettings:DefaultEmailAddress"];
			await SendEmailWithCustomFromAsync(email, subject, htmlMessage, defaultFromAddress);
		}

		// New method that accepts a custom "from" email
		public async Task SendEmailWithCustomFromAsync(string email, string subject, string htmlMessage, string fromEmail)
		{
			var smtpServer = _configuration["EmailSettings:Server"];
			var smtpPort = Convert.ToInt32(_configuration["EmailSettings:Port"]);

			var message = new MailMessage
			{
				From = new MailAddress(fromEmail),
				Subject = subject,
				Body = htmlMessage,
				IsBodyHtml = true
			};

			message.To.Add(new MailAddress(email));

			using var client = new SmtpClient(smtpServer, smtpPort);
			await client.SendMailAsync(message);
		}
	}
}
