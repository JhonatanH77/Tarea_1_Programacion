using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Entidades;


namespace Tarea1.Negocios
{
    public class ClsDatos    
    {
        
        public String Validar(Datos datos)
        {
            String result;
            if (datos.Numero1 > datos.Numero2)
            {
                result = string.Format("El numero {0} es mayor al numero {1}", datos.Numero1, datos.Numero2);
            }else if(datos.Numero2 > datos.Numero1)
            {
                result = string.Format("El numero {0} es mayor al numero {1}", datos.Numero2, datos.Numero1);
            }
            else if (datos.Numero1 == datos.Numero2)
            {
                result = "Los numeros son iguales";
            }
            else
            {
                result = "¡Error!";
            }

            return result;
        }
    }
}
