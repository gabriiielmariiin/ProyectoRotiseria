using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveAllocation
{
    public class UpdateLeaveAllocationDto : BaseDto, ILeaveAllocationDto /*UpdateLeaveAllocationDto,es para permitir a los usuarios actualizar la cantidad de días asignados
                                                     * para un tipo de licencia específico en un período determinado.*/

    {
        public int NumberOfDays {get; set;}

        public int LeaveTypeId { get; set;}

        public int Period {get; set;}
    }
}
