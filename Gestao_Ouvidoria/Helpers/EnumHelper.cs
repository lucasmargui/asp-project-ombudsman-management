using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Gestao_Ouvidoria.Helpers
{
    // Helper method to display the name of the enum values.
    public class EnumHelperAttribute
    {
        public static string GetDisplayName(Enum value)
        {
            return value.GetType()?
           .GetMember(value.ToString())?.First()?
           .GetCustomAttribute<DisplayAttribute>()?
           .Name;
        }
    }
}