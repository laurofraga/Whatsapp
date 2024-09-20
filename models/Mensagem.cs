using System

public abstract class Mensagem
{
    public Contato Destinatario { get; set; }
    public string HorarioEnvio { get; set; } 
    public string Conteudo { get; set; }

    public Mensagem(Contato destinatario, string horaEnvio, string conteudo)
    {
        Destinatario = destinatario;
        HorarioEnvio = horaEnvio;
        Conteudo = conteudo;
    }

    public abstract override string ToString();
}