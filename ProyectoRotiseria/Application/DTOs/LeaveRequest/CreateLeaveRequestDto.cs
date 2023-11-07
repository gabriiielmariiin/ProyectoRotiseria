using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto : ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }/*La fecha de inicio de la licencia*/

        public DateTime EndDate { get; set; } /*La fecha de finalización de la licencia.*/
        public int LeaveTypeId { get; set; } /*El identificador del tipo de licencia solicitada.*/
        public string RequestComments { get; set; } /*Comentarios adicionales sobre la solicitud de licencia.*/



    }
}
