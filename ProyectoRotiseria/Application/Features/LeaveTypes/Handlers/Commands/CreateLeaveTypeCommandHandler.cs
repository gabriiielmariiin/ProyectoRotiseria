using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using Domain;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Features.LeaveTypes.Requests.Commands;
using Application.DTOs.LeaveType.Validators;


namespace Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private ILeaveTypeRepository _leaveTypeRepository;
        private IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        /*Esta línea declara la función Handle(). La función es asíncrona, lo que significa que puede devolver una tarea
         *  La función también toma dos parámetros:
         *  request: Un objeto CreateLeaveTypeCommand que contiene la información del nuevo tipo de permiso.
         *  cancellationToken: Un token de cancelación que se puede utilizar para cancelar la operación si es necesario.*/


        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto, cancellationToken);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);/*Esta línea crea un nuevo objeto LeaveType
                                                                          * El mapper AutoMapper se utiliza para mapear objetos de un tipo a otro
                                                                          *  En este caso, el mapper se utiliza para mapear el objeto CreateLeaveTypeCommand al objeto LeaveType.*/

            leaveType = await _leaveTypeRepository.Add(leaveType);/*Esta línea llama al método Add() del repositorio LeaveTypeRepository para agregar el nuevo tipo de permiso a la base de datos.
                                                                   * El método Add() es asíncrono, lo que significa que devuelve una tarea que se completará cuando el tipo de permiso haya sido agregado a la base de datos.*/

            return leaveType.Id;/*Esta línea devuelve el identificador del nuevo tipo de permiso.*/
        }
    }
}
