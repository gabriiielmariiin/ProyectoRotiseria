using Application.Contracts.Persistence;
using Application.DTOs.LeaveAllocation;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ProyectoRotiseriaDbContext _dbContext;

        public LeaveAllocationRepository(ProyectoRotiseriaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id)
        {
            var leaveAllocation = await _dbContext.LeaveAllocations
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);
            return leaveAllocation;
        }

        public async Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails()
        {
            var leaveAllocations = await _dbContext.LeaveAllocations
                .Include(q => q.LeaveType)
                .ToListAsync();
            return leaveAllocations;
            
        }

        
    }
    
}
