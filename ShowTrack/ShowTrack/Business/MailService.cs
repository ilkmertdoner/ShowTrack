using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using ShowTrack.DataAccess;
using ShowTrack.Entity;

namespace ShowTrack.Business
{
    public class MailService
    {
        private readonly IMailLogRepository _mailLogRepository;

        public MailService(IMailLogRepository mailLogRepository)
        {
            _mailLogRepository = mailLogRepository;
        }
        string email = ConfigurationManager.AppSettings["EmailUser"];
        string password = ConfigurationManager.AppSettings["EmailPassword"];
        public string SendVerificationCode(string TargetEmail)
        {
            try
            {

                string code = new Random().Next(100000, 999999).ToString();

                var log = new MailLog
                {
                    EmailAddress = TargetEmail,
                    VerificationCode = code,
                    Message = "Your verification code is: " + code
                };

                _mailLogRepository.AddLog(log);
                // You can change the SMTP settings as per your email provider
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    // Enter your email and password here
                    Credentials = new NetworkCredential(email, password),
                    EnableSsl = true,
                };
                // Enter your email and send the email
                smtpClient.Send(email, TargetEmail, "ShowTrack Verification", log.Message);
                return "Success";
            }

            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string SendVerificationCode(string TargetEmail, int id)
        {
            try
            {
                string code = new Random().Next(100000, 999999).ToString();

                var log = new MailLog
                {
                    UserId = id,
                    EmailAddress = TargetEmail,
                    VerificationCode = code,
                    Message = "Your verification code is: " + code
                };

                _mailLogRepository.AddLog(log);

                // You can change the SMTP settings as per your email provider
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    // Enter your email and password here
                    Credentials = new NetworkCredential(email, password),
                    EnableSsl = true,
                };

                // Enter your email and send the email
                smtpClient.Send(email, TargetEmail, "ShowTrack Verification", log.Message);
                return "Success";
            }

            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public bool Verify(string email, string enteredCode)
        {
            var log = _mailLogRepository.GetLastCodeByEmail(email);
            if (log != null && log.VerificationCode == enteredCode) return true;

            return false;
        }

        public void Delete(string email) { _mailLogRepository.DeleteByEmail(email); }
    }
}
