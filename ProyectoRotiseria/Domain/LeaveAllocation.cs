using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* la interfaz Domain se utiliza para encapsular la entidad de dominio LeaveAllocation.
 * . Esto significa que la entidad LeaveAllocation debe implementarse en el espacio de nombres Domain.*/
namespace Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        
        public int NumberOfDays { get; set; } /*número de días asignados para la licencia.*/

        public LeaveType? LeaveType { get; set; } /* leavetype es un tipo de licencia */

        public int? LeaveTypeId { get; set; }/*dentificador del tipo de licencia.*/

        public int Period { get; set; } /* período al que se aplica la asignación de licencia.*/




    }
}


/*el siguiente código crea un objeto LeaveAllocation para una asignación de vacaciones de 10 días:*/

/*LeaveAllocation vacationLeaveAllocation = new LeaveAllocation
{
    NumberOfDays = 10,
    DateCreated = DateTime.Now,
    LeaveType = leaveType,
    Period = 2023
};
*/