namespace PlataformaEstudos.Models
{
    public class Resposta
    {
        public int RespostaId { get; set; }
        public string EnunciadoResposta { get; set; }
        public Pergunta PerguntaReferencia { get; set; }
        public Anotacao AnotacaoOrigem { get; set; }
    }
}
