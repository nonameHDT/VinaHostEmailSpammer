using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace VinaHostEmailSpammer
{
	public partial class frmMain : Form
	{
		List<string> receiverEmailAddresses;
		string _mailFrom;
		string _mailSubject;
		string _mailFromPassword;
		string _mailContent;
		bool _isHTML;
		int mailSent = 0;

		public frmMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (tmrSendMail.Enabled == false)
			{
				receiverEmailAddresses = new List<string>(txtListMail.Lines);
				CheckEmailAddressFormat();

				if (receiverEmailAddresses.Count > 0)
				{
					if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
					{
						if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
						{
							if (!string.IsNullOrEmpty(rtbMailContent.Text.Trim()))
							{
								_mailFrom = txtEmail.Text;
								_mailFromPassword = txtPassword.Text;
								_mailSubject = txtSubject.Text;
								_mailContent = rtbMailContent.Text;
								_isHTML = cbxIsHtml.Checked;
								mailSent = 0;

								tmrSendMail.Interval = ((int)cbxDelaySeconds.Value) * 1000;
								tmrSendMail.Start();

								btnSend.Text = "Stop";
							}
							else
							{
								MessageBox.Show("Please enter email content.", "Notice");
							}
						}
						else
						{
							MessageBox.Show("Please enter your email password.", "Notice");
						}
					}
					else
					{
						MessageBox.Show("Please enter your email address.", "Notice");
					}
				}
				else
				{
					MessageBox.Show("Please enter at least one receiver email address.", "Notice");
				}
			}
			else
			{
				btnSend.Text = "Send";
				tmrSendMail.Stop();
			}
		}

		private void CheckEmailAddressFormat()
		{
			List<string> validAddresses = new List<string>();

			foreach (string address in receiverEmailAddresses)
			{
				string[] parts = address.Trim().Split('@');
				if (parts.Length > 1)
				{
					validAddresses.Add(address);
				}
			}

			receiverEmailAddresses = validAddresses;
		}

		private void SendEmail(string mailFrom, string mailFromPassword, string mailTo, string mailSubject, string mailContent, bool isHTML)
		{
			// cần sửa lại phần display name
			MailAddress sender = new MailAddress(mailFrom, "VinaHost.vn");
			MailAddress receiver = new MailAddress(mailTo);

			MailMessage message = new MailMessage(sender, receiver);
			message.Subject = mailSubject;
			message.Body = mailContent;
			message.IsBodyHtml = isHTML;

			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.EnableSsl = true;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential(mailFrom, mailFromPassword);

			try
			{
				smtpClient.Send(message);
			}
			catch (SmtpException ex)
			{
				if (ex.StatusCode == SmtpStatusCode.MustIssueStartTlsFirst)
					MessageBox.Show("Email or password is incorrect.", "Notice");
			}
		}

		private void tmrSendMail_Tick(object sender, EventArgs e)
		{
			string _mailTo = receiverEmailAddresses[0];
			receiverEmailAddresses.RemoveAt(0);
			SendEmail(_mailFrom, _mailFromPassword, _mailTo, _mailSubject, _mailContent, _isHTML);
			//update status
			mailSent++;
			lblStatus.Text = "Email Sent: " + mailSent.ToString();

			if (receiverEmailAddresses.Count <= 0)
			{
				tmrSendMail.Stop();
				btnSend.Text = "Send";
			}
		}

		private void txtListMail_TextChanged(object sender, EventArgs e)
		{
			label2.Text = "Receiver Email Addresses: " + txtListMail.Lines.Length.ToString();
		}
	}
}
