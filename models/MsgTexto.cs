using System

public class MsgTexto : Mensagem
{
    public int NumChar { get; set; }
    public MsgTexto (Contato destinatario, string horaEnvio, string conteudo, int numChar)
     : base(destinatario, horaEnvio, conteudo)
    {
        NumChar = conteudo.Length;
    }

    public override string ToString()
    {
        return $"Mensagem de texto para: {Destinatario.Nome}, Celular: {Destinatario.Celular}, Enviada às: {HorarioEnvio}, Conteúdo: {Conteudo}, Número de caracteres: {NumChar}";
    }
}