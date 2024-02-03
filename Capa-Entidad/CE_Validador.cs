using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Capa_Entidad
{
    public class CE_Validador
    {
        public static IEnumerable<ValidationResult> ValidarObjeto(Object obj)
        {
            var validacion = new List<ValidationResult>();  
            var contexto = new ValidationContext(obj, null, null);

            Validator.TryValidateObject(obj, contexto, validacion, true);

            return validacion;
        }
    }
}
