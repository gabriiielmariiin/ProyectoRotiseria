using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Persistence
{
    /*Implementaría esta interfaz en una clase que realmente almacena asignaciones de vacaciones en una base de datos.
     * Por ejemplo, podría tener una clase llamada LeaveAllocationRepository que implementa ILeaveAllocationRepository.*/


    public interface ILeaveAllocationRepository : IGenericRepository <LeaveAllocation> /*La interfaz ILeaveAllocationRepository es un contrato para un repositorio que almacena asignaciones de vacaciones.*/
    {
        public Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
        /* GetLeaveAllocationWithDetails(int Id) Este método devuelve una asignación de vacaciones con sus detalles
         * , como el tipo de licencia, el empleado que solicitó la licencia y el estado de aprobación.*/
        public Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails();
        /*GetLeaveAllocationWithDetails(): Este método devuelve una lista de todas las asignaciones de vacaciones con sus detalles.*/
    }
}
