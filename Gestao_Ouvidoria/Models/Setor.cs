using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Gestao_Ouvidoria.Models
{
    public enum Setor
    {
        [Display(Name = "Biblioteca")]
        Biblioteca,
        [Display(Name = "Centro de Atendimento")]
        Centro_de_Atendimento,
        [Display(Name = "Financeiro")]
        Financeiro,
        [Display(Name = "Secretaria")]
        Secretaria,
        [Display(Name = "Coordenação")]
        Coordenacao,
        [Display(Name = "Almoxarifado")]
        Almoxarifado
    }
}