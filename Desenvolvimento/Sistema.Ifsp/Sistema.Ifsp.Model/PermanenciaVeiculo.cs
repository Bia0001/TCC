using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Ifsp.Model
{
    public class PermanenciaVeiculo
    {
        [Key]
        public int idPermanenciaVeiculo { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string prontuario { get; set; }
        public string telefone { get; set; }
        public string tipoSolicitante { get; set; }
        public string setor { get; set; }
        public string isDocente { get; set; }
        public string curso { get; set; }
        public string modulo { get; set; }
        public string turno { get; set; }
        public string anoLetivo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }
        public string servidorPublico1 { get; set; }
        public string servidorPublico2 { get; set; }
        public string servidorPublico3 { get; set; }
        public string servidorPublico4 { get; set; }
        public string prontuario1 { get; set; }
        public string prontuario2 { get; set; }
        public string prontuario3 { get; set; }
        public string prontuario4 { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime? dataSaida { get; set; }

        public virtual AssistenteAdministracao assistenteAdministracao { get; set; }
    }
}
