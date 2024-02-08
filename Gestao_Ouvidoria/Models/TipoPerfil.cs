using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gestao_Ouvidoria.Models
{
    public enum TipoPerfil
    {
        [Display(Name = "Aluno(a)")]
        Aluno,
        [Display(Name = "Pai de Aluno(a)")]
        Pai_de_Aluno,
        [Display(Name = "Professor(a)")]
        Professor,
        [Display(Name = "Funcionário(a)")]
        Funcionario,
        [Display(Name = "Visitante")]
        Visitante
    }
}