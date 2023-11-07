using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveType.Validators
{
    public class UpdateLeaveTypeDtoValidator : AbstractValidator<LeaveTypeDto>
    {
        public UpdateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");/* la regla de validación especifica que la propiedad Id debe ser un número entero positivo.*/
                                                                                        
            
        }
    }
}
/*La expresión RuleFor(p => p.Id) significa "Define una regla de validación para la propiedad Id del objeto p."
 * En el contexto de FluentValidation, esta expresión se utiliza para crear una regla de validación que se aplicará a la propiedad Id de un objeto.
 * La regla de validación especifica los requisitos que debe cumplir la propiedad Id para ser considerada válida.*/