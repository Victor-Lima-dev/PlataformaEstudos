namespace PlataformaEstudos.Models
{
    public class Pergunta
    {
        public int PerguntaId { get; set; }
        public string EnunciadoPergunta { get; set; }
        public Anotacao AnotacaoOrigem { get; set; }

        public Resposta RepostaCerta { get; set; }
    }
}
