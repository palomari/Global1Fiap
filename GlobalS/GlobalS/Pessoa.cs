
namespace GlobalS
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Pessoa(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }
    }
}
