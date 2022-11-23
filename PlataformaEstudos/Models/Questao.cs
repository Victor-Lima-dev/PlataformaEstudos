namespace PlataformaEstudos.Models
{
    public class Questao
    {
        public int QuestaoId { get; set; }
        public string EnunciadoQuestao { get; set; }
        public Pergunta Pergunta { get; set; }
        public Resposta Reposta { get; set; }
        public Anotacao AnotacaoOrigem { get; set; }


    }
}
