using System 


    public class Contato
    {
        public string Nome { get; set; }
        public string Celular { get; set; }

        public Contato(string nome, string celular)
        {
            Nome = nome;
            Celular = Celular;
        }
        pblic override string ToString()
        {
            return $"Nome: {Nome}, Celular: {Celular}";
        }
    }
