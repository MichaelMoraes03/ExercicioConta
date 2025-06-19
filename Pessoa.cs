namespace uou
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }


        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} - Idade: {Idade}";
        }

    }
}