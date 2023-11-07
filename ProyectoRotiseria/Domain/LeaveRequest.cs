using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LeaveRequest : BaseDomainEntity /*LeaveRequest=dejar petición es un objeto de dominio,Los objetos de dominio representan entidades del mundo real,como una solicitud de permiso.
                                                  * Los objetos de dominio suelen ser complejos y contienen toda la información necesaria para representar una entidad.*/
    {   
        

        public DateTime StartDate { get; set; }    

        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; } /*tipo de licencia*/

        public int LeaveTypeId { get; set; }

        public DateTime DateRequest {get; set; }

        public string  RequestComments { get; set; } /* SolicitudComentarios*/

        public DateTime? DateActioned { get; set; } /* "fecha de accion" podría utilizarse para almacenar la fecha en la que se creó un registro, 
                                                    * se modificó un archivo o se envió un correo electrónico.*/

        public bool? Approved { get; set; } 

        public bool Canceled { get; set; }
    }
}
