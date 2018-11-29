using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServer
{
    /// <summary>
    /// Descripción breve de TempServ
    /// </summary>
    [WebService(Namespace = "http://temperaturaTest.com.uy/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class TempServ : System.Web.Services.WebService
    {

        [WebMethod(Description = "Servicio para dar la temperatura de una ciudad")]
        public Double darTemperatura(String ciudad)
        {
            Double temperatura = 0;
            switch (ciudad)
            {
                case "Montevideo":
                    temperatura = 22.0;
                    break;
                case "Maldonado":
                    temperatura = 20.3;
                    break;
                case "Colonia":
                    temperatura = 21.6;
                    break;
                default:
                    temperatura = -100;
                    break;
            }
            return temperatura;
        }
    }
}
