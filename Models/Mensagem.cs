using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesafioC5Arq.Models
{
    public class Mensagem : IValidatableObject
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Preencha o código da aplicação!")]
        [DisplayName("Cod Aplicação")]
        public string CodAplicacao { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Preencha o Texto!")]
        [StringLength(4000)]
        [DisplayName("Texto")]
        public string TextoMensagem { get; set; }

        [Required(ErrorMessage = "Escolha uma data inicial!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data Inicial")]
        public DateTime DataInicial { get; set; }

        [DisplayName("Data Final")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataFinal { get; set; }

        [DisplayName("Status")]
        public TipoStatus StatusMSG { get; set; }

        [DisplayName("Usuario Inclusão")]
        public string UsuarioInclusao { get; set; }

        [DisplayName("Data Inclusão")]
        public DateTime DataInclusao { get; set; }


        public enum TipoStatus
        {
            Inativo = 0,
            Ativo = 1
        }

        public Mensagem()
        {

        }

        public Mensagem NovaMensagem(string codAplicacao, string textoMensagem, DateTime dataInicial, DateTime dataFinal, TipoStatus statusMSG)
        {
            var msg = new Mensagem()
            {
                CodAplicacao = codAplicacao,
                TextoMensagem = textoMensagem,
                DataInicial = dataInicial,
                DataFinal = dataFinal,
                StatusMSG = statusMSG,
                UsuarioInclusao = Environment.UserName,
                DataInclusao = DateTime.Now
            };

            return msg;
        }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (DataInicial < DateTime.Today) results.Add(new ValidationResult("Data inicial não pode ser anterior a data atual!"));
            if (DataFinal < DataInicial) results.Add(new ValidationResult("Data final não pode ser anterior a data inicial!"));
            
            Validator.TryValidateObject(this, validationContext, results);
            return results;
        }
    }
}
