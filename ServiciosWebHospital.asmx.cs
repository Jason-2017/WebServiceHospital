using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceHospital
{
    /// <summary>
    /// Descripción breve de ServiciosWebHospital
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiciosWebHospital : System.Web.Services.WebService
    {

        //[WebService(Description = "verificar si el paciente (afiliado al seguro médico) se encuentra activo")]
        [WebMethod(Description = "verificar si el paciente (afiliado al seguro médico) se encuentra activo")]
        public string HelloWorld(   string nitProveedor,
                                    string codigoPaciente,
                                    DateTime fechaNacimiento,
                                    DateTime fechaInicioCobertura )
        {
            return nitProveedor;
        }
    }
}
