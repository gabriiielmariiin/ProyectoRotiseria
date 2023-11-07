using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveType
{
    public class CreateLeaveTypeDto : ILeaveTypeDto /*el código CreateLeaveTypeDto para definir la estructura de datos que se utilizará para crear un nuevo tipo de licencia.*/
    {
        public string Name { get; set; } /*El nombre del tipo de licencia.*/

        public int DefaultDays { get; set; } /* El número predeterminado de días para el tipo de licencia.*/
    }
}
/*La aplicación utilizará estos valores para crear un nuevo registro en la base de datos para el tipo de licencia.*/
/*Una vez que se ha creado un nuevo tipo de licencia, los usuarios pueden asignarlo a los empleados. 
 * Cuando un empleado solicita un permiso, la aplicación utilizará el número predeterminado de días,
 * para el tipo de permiso para calcular la cantidad de tiempo que el empleado puede ausentarse del trabajo.*/

