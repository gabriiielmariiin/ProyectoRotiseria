using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Common
{
    public abstract class BaseDto
    {
        public int Id { get; set; } /*La clase LeaveRequestDto tiene todas las propiedades de la clase BaseDto, 
                                     * más algunas propiedades adicionales que son específicas de una solicitud de permiso de ausencia.*/
    }
}


/*solo estás creando el ID en la clase BaseDto porque es una propiedad común a todos los DTO.
/* Las clases que heredan de la clase BaseDto pueden agregar propiedades adicionales que sean específicas de su tipo de DTO.*/

