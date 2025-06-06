namespace GlobalS
{
    public class PessoaVulneravel : Pessoa
    {
        public string TipoDeficiencia { get; set; }

        public PessoaVulneravel(string nome, string endereco, string tipoDeficiencia)
            : base(nome, endereco)
        {
            TipoDeficiencia = tipoDeficiencia;
        }

        public override string ToString()
        {
            return $"- {Nome} | Endereço: {Endereco} | Deficiência: {TipoDeficiencia}";
        }
    }
}