using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gestao_Ouvidoria.Models
{
    [Table("Manifestacoes")]
    public class Manifestacao
    {
        [Key]
        [Display(Name = "Protocolo")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o Campus.")]
        public Campus Campus { get; set; }

        [Required(ErrorMessage = "Preencha o Curso.")]
        public Curso Curso { get; set; }

        [Required(ErrorMessage = "Preencha o tipo de solicitação.")]
        [Display(Name = "Tipo de Solicitação")]
        public TipoSolicitacao TipoSolicitacao { get; set; }

        [Required(ErrorMessage = "Preencha o Setor.")]
        public Setor Setor { get; set; }

        [Required(ErrorMessage = "Preencha o Assunto.")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "Preencha a Manifestação.")]
        [Display(Name = "Manifestação")]
        public string ManifestacaoConteudo { get; set; }

        [Display(Name = "Cadastrado em")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:HH:mm dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }

        [Display(Name = "Modificado em")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:HH:mm dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Modified { get; set; }

        [Display(Name = "Status")]
        public TipoStatus Status { get; set; }

        [Display(Name = "Status Setor")]
        public TipoStatusSetor StatusSetor { get; set; }

        [Required]
        [ForeignKey("Perfil")]
        public int IdPerfil { get; set; }

        public virtual Perfil Perfil { get; set; }

        public virtual List<RespostaManifestacao> RespostaManifestacoes { get; set; }
    }
}