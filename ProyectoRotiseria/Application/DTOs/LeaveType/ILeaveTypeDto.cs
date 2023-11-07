using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveType
{
    public interface ILeaveTypeDto /*Esta interfaz define un contrato para todos los DTOs de tipo LeaveType*/
    {
        public string Name { get; set; } /*El nombre del tipo de licencia.*/

        public int DefaultDays { get; set; } /* El número de días predeterminado para el tipo de licencia.*/
    }
}

/*l crear una interfaz para tus DTOs de tipo LeaveType, puedes asegurarte de que todos los DTOs de tipo LeaveType tengan las mismas propiedades básicas.*/