using Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit> /*El comando UpdateLeaveTypeCommand implementa la interfaz IRequest<Unit>
                                                          * Esto significa que el comando puede ser ejecutado por un manejador de comandos para actualizar un tipo de licencia existente.
                                                          * UpdateLeaveTypeCommand para definir un comando que se puede utilizar para actualizar un tipo de licencia existente
                                                          * como el nombre y el número predeterminado de días.*/
                                                        
                                                         


    {
        public LeaveTypeDto LeaveTypeDto { get; set; }    
    }
}

/*Cuando un usuario solicita actualizar un tipo de licencia existente, la aplicación enviará un comando UpdateLeaveTypeCommand a un manejador de comandos.
 * El manejador de comandos utilizará la información contenida en el objeto LeaveTypeDto para actualizar el registro correspondiente del tipo de licencia en la base de datos.*/

