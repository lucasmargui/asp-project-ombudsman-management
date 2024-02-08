using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gestao_Ouvidoria.Models
{
    public enum Curso
    {
        [Display(Name = "Administração")]
        Administracao,
        [Display(Name = "Arquitetura e Urbanismo")]
        ArquiteturaUrbanismo,
        [Display(Name = "Biomedicina")]
        Biomedicina,
        [Display(Name = "Direito")]
        Direito,
        [Display(Name = "Engenharia Civil")]
        EngenhariaCivil,
        [Display(Name = "Engenharia de Produção")]
        EngenhariadeProducao,
        [Display(Name = "Engenharia Elétrica")]
        EngenhariaEletrica,
        [Display(Name = "Engenharia Mecânica")]
        EngenhariaMecanica,
        [Display(Name = "Gestão em Recursos Humanos")]
        RecursosHumanos,
        [Display(Name = "Graduação Tecnológica em Logística")]
        Logistica,
        [Display(Name = "Licenciatura em Ciências Biológicas")]
        CienciasBiologicas,
        [Display(Name = "Licenciatura em Geografica")]
        Geografica,
        [Display(Name = "Licenciatura em História")]
        Historia,
        [Display(Name = "Licenciatura em Letras")]
        Letras,
        [Display(Name = "Licenciatura em Matemática")]
        Matematica,
        [Display(Name = "Licenciatura em Pedagogia")]
        Pedagogia,
        [Display(Name = "Nutrição")]
        Nutricao,
        [Display(Name = "Psicologia")]
        Psicologia,
        [Display(Name = "Serviço Social")]
        ServicoSocial,
        [Display(Name = "Sistemas de Informação")]
        SistemasdeInformacao
    }
}