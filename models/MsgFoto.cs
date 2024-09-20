using System

public class MsgFoto : Mensagem
{
    public int Tamanho { get; set; }
    public MsgFoto (Contato destinatario, string horaEnvio, string conteudo, int Tamanho)
     : base(destinatario, horaEnvio, conteudo)
    {
        Tamanho = tamanho;
    }

    public override string ToString()
    {
        return $"Mensagem de audio para: {Destinatario.Nome}, Celular: {Destinatario.Celular}, Enviada às: {HorarioEnvio}, Conteúdo: {Conteudo},  Tamanho: {Tamanho} KB";
    }
}