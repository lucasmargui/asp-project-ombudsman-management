using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gestao_Ouvidoria.Models;

namespace Gestao_Ouvidoria.Helpers
{
    public class CssTableHelper
    {
        public static string GetCssTableStyle(TipoStatus value)
        {
            if(value == TipoStatus.Respondida)
            {
                return "table-success";

            }else if(value == TipoStatus.Vencida)
            {
                return "table-warning";

            }else if(value == TipoStatus.Pendente)
            {
                return "table-primary";
            }
            else
            {
                return "table-danger";
            }

           
        }
    }
}