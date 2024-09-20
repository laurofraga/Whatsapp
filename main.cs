using System;

class Program
{
    static void Main (string[]args)

    Whatsapp whatsapp = new Whatsapp();

    Contato contato1 = new Contato("João", "9999-9999");
    Contato contato2 = new Contato("Maria", "8888-8888");
    whatsapp.Contatos.Add(contato1);
    whatsapp.Contatos.Add(contato2);


    MsgTexto msgTexto = new MsgTexto(contato1, "10:00", "Bom dia!", "Bom dia, João!");
    MsgAudio msgAudio = new MsgAudio(contato2, "10:01", "Bom dia!", 10);
    MsgFoto msgFoto = new MsgFoto(contato1, "10:02", "Foto de bom dia", 300);

    whatsapp.EnviarMensagem(msgTexto);
    whatsapp.EnviarMensagem(msgAudio);
    whatsapp.EnviarMensagem(msgFoto);

    whatsapp.ListarContatos();
    Console.WriteLine("--------------------");
    whatsapp.ListarMensagens();
}