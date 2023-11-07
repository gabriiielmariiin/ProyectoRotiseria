using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveType
{
    public class LeaveTypeDto : BaseDto, ILeaveTypeDto /*el código LeaveTypeDto para definir la estructura de datos que se utilizará para representar un tipo de licencia.*/
    {
        public string Name { get; set; }

        public int DefaultDays { get; set; }

    }
}
/*El código LeaveTypeDto hereda de la clase BaseDto.
 * Esto significa que la clase LeaveTypeDto tiene todas las propiedades de la clase BaseDto,
 * además de las propiedades específicas del tipo de licencia.*/

/*La clase BaseDto es una clase abstracta que define las propiedades comunes a todos los DTO de la aplicación.*/
/*"asi funciona el programa.Cuando un usuario solicita ver un tipo de licencia existente,
 * la aplicación utilizará el identificador del tipo de licencia para recuperar el registro correspondiente de la base de datos.
 * La aplicación luego creará un nuevo objeto LeaveTypeDto a partir de los datos del registro de la base de datos.
 * El objeto LeaveTypeDto se pasará a la capa de presentación de la aplicación,
 * que lo utilizará para mostrar la información del tipo de licencia al usuario. 
 * Si el usuario desea editar la información del tipo de licencia,
 * la aplicación utilizará el objeto LeaveTypeDto para actualizar el registro correspondiente de la base de datos.*/