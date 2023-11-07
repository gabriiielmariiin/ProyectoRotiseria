using Application.DTOs.LeaveType;
using Application.DTOs.LeaveType.Validators;
using Application.Exceptions;
using Application.Features.LeaveTypes.Requests.Commands;
using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;

        }
        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto, cancellationToken);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
            var leaveType = await _leaveTypeRepository.Get(request.LeaveTypeDto.Id);
            _mapper.Map(request.LeaveTypeDto, leaveType);

            await _leaveTypeRepository.Update(leaveType);
            return Unit.Value;

        }
    }
}

/*El uso de la interfaz Unit es una buena práctica para los manejadores de comandos.
 * La interfaz Unit indica que el manejador de comandos no devuelve ningún valor.
 * Esto hace que el código sea más conciso y fácil de leer.
 * El código del manejador de comandos también utiliza el patrón de repositorio.
 * El repositorio es una capa de abstracción que proporciona acceso a los datos de la aplicación. */
