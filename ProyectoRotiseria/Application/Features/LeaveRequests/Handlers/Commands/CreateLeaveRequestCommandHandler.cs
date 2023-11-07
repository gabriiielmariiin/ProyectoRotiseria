using Application.DTOs.LeaveType.Validators;
using Application.DTOs.LeaveType;
using Application.Features.LeaveRequests.Requests.Commands;
using Application.Contracts.Persistence;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.LeaveRequest.Validators;
using Application.DTOs.LeaveRequest;
using Application.Exceptions;
using Application.Responses;
using Application.Contracts.Infrastructure;
using Application.Models;

namespace Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, BaseCommandResponse>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;
        

        public CreateLeaveRequestCommandHandler(
            ILeaveRequestRepository leaveRequestRepository,
            ILeaveTypeRepository leaveTypeRepository,
            IEmailSender emailSender,
            IMapper mapper)

        {
            _leaveTypeRepository = leaveTypeRepository;
            _emailSender = emailSender;
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
            
        }
        public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveRequestDtoValidator(_leaveRequestRepository);
            var validationResult = await validator.ValidateAsync(request.LeaveRequestDto, cancellationToken);


            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
               


            var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);



            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = leaveRequest.Id;

            var email = new Email
            {
                To = "employee@org.com",
                Body = $"your leave request for {request.LeaveRequestDto.StartDate:D} to {request.LeaveRequestDto.EndDate} has been submitted successfuly.",
                Subject = "leave request submitted"
            };
            try
            {
                await _emailSender.SendEmail(email);
                  
            }
            catch (Exception ex)
            {
                /// log or handle error, but don't throw... 
            }
                

            return response;

        }
    }
}
