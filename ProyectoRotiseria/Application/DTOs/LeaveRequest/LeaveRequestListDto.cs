using Application.DTOs.Common;
using Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto   /*creamos dentro de esta lista lo que queremos que devuleva o demuestre  al usuario,
                                                  * para que no traiga todos los datos, solo lo usamos para mostrar eso*/
    {
        public LeaveTypeDto LeaveType { get; set; }
        /*La propiedad LeaveType es de tipo public LeaveTypeDto. 
         * Esto significa que puede ser accedida y modificada por cualquier código que tenga acceso a la clase LeaveTypeDto.*/
        public DateTime DateRequest { get; set; }
        /*La propiedad DateRequest es de tipo DateTime. Esto significa que puede almacenar una fecha y hora.*/
        public bool? Approved { get; set; }
        /*La propiedad Approved es de tipo bool?. Esto significa que puede almacenar un valor booleano (true o false), o nulo.*/
    }
}
