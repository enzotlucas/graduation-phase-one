﻿using Microsoft.EntityFrameworkCore;
using PoliceDepartment.EvidenceManager.Domain.Evidence;
using PoliceDepartment.EvidenceManager.Infra.Database.Mappings;
using System.Diagnostics.CodeAnalysis;

namespace PoliceDepartment.EvidenceManager.Infra.Database.Repositories
{
    [ExcludeFromCodeCoverage]
    public class EvidenceRepository : IEvidenceRepository
    {
        private readonly IAppDatabaseContext _context;

        public EvidenceRepository(IAppDatabaseContext context)
        {
            _context = context;
        } 

        public Task CreateAsync(EvidenceEntity evidence)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteByCaseAsync(Guid caseId, CancellationToken cancellationToken)
        {
            var evidences = await _context.Evidences.Where(e => e.CaseId == caseId).ToListAsync(cancellationToken);

            if (!evidences.Any())
                return;

            _context.Evidences.RemoveRange(evidences);
        }

        public async Task<EvidenceEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = await _context.Evidences.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

            return entity ?? new EvidenceEntity();
        }

        public Task<IEnumerable<EvidenceEntity>> GetPaginatedAsync(int page, int rows)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EvidenceEntity evidence)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                _context.Dispose();
        }
    }
}
