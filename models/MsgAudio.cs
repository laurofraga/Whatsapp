using System

public class MsgAudio : Mensagem
{
    public int Duracao { get; set; }
    public MsgAudio (Contato destinatario, string horaEnvio, string conteudo, int duracao)
     : base(destinatario, horaEnvio, conteudo)
    {
        Duracao = duracao;
    }

    public override string ToString()
    {
        return $"Mensagem de audio para: {Destinatario.Nome}, Celular: {Destinatario.Celular}, Enviada às: {HorarioEnvio}, Conteúdo: {Conteudo},  Duração: {Duracao}";
    }
}