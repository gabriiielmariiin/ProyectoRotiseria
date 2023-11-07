using Domain.Common;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LeaveType : BaseDomainEntity /* leave type/tipo de licencia,Esta clase representa un tipo de permiso de ausencia.
                                               * Los objetos de dominio representan entidades del mundo real, como un tipo de permiso de ausencia.*/
    {
        

        public string Name { get; set; } /*El nombre del tipo de permiso de ausencia.*/

        public int DefaultDays { get; set; } /*El número predeterminado de días para el tipo de permiso de ausencia.*/




    }
}
