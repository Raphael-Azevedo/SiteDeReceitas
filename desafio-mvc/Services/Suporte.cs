using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace desafio_mvc.Services
{
    public class Suporte
    {
        public void EnviarEmail(string emailDestinatario, string NomeDoUsuario)
        {
            MailMessage objMail = new MailMessage();
            objMail.To.Add(emailDestinatario);
            objMail.From = new MailAddress("starter.4.2022@outlook.com");

            string corpoEmail = "Olá " + NomeDoUsuario + @",
Obrigado por se inscrever conosco para usar as Receitas do Paladar Fit. Somos o Paladar Fit e somos o seu ponto de contato para começar a usar nossas receitas.
Se você tiver dúvidas ou quaisquer problemas, não hesite em entrar em contato conosco por este e-mail ou chat ao vivo no site.
Estamos ansiosos para ouvir de você em breve!
Cumprimentos,
Paladar Fit.";
            objMail.Body = corpoEmail;
            objMail.Subject = "Bem vindx ao PaladarFit";

            SmtpClient objSmtp = new SmtpClient();
            objSmtp.Host = "smtp-mail.outlook.com";
            objSmtp.Port = 587;
            objSmtp.UseDefaultCredentials = false;
            objSmtp.Credentials = new NetworkCredential("starter.4.2022@outlook.com","Gft@1234");
            objSmtp.EnableSsl = true;
            objSmtp.Send(objMail);
            
        }
    }
}