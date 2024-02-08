using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gestao_Ouvidoria.Models
{
    [Table("Perfil")]
    public class Perfil
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o Nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o E-mail.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o Telefone.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Preencha o Celular.")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Preencha o Tipo Perfil")]
        public TipoPerfil TipoPerfil { get; set; }

  
        public virtual List<Manifestacao> Manifestacoes { get; set; }

    }
}