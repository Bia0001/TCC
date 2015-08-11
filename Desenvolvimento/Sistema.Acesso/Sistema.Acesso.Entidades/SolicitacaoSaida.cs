using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Acesso.Entidades
{
    public class SolicitacaoSaida
    {
        /*propriedades*/
        [Key]
        public int idSolicitacaoSaida { get; set; }
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
