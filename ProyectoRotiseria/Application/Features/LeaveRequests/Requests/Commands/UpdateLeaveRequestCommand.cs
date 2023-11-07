using Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateLeaveRequestDto LeaveRequestDto { get; set; }

        public ChangeLeaveRequestApprovalDto ChangeLeaveRequestApprovalDto { get; set;}

    }
}
/*la propiedad ChangeLeaveRequestApprovalDto para definir un DTO que se puede utilizar para cambiar el estado de aprobación de una solicitud de licencia existente.*/