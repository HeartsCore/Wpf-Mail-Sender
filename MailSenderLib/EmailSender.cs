using System.Net;
using System.Net.Mail;

namespace MailSenderLib
{
	/// <summary>
	/// 
	/// </summary>
    public sealed class EmailSender
    {
		/// <summary>
		/// Метод для отправки
		/// </summary>
		/// <param name="strUser"></param>
		/// <param name="strPass"></param>
		/// <exception cref="SmtpException"></exception>
		public void Send(string strUser, string strPass)
	    {
			

		    try
		    {
			    using (var message = new MailMessage(WpfTestMailSender.EmailFrom, WpfTestMailSender.EmailTo, WpfTestMailSender.TestMessage, WpfTestMailSender.TestMessageBody))

			    using (var client = new SmtpClient(WpfTestMailSender.ServerHost, WpfTestMailSender.ServerPort) { EnableSsl = true,
				    Credentials = new NetworkCredential(strUser, strPass) })
			    {
				    client.Send(message);
			    }

			}
		    catch (SmtpException error)
		    {
			   throw new SmtpException(error.Message);
		    }
		}
	}
}