using Application.DTOs.Common;
using Application.DTOs.LeaveType;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto : BaseDto /*La carpeta leave request en el espacio de nombres Application se utiliza para agrupar las clases que representan solicitudes de permiso de ausencia.
                                            * Las solicitudes de permiso de ausencia son objetos de aplicación. Los objetos de aplicación representan la lógica de negocio de una aplicación.
                                            * la clase LeaveRequestDto se utiliza para transferir datos entre la interfaz de usuario y la lógica de negocio. 
                                            * La clase LeaveRequestDto copia los mismos campos que en la clase LeaveRequest,
                                            * para que la interfaz de usuario pueda acceder a los datos de una solicitud de permiso de ausencia de forma sencilla.*/
    {

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public LeaveTypeDto LeaveType { get; set; } /*tipo de licencia*/

        public int LeaveTypeId { get; set; }

        public DateTime DateRequest { get; set; }

        public string RequestComments { get; set; } /* SolicitudComentarios*/

        public DateTime? DateActioned { get; set; }

        public bool? Approved { get; set; }

        public bool Canceled { get; set; }
    }
}
