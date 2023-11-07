using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {
        public bool? Approved { get; set; }
    }
}

/*Cuando un aprobador de licencias solicita cambiar el estado de aprobación de una solicitud de licencia existente,
 * la aplicación utilizará el identificador de la solicitud de licencia para recuperar el registro correspondiente de la base de datos.
 * La aplicación luego creará un nuevo objeto ChangeLeaveRequestApprovalDto a partir de los datos del registro de la base de datos.
 * El objeto ChangeLeaveRequestApprovalDto se pasará a la capa de presentación de la aplicación,
 * que lo utilizará para mostrar el estado de aprobación actual de la solicitud de licencia al aprobador.
 * Si el aprobador desea cambiar el estado de aprobación de la solicitud de licencia,
 * la aplicación utilizará el objeto ChangeLeaveRequestApprovalDto para actualizar el registro correspondiente de la base de datos.*/