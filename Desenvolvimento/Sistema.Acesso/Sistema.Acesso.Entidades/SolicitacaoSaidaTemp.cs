using System;

namespace Sistema.Acesso.Entidades
{
    public class SolicitacaoSaidaTemp
    {
        /*propriedades*/
        public int idSolicitacaoSaidaTemp { get; set; }
        public DateTime abertura { get; set; }
        public DateTime previsaoEncerramento { get; set; }
        public DateTime encerramento { get; set; }
        public string motivo { get; set; }
        public string status { get; set; }
        public Aluno aluno { get; set; }
        public AssistenteAluno assistenteAluno { get; set; }
        public Vigilante vigilante { get; set; }
    }
}
