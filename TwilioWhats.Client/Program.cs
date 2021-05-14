using System;
using TwilioWhats.Service;
using TwilioWhats.Utils;

namespace TwilioWhats.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var mediaUrl = new[] {
            //    new Uri("http://bibing.us.es/proyectos/abreproy/11833/fichero/2.Capitulo2.pdf")
            //}.ToList();

            var message = new Message(TwilioCredentials.TwilioWhatsSenderPhoneNumber, "5218711313971",
                "Hola juanca");
            var result = TwilioService.Send(message);

            if (result.IsValid)
                Console.WriteLine("se envio el mensaje exitosamente!");
            else
            {
                foreach (string error in result.Errors)
                    Console.WriteLine(error);
            }
        }
    }
}
