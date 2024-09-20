using System;
using System.Collections.Generic;

public class Whatsapp
{

    public List<Contato> Contatos { get; set; }
    public List<Mensagem> Mensagens { get; set; }

    public Whatsapp()
    {
        Contatos = new List<Contato>();
        Mensagens = new List<Mensagem>();
    }

    public void ListarContatos()
    {
        foreach (Contato contato in Contatos)
        {
            Console.WriteLine(contato);
        }
    }

    public void ListarMensagens()
    {
        foreach (Mensagem mensagem in Mensagens)
        {
            Console.WriteLine(mensagem);
        }
    }

    public void EnviarMensagem(Mensagem mensagem)
    {
        Mensagens.Add(mensagem);
    }
}