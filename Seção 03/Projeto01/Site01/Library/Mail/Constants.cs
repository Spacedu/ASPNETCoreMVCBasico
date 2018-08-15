using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Library.Mail
{
    public class Constants
    {
        /**
         * POP3, IMAP - Ler mensagens de e-mail
         * SMTP - Enviar e-mail
         */

        //Autenticação - Gmail
        public readonly static string Usuario = "elias.ribeiro.s@gmail.com";
        public readonly static string Senha = "webjava10";

        //Servidor SMTP
        public readonly static string ServidorSMTP = "smtp.gmail.com";
        public readonly static int PortaSMTP = 587;
    }
}
