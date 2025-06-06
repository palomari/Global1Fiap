using System;

namespace GlobalS
{
    public class Alerta
    {
        public string Local { get; set; }
        public DateTime DataHora { get; set; }
        public string Tipo { get; set; }

        public Alerta(string local, string tipo)
        {
            Local = local;
            Tipo = tipo;
            DataHora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"- {Tipo} em {Local} às {DataHora}";
        }
    }
}