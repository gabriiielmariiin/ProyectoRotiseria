using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveType.Validators
{
    public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());
                
        }
    }
}


/*public CreateLeaveTypeDtoValidator() y Include(new ILeaveTypeDtoValidator()); son parte de la biblioteca FluentValidation, 
 * que se utiliza para validar datos en aplicaciones ASP.NET Core.
 * la interfaz podría definir reglas para validar que el nombre del tipo de licencia no sea vacío y que el número de días predeterminado sea mayor que cero.*/