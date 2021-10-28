using Als.Domain.Abstract;
using Als.Domain.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace Als.Domain.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AlsDbContext context;

        private DoorTypeRepository doorTypeRepository;
        private EmployeeRepository employeeRepository;
        private EngineTypeRepository engineTypeRepository;
        private LiftModelRepository liftModelRepository;
        private LiftRepository liftRepository;
        private LiftTypeRepository liftTypeRepository;
        private ManufacturerRepository manufacturerRepository;
        private MarkRepository markRepository;
        private PlaceRepository placeRepository;
        private PostRepository postRepository;
        private RequestRepository requestRepository;
        private RequestTypeRepository requestTypeRepository;
        private SectorRepository sectorRepository;
        private SecurityTypeRepository securityTypeRepository;
        private StationTypeRepository stationTypeRepository;

        public UnitOfWork(AlsDbContext context)
            => this.context = context;

        public IDoorTypeRepository DoorTypes => doorTypeRepository ??= new DoorTypeRepository(context);

        public IEmployeeRepository Employees => employeeRepository ??= new EmployeeRepository(context);

        public IEngineTypeRepository EngineTypes => engineTypeRepository ??= new EngineTypeRepository(context);

        public ILiftModelRepository LiftModels => liftModelRepository ??= new LiftModelRepository(context);

        public ILiftRepository Lifts => liftRepository ??= new LiftRepository(context);

        public ILiftTypeRepository LiftTypes => liftTypeRepository ??= new LiftTypeRepository(context);

        public IManufacturerRepository Manufacturers => manufacturerRepository ??= new ManufacturerRepository(context);

        public IMarkRepository Marks => markRepository ??= new MarkRepository(context);

        public IPlaceRepository Places => placeRepository ??= new PlaceRepository(context);

        public IPostRepository Posts => postRepository ??= new PostRepository(context);

        public IRequestRepository Requests => requestRepository ??= new RequestRepository(context);

        public IRequestTypeRepository RequestTypes => requestTypeRepository ??= new RequestTypeRepository(context);

        public ISectorRepository Sectors => sectorRepository ??= new SectorRepository(context);

        public ISecurityTypeRepository SecurityTypes => securityTypeRepository ??= new SecurityTypeRepository(context);

        public IStationTypeRepository StationTypes => stationTypeRepository ??= new StationTypeRepository(context);

        public void Save()
        {
            context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            context.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            context.Database.RollbackTransaction();
        }

        public EntityEntry Attach(object entity)
        {
            return context.Attach(entity);
        }

        public EntityEntry Entry(object entity)
        {
            return context.Entry(entity);
        }

        private readonly bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                context.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
