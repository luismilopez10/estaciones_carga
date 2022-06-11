using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using pryRentaCarros.Model.EstacionCarga;
using pryRentaCarros.WebApiHttps.Controllers;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace pryRentaCarrosLambda.EstacionesCarga
{
    public class Function
    {

        /// <summary>
        /// Función Lambda que retorna las estaciones de carga de carros eléctricos
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<mdlEstacionCarga> EstacionesLambda(ILambdaContext context)
        {
            return new EstacionCargaController().fncConsultarEstacionCarga();
        }
    }
}
