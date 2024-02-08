using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gestao_Ouvidoria.Models
{
    public enum TipoSolicitacao
    {
        [Display(Name = "Elogio")]
        Elogio,
        [Display(Name = "Reclamação")]
        Reclamacao,
        [Display(Name = "Sugestão")]
        Sugestao,
        [Display(Name = "Outro")]
        Outro

    }
}