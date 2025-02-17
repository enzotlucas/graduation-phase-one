﻿namespace PoliceDepartment.EvidenceManager.Domain.Case.UseCases
{
    public interface IDeleteCase<TResponse>
    {
        Task<TResponse> RunAsync(Guid id, Guid officerId, CancellationToken cancellationToken);
    }
}
