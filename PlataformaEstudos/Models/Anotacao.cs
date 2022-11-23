namespace PlataformaEstudos.Models
{
    public class Anotacao
    {
        public int AnotacaoId { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public string Materia { get; set; } //depois vira uma lista de classe

    }
}
