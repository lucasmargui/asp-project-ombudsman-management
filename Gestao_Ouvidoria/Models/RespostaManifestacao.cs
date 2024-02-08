using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gestao_Ouvidoria.Models
{
    [Table("RespostaManifestacoes")]
    public class RespostaManifestacao
    {
        [Key]
        [Display(Name = "Protocolo")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha a Resposta da Manifestação.")]
        [Display(Name = "Manifestação Resposta")]
        public string ManifestacaoResposta { get; set; }

 
        [Display(Name = "Arquivo")]
        public string Arquivo { get; set; }


        [ForeignKey("Manifestacao")]
        public int IdManifestacao { get; set; }

        public virtual Manifestacao Manifestacao { get; set; }
    }
}