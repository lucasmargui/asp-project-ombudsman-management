using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gestao_Ouvidoria.Models
{
    public enum Campus
    {
        [Display(Name = "Volta Redonda")]
        VoltaRedonda,
        [Display(Name = "Barra do Pírai")]
        BarraDoPirai,
        [Display(Name = "Nova Iguaçu")]
        NovaIguacu
    }
}