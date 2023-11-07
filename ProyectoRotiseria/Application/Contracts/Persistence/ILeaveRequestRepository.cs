using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*la interfaz ILeaveRequestRepository es una interfaz que se utiliza para trabajar con solicitudes de permiso. 
 *  la interfaz ILeaveRequestRepository podría definir un método para obtener todas las solicitudes de permiso para un empleado específico.
 *  La interfaz ILeaveRequestRepository hereda de la interfaz IGenericRepository<LeaveRequest>,
 *  lo que significa que tiene todos los métodos de la interfaz IGenericRepository<LeaveRequest>
 *   además de cualquier método adicional que se defina en la interfaz ILeaveRequestRepository.*/
namespace Application.Contracts.Persistence
{
    public interface  ILeaveRequestRepository : IGenericRepository <LeaveRequest>
    {
        
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);

        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();

        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus);
    }
}
