using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gestao_Ouvidoria.Models
{
    public enum TipoStatus
    {
        [Display(Name = "Respondida")]
        Respondida,
        [Display(Name = "Vencida")]
        Vencida,
        [Display(Name = "Pendente")]
        Pendente,
        [Display(Name = "Excluida")]
        Excluida
    }
}