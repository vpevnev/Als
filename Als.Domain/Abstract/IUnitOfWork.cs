using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace Als.Domain.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IDoorTypeRepository DoorTypes { get; }
        IEmployeeRepository Employees { get; }
        IEngineTypeRepository EngineTypes { get; }
        ILiftModelRepository LiftModels { get; }
        ILiftRepository Lifts { get; }
        ILiftTypeRepository LiftTypes { get; }
        IManufacturerRepository Manufacturers { get; }
        IMarkRepository Marks { get; }
        IPlaceRepository Places { get; }
        IPostRepository Posts { get; }
        IRequestRepository Requests { get; }
        IRequestTypeRepository RequestTypes { get; }
        ISectorRepository Sectors { get; }
        ISecurityTypeRepository SecurityTypes { get; }
        IStationTypeRepository StationTypes { get; }

        void Save();

        Task SaveAsync();

        IDbContextTransaction BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();

        EntityEntry Attach(object entity);

        EntityEntry Entry(object entity);
    }
}
