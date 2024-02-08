using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestao_Ouvidoria.Models
{
    public enum TipoStatusSetor
    {
        [Display(Name = "Encaminhado")]
        Encaminhado,
        [Display(Name = "Não encaminhado")]
        NaoEncaminhado
    }
}