using System.Net;
using System.Net.Mail;

namespace Dogs.WebApi.Services;

public class EmailService: IEmailService
{
    public EmailService()
    {
    }

    public async Task SendEmailAsync(string email, string subject, string message)
    {
        try
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("testgleb1@mail.ru", "TEST ZAPROS");
            // кому отправляем
            MailAddress to = new MailAddress(email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = subject;
            // текст письма
            m.Body = message;
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 465);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("testgleb1@mail.ru", "q!1423@w");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}